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
    public partial class NewPayment : Form
    {
        DAL dal = new DAL();
        ArrayList allDebitors, allCredits;

        // Конструктор
        public NewPayment()
        {
            InitializeComponent();

            Guid paymentID = Guid.NewGuid();
            textBox_PaymentID.Text = paymentID.ToString();
            allDebitors = dal.GetAllDebitors();
            if (allDebitors == null || allDebitors.Count == 0)
            {
                button_SaveNewPayment.Enabled = false;
                textBox_PaymentAmount.Enabled = false;
                dateTimePicker_PaymentDate.Enabled = false;
            }
            
            listBox_DebitorName.DataSource = allDebitors;
            listBox_DebitorID.DataSource = allDebitors;
        }

        // Кнопка Save new payment
        private void button_SaveNewPayment_Click(object sender, EventArgs e)
        {
            decimal payment;
            if (!decimal.TryParse(textBox_PaymentAmount.Text.Trim(), out payment))
            {
                MessageBox.Show("Недопустимое значение суммы платежа.", "Ошибка");
                return;
            }

            if (dal.SaveNewPayment(new Guid(textBox_PaymentID.Text.Trim()), new Guid(listBox_CreditID.SelectedValue.ToString()), decimal.Parse(textBox_PaymentAmount.Text), dateTimePicker_PaymentDate.Value))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        // Выбор элемента листбокса listBox_DebitorName
        private void listBox_DebitorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                allCredits = dal.GetAllCreditsForDebitor(listBox_DebitorName.SelectedValue.ToString());
            }
            catch(NullReferenceException) { }
           
            listBox_CreditID.DataSource = allCredits;
            listBox_CreditAmount.DataSource = allCredits;
            listBox_CreditBalance.DataSource = allCredits;

            if (allCredits == null || allCredits.Count == 0)
            {
                button_SaveNewPayment.Enabled = false;
                textBox_PaymentAmount.Enabled = false;
                dateTimePicker_PaymentDate.Enabled = false;
            }
            else
            {
                button_SaveNewPayment.Enabled = true;
                textBox_PaymentAmount.Enabled = true;
                dateTimePicker_PaymentDate.Enabled = true;
            }
            
            listBox_CreditID.DisplayMember = "ID";
            listBox_CreditID.ValueMember = "ID";
            listBox_CreditAmount.DisplayMember = "Amount";
            listBox_CreditAmount.ValueMember = "ID";
            listBox_CreditBalance.DisplayMember = "Balance";
            listBox_CreditBalance.ValueMember = "ID";
        }

        // Событие KeyPress в поле Amount
        private void textBox_PaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Регулировка возможности ввода запятых
            if (e.KeyChar == ',')
                if (textBox_PaymentAmount.Text == String.Empty || textBox_PaymentAmount.Text.Contains(','))
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Handled = false;
                    return;
                }

            short res;
            if(Int16.TryParse(e.KeyChar.ToString(), out res))
                e.Handled = false;
            else
                e.Handled = true;
        }

        // Событие Leave в поле Amount
        private void textBox_PaymentAmount_Leave(object sender, EventArgs e)
        {
            if (textBox_PaymentAmount.Text.Trim() == String.Empty)
            {
                label_PaymentMessage.ForeColor = Color.Red;
                label_PaymentMessage.Text = "Не введена сумма платежа!";
                button_SaveNewPayment.Enabled = false;
            }
            else
            {
                label_PaymentMessage.ForeColor = Color.Green;
                label_PaymentMessage.Text = "Ok";
                button_SaveNewPayment.Enabled = true;
            }

            decimal paymentValue = decimal.Parse(textBox_PaymentAmount.Text.Trim());
            if (paymentValue < 10 ||
                paymentValue > decimal.Parse(listBox_CreditBalance.SelectedValue.ToString()))
            {
                label_PaymentMessage.ForeColor = Color.Red;
                label_PaymentMessage.Text = "Недопустимая сумма платежа!";
                button_SaveNewPayment.Enabled = false;
            }
            else
            {
                label_PaymentMessage.ForeColor = Color.Green;
                label_PaymentMessage.Text = "Ok";
                button_SaveNewPayment.Enabled = true;
            }
        }

        private void button_PaymentClear_Click(object sender, EventArgs e)
        {
            label_PaymentMessage.ForeColor = Color.DeepSkyBlue;
            textBox_PaymentAmount.Text = String.Empty;
            label_PaymentMessage.Text = "Введите сумму платежа";
        }
    }
}
