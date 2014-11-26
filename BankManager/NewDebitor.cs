using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankManager
{
    // Форма для добавления нового дебитора в БД.
    public partial class NewDebitor : Form
    {
        DAL dal = new DAL();

        public NewDebitor()
        {
            InitializeComponent();

            textBoxDebitorID.Text = Guid.NewGuid().ToString();
        }

        // Кнопка Save new debitor
        private void button_SaveNewDebitor_Click(object sender, EventArgs e)
        {
            if( dal.SaveNewDebitor(textBoxDebitorID.Text.Trim(),
                textBoxDebitorName.Text.Trim(),
                textBoxDebitorPostNumber.Text.Trim(),
                textBoxDebitorPhoneNumber.Text.Trim().Replace(" ", "")))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }
    }
}
