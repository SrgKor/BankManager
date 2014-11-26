using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BankManager
{
    // Главная форма. Уровень бизнес логики и представления. (BLL and Presentable)
    public partial class MainForm : Form
    {
        DAL dal = new DAL();
        ArrayList allDebitors;

        // Конструктор
        public MainForm()
        {
            InitializeComponent();

            //Назначение источника данных для dataGridViewDebitors
            dataGridViewDebitors.DataSource = dal.GetAllDebitors();
            // Установка видимости столбцов dataGridViewDebitors
            DataGridViewDebitorsSettings();

            button_Next.Enabled = false;
            allDebitors = dal.GetAllDebitors();
        }

        // Установка видимости столбцов dataGridViewDebitors
        private void DataGridViewDebitorsSettings()
        {
            try
            {
                dataGridViewDebitors.Columns["ID"].Visible = false;
                dataGridViewDebitors.Columns["PostNumber"].Visible = false;
                dataGridViewDebitors.Columns["PhoneNumber"].Visible = false;
                dataGridViewDebitors.TopLeftHeaderCell.Value = "№";
            }
            catch(Exception e)
            {
                Console.WriteLine("\n\n" + e.TargetSite);
            }
        }

        // Обрабочик события изменение фокуса ячейки CellEnter для dataGridViewDebitors
        private void dataGridViewDebitors_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Заполнить textBox's
            textBoxDebitorID.Text = dataGridViewDebitors.CurrentRow.Cells["ID"].Value.ToString();
            textBoxDebitorName.Text = dataGridViewDebitors.CurrentRow.Cells["Name"].Value.ToString();
            textBoxDebitorPostNumber.Text = dataGridViewDebitors.CurrentRow.Cells["PostNumber"].Value.ToString();
            textBoxDebitorPhoneNumber.Text = dataGridViewDebitors.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            // Привязать дочерний dataGridViewCredits
            dataGridViewCredits.DataSource = dal.GetAllCreditsForDebitor(dataGridViewDebitors.CurrentRow.Cells["ID"].Value.ToString());
        }

        // Обрабочик события изменение фокуса ячейки CellEnter для dataGridViewCredits
        private void dataGridViewCredits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Связь родительского dataGridViewCredits и дочернего dataGridViewPayments
            dataGridViewPayments.DataSource =
                dal.GetAllPaymentsForCredit(dataGridViewCredits.CurrentRow.Cells["ID"].Value.ToString());
        }

        // Обрабочик события загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            // подписка на событие cellEnter - изменение фокуса ячейки
            dataGridViewDebitors.CellEnter += new DataGridViewCellEventHandler(dataGridViewDebitors_CellEnter);
            dataGridViewCredits.CellEnter += new DataGridViewCellEventHandler(dataGridViewCredits_CellEnter);
        }

        // Обработка события FormClosing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Завершение работы", MessageBoxButtons.OKCancel, MessageBoxIcon.Question ) 
                == DialogResult.Cancel)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();   //закрытие текущей формы
        }

        // Обработка события Меню -> Debitor -> Add new debitor
        private void addNewDebitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создание объекта формы.
            NewDebitor newDebitor = new NewDebitor();
            // метод .ShowDialog() открывает форму в модальном режиме
            if (newDebitor.ShowDialog() == DialogResult.OK)
            {
                dataGridViewDebitors.DataSource = dal.GetAllDebitors();
                MessageBox.Show("A new debitor was successfully added to the data base.", "Adding of a new debitor",
                    MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("No records were added to the data base!", "Adding of a new debitor",
                    MessageBoxButtons.OK);
        }

        // Обработка события Menu -> Credit -> Open new credit
        private void openNewCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCredit newCredit = new NewCredit();
            if (newCredit.ShowDialog() == DialogResult.OK)
            {
                dataGridViewCredits.DataSource = 
                    dal.GetAllCreditsForDebitor(dataGridViewDebitors.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("A new credit was successfully added to the data base.", "Adding of a new credit");
            }
            else
                MessageBox.Show("No records were added to the data base!", "Adding of a new credit");
        }

        // Обработка события Menu -> Payment -> Accept new Payment
        private void acceptPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPayment newPaiment = new NewPayment();
            if (newPaiment.ShowDialog() == DialogResult.OK)
            {
                dataGridViewCredits.DataSource =
                    dal.GetAllCreditsForDebitor(dataGridViewDebitors.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("A new payment was successfully added to the data base.", "Adding of a new payment");
            }
            else
                MessageBox.Show("No records were added to the data base!", "Adding of a new payment");
        }

        // Сохранение данных в локальном файле.
        private void safeAscsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dal.SaveDBToCSVFile())
                MessageBox.Show("Данные успешно сохранены.", 
                    "Сохранение БД в локальных файлах", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Ошибка! Данные не сохранены!", "Сохранение БД в локальных файлах", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
        }

        // Отображение номеров строк
        private void dataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object headValue = ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value;
            if(headValue == null || !headValue.Equals((e.RowIndex + 1).ToString()))
                ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        List<DataGridViewRow> foundRows;
        int currentRow;

        // Поиск в таблице Debitors
        private void button_Search_Click(object sender, EventArgs e)
        {
            string debName = textBox_SearchDebitorName.Text.Trim();
            string debPostNumber = textBox_SearchDebitorPostNumber.Text.Trim();
            string debPhoneNumber = textBox_DebitorPhoneNumber.Text.Trim();

            if (radioButton_ServerSearch.Checked == true)   // Поиск на сервере
            {
                button_Next.Enabled = false;
                ArrayList searched = dal.SearchForDebitors(debName, debPostNumber, debPhoneNumber);
                if (searched == null || searched.Count == 0)
                {
                    MessageBox.Show("Поиск не дал результатов");
                    return;
                }
                else
                {
                    MessageBox.Show("Найдено записей: "+ searched.Count);
                    dataGridViewDebitors.DataSource = searched;
                }
            }
            else                                            // Поиск на клиенте в DataGridView
            {
                dataGridViewDebitors.DataSource = allDebitors;
                foundRows = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dataGridViewDebitors.Rows)
                    if (row.Cells["Name"].FormattedValue.ToString().Contains(debName) &&
                        row.Cells["PostNumber"].FormattedValue.ToString().Contains(debPostNumber) &&
                        row.Cells["PhoneNumber"].FormattedValue.ToString().Contains(debPhoneNumber))
                        foundRows.Add(row);

                if (foundRows.Count == 0)
                {
                    MessageBox.Show("Поиск не дал результатов");
                    button_Next.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Найдено записей: " + foundRows.Count);
                    button_Next.Enabled = true;
                    currentRow = -1;
                    button_Next_Click(null, null);
                }
            }
        }

        // Переход к следующей строке в DataGridView
        private void button_Next_Click(object sender, EventArgs e)
        {
            if (currentRow == foundRows.Count - 1)
                currentRow = 0;
            else
                currentRow++;

            dataGridViewDebitors.CurrentCell = foundRows[currentRow].Cells[1];
        }
    }
}
