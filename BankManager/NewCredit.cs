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
    // Форма New Credit
    public partial class NewCredit : Form
    {
        DAL dal = new DAL();

        // Конструктор
        public NewCredit()
        {
            InitializeComponent();

            ArrayList allDebitors = new ArrayList();
            allDebitors = dal.GetAllDebitors();
            // блокировка полей при отсутствии списка дебиторов
            if (allDebitors == null || allDebitors.Count == 0)
            {
                textBoxCreditBalance.Enabled = false;
                textBoxCreditAmount.Enabled = false;
                dateTimePickerCreditOpenDate.Enabled = false;
                button_SaveNewCredit.Enabled = false;
            }
            textBoxCreditID.Text = Guid.NewGuid().ToString();
            listBoxDebitorID.DataSource = allDebitors;
            listBoxDebitorName.DataSource = allDebitors;
            button_SaveNewCredit.Enabled = false;
        }

        // Кнопка Save new credit
        private void button_SaveNewCredit_Click(object sender, EventArgs e)
        {
            if (textBoxCreditBalance.Text != "" && dal.SaveNewCredit
                (new Guid(textBoxCreditID.Text), 
                new Guid(listBoxDebitorID.SelectedValue.ToString()),
                Convert.ToInt32(textBoxCreditAmount.Text), 
                Convert.ToInt32(textBoxCreditBalance.Text),
                dateTimePickerCreditOpenDate.Value
                ))
                    this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        // При заполнении creditAmount должно автоматич. заполняться и creditBalance
        private void textBoxCreditAmount_TextChanged(object sender, EventArgs e)
        {
            textBoxCreditBalance.Text = textBoxCreditAmount.Text;
            button_SaveNewCredit.Enabled = true;
        }

        // Обработка события ввода символа в поле CreditAmount
        private void textBoxCreditAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // цифры [48; 57]
            // backspace 8
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        // Обработка события покидания поля CreditAmount
        private void textBoxCreditAmount_Leave(object sender, EventArgs e)
        {
            if (textBoxCreditAmount.Text == String.Empty ||
                Int32.Parse(textBoxCreditAmount.Text) < 100 ||
                Int32.Parse(textBoxCreditAmount.Text) > 1000000)
            {
                label_CreditAmountMessage.Text = "Invalid Credit Amount!";
                label_CreditAmountMessage.ForeColor = Color.OrangeRed;
                button_SaveNewCredit.Enabled = false;
            }
            else if(Int32.Parse(textBoxCreditAmount.Text) > 100 && Int32.Parse(textBoxCreditAmount.Text) < 1000001)
            {
                label_CreditAmountMessage.Text = "Ok";
                label_CreditAmountMessage.ForeColor = Color.Green;
                button_SaveNewCredit.Enabled = true;
            }
        }
    }
}
