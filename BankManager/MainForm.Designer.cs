namespace BankManager
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDebitors = new System.Windows.Forms.GroupBox();
            this.dataGridViewDebitors = new System.Windows.Forms.DataGridView();
            this.groupBoxDebitorDetails = new System.Windows.Forms.GroupBox();
            this.textBoxDebitorPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxDebitorPostNumber = new System.Windows.Forms.TextBox();
            this.textBoxDebitorName = new System.Windows.Forms.TextBox();
            this.textBoxDebitorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCredits = new System.Windows.Forms.GroupBox();
            this.dataGridViewCredits = new System.Windows.Forms.DataGridView();
            this.groupBoxPayments = new System.Windows.Forms.GroupBox();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_ClientSearch = new System.Windows.Forms.RadioButton();
            this.radioButton_ServerSearch = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_DebitorPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_SearchDebitorPostNumber = new System.Windows.Forms.TextBox();
            this.textBox_SearchDebitorName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safeAscsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDebitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceptPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDebitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebitors)).BeginInit();
            this.groupBoxDebitorDetails.SuspendLayout();
            this.groupBoxCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredits)).BeginInit();
            this.groupBoxPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDebitors
            // 
            this.groupBoxDebitors.Controls.Add(this.dataGridViewDebitors);
            this.groupBoxDebitors.Location = new System.Drawing.Point(12, 97);
            this.groupBoxDebitors.Name = "groupBoxDebitors";
            this.groupBoxDebitors.Size = new System.Drawing.Size(333, 187);
            this.groupBoxDebitors.TabIndex = 0;
            this.groupBoxDebitors.TabStop = false;
            this.groupBoxDebitors.Text = "Дебиторы";
            // 
            // dataGridViewDebitors
            // 
            this.dataGridViewDebitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDebitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDebitors.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDebitors.Name = "dataGridViewDebitors";
            this.dataGridViewDebitors.Size = new System.Drawing.Size(327, 168);
            this.dataGridViewDebitors.TabIndex = 0;
            this.dataGridViewDebitors.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_RowPrePaint);
            // 
            // groupBoxDebitorDetails
            // 
            this.groupBoxDebitorDetails.Controls.Add(this.textBoxDebitorPhoneNumber);
            this.groupBoxDebitorDetails.Controls.Add(this.textBoxDebitorPostNumber);
            this.groupBoxDebitorDetails.Controls.Add(this.textBoxDebitorName);
            this.groupBoxDebitorDetails.Controls.Add(this.textBoxDebitorID);
            this.groupBoxDebitorDetails.Controls.Add(this.label4);
            this.groupBoxDebitorDetails.Controls.Add(this.label3);
            this.groupBoxDebitorDetails.Controls.Add(this.label2);
            this.groupBoxDebitorDetails.Controls.Add(this.label1);
            this.groupBoxDebitorDetails.Location = new System.Drawing.Point(358, 97);
            this.groupBoxDebitorDetails.Name = "groupBoxDebitorDetails";
            this.groupBoxDebitorDetails.Size = new System.Drawing.Size(425, 187);
            this.groupBoxDebitorDetails.TabIndex = 1;
            this.groupBoxDebitorDetails.TabStop = false;
            this.groupBoxDebitorDetails.Text = "Подробности";
            // 
            // textBoxDebitorPhoneNumber
            // 
            this.textBoxDebitorPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDebitorPhoneNumber.Location = new System.Drawing.Point(130, 130);
            this.textBoxDebitorPhoneNumber.Name = "textBoxDebitorPhoneNumber";
            this.textBoxDebitorPhoneNumber.ReadOnly = true;
            this.textBoxDebitorPhoneNumber.Size = new System.Drawing.Size(106, 23);
            this.textBoxDebitorPhoneNumber.TabIndex = 7;
            // 
            // textBoxDebitorPostNumber
            // 
            this.textBoxDebitorPostNumber.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorPostNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDebitorPostNumber.Location = new System.Drawing.Point(130, 101);
            this.textBoxDebitorPostNumber.Name = "textBoxDebitorPostNumber";
            this.textBoxDebitorPostNumber.ReadOnly = true;
            this.textBoxDebitorPostNumber.Size = new System.Drawing.Size(106, 23);
            this.textBoxDebitorPostNumber.TabIndex = 6;
            // 
            // textBoxDebitorName
            // 
            this.textBoxDebitorName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxDebitorName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDebitorName.Location = new System.Drawing.Point(130, 72);
            this.textBoxDebitorName.Name = "textBoxDebitorName";
            this.textBoxDebitorName.ReadOnly = true;
            this.textBoxDebitorName.Size = new System.Drawing.Size(289, 23);
            this.textBoxDebitorName.TabIndex = 5;
            // 
            // textBoxDebitorID
            // 
            this.textBoxDebitorID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDebitorID.Location = new System.Drawing.Point(130, 43);
            this.textBoxDebitorID.Name = "textBoxDebitorID";
            this.textBoxDebitorID.ReadOnly = true;
            this.textBoxDebitorID.Size = new System.Drawing.Size(289, 23);
            this.textBoxDebitorID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Debitor Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Debitor PostNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Debitor Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debitor ID";
            // 
            // groupBoxCredits
            // 
            this.groupBoxCredits.Controls.Add(this.dataGridViewCredits);
            this.groupBoxCredits.Location = new System.Drawing.Point(12, 287);
            this.groupBoxCredits.Name = "groupBoxCredits";
            this.groupBoxCredits.Size = new System.Drawing.Size(771, 117);
            this.groupBoxCredits.TabIndex = 2;
            this.groupBoxCredits.TabStop = false;
            this.groupBoxCredits.Text = "Кредиты";
            // 
            // dataGridViewCredits
            // 
            this.dataGridViewCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCredits.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCredits.Name = "dataGridViewCredits";
            this.dataGridViewCredits.Size = new System.Drawing.Size(765, 98);
            this.dataGridViewCredits.TabIndex = 0;
            this.dataGridViewCredits.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_RowPrePaint);
            // 
            // groupBoxPayments
            // 
            this.groupBoxPayments.Controls.Add(this.dataGridViewPayments);
            this.groupBoxPayments.Location = new System.Drawing.Point(12, 407);
            this.groupBoxPayments.Name = "groupBoxPayments";
            this.groupBoxPayments.Size = new System.Drawing.Size(772, 198);
            this.groupBoxPayments.TabIndex = 3;
            this.groupBoxPayments.TabStop = false;
            this.groupBoxPayments.Text = "Платежи";
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPayments.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.Size = new System.Drawing.Size(766, 179);
            this.dataGridViewPayments.TabIndex = 0;
            this.dataGridViewPayments.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_RowPrePaint);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.panel1);
            this.groupBoxSearch.Controls.Add(this.label7);
            this.groupBoxSearch.Controls.Add(this.label6);
            this.groupBoxSearch.Controls.Add(this.label5);
            this.groupBoxSearch.Controls.Add(this.button_Next);
            this.groupBoxSearch.Controls.Add(this.button_Search);
            this.groupBoxSearch.Controls.Add(this.textBox_DebitorPhoneNumber);
            this.groupBoxSearch.Controls.Add(this.textBox_SearchDebitorPostNumber);
            this.groupBoxSearch.Controls.Add(this.textBox_SearchDebitorName);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 27);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(771, 64);
            this.groupBoxSearch.TabIndex = 4;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск по дебиторам";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_ClientSearch);
            this.panel1.Controls.Add(this.radioButton_ServerSearch);
            this.panel1.Location = new System.Drawing.Point(568, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 43);
            this.panel1.TabIndex = 9;
            // 
            // radioButton_ClientSearch
            // 
            this.radioButton_ClientSearch.AutoSize = true;
            this.radioButton_ClientSearch.Location = new System.Drawing.Point(4, 21);
            this.radioButton_ClientSearch.Name = "radioButton_ClientSearch";
            this.radioButton_ClientSearch.Size = new System.Drawing.Size(81, 17);
            this.radioButton_ClientSearch.TabIndex = 1;
            this.radioButton_ClientSearch.TabStop = true;
            this.radioButton_ClientSearch.Text = "на клиенте";
            this.radioButton_ClientSearch.UseVisualStyleBackColor = true;
            // 
            // radioButton_ServerSearch
            // 
            this.radioButton_ServerSearch.AutoSize = true;
            this.radioButton_ServerSearch.Checked = true;
            this.radioButton_ServerSearch.Location = new System.Drawing.Point(4, 3);
            this.radioButton_ServerSearch.Name = "radioButton_ServerSearch";
            this.radioButton_ServerSearch.Size = new System.Drawing.Size(82, 17);
            this.radioButton_ServerSearch.TabIndex = 0;
            this.radioButton_ServerSearch.TabStop = true;
            this.radioButton_ServerSearch.Text = "на сервере";
            this.radioButton_ServerSearch.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Пост-номер\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ФИО";
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(688, 15);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(77, 42);
            this.button_Next.TabIndex = 4;
            this.button_Next.Text = "Следующий";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(476, 15);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(86, 42);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_DebitorPhoneNumber
            // 
            this.textBox_DebitorPhoneNumber.Location = new System.Drawing.Point(361, 38);
            this.textBox_DebitorPhoneNumber.Name = "textBox_DebitorPhoneNumber";
            this.textBox_DebitorPhoneNumber.Size = new System.Drawing.Size(94, 20);
            this.textBox_DebitorPhoneNumber.TabIndex = 2;
            // 
            // textBox_SearchDebitorPostNumber
            // 
            this.textBox_SearchDebitorPostNumber.Location = new System.Drawing.Point(261, 37);
            this.textBox_SearchDebitorPostNumber.Name = "textBox_SearchDebitorPostNumber";
            this.textBox_SearchDebitorPostNumber.Size = new System.Drawing.Size(94, 20);
            this.textBox_SearchDebitorPostNumber.TabIndex = 1;
            // 
            // textBox_SearchDebitorName
            // 
            this.textBox_SearchDebitorName.Location = new System.Drawing.Point(9, 37);
            this.textBox_SearchDebitorName.Name = "textBox_SearchDebitorName";
            this.textBox_SearchDebitorName.Size = new System.Drawing.Size(246, 20);
            this.textBox_SearchDebitorName.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debitorsToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.safeAscsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // safeAscsToolStripMenuItem
            // 
            this.safeAscsToolStripMenuItem.Name = "safeAscsToolStripMenuItem";
            this.safeAscsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.safeAscsToolStripMenuItem.Text = "Safe as CSV";
            this.safeAscsToolStripMenuItem.Click += new System.EventHandler(this.safeAscsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debitorsToolStripMenuItem
            // 
            this.debitorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDebitorToolStripMenuItem});
            this.debitorsToolStripMenuItem.Name = "debitorsToolStripMenuItem";
            this.debitorsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.debitorsToolStripMenuItem.Text = "Debitor";
            // 
            // addNewDebitorToolStripMenuItem
            // 
            this.addNewDebitorToolStripMenuItem.Name = "addNewDebitorToolStripMenuItem";
            this.addNewDebitorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewDebitorToolStripMenuItem.Text = "Add new debitor";
            this.addNewDebitorToolStripMenuItem.Click += new System.EventHandler(this.addNewDebitorToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewCreditToolStripMenuItem});
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // openNewCreditToolStripMenuItem
            // 
            this.openNewCreditToolStripMenuItem.Name = "openNewCreditToolStripMenuItem";
            this.openNewCreditToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openNewCreditToolStripMenuItem.Text = "Open new credit";
            this.openNewCreditToolStripMenuItem.Click += new System.EventHandler(this.openNewCreditToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptPaymentToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // acceptPaymentToolStripMenuItem
            // 
            this.acceptPaymentToolStripMenuItem.Name = "acceptPaymentToolStripMenuItem";
            this.acceptPaymentToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.acceptPaymentToolStripMenuItem.Text = "Accept new payment";
            this.acceptPaymentToolStripMenuItem.Click += new System.EventHandler(this.acceptPaymentToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 658);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxPayments);
            this.Controls.Add(this.groupBoxCredits);
            this.Controls.Add(this.groupBoxDebitorDetails);
            this.Controls.Add(this.groupBoxDebitors);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта кредитования 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDebitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebitors)).EndInit();
            this.groupBoxDebitorDetails.ResumeLayout(false);
            this.groupBoxDebitorDetails.PerformLayout();
            this.groupBoxCredits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredits)).EndInit();
            this.groupBoxPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDebitors;
        private System.Windows.Forms.DataGridView dataGridViewDebitors;
        private System.Windows.Forms.GroupBox groupBoxDebitorDetails;
        private System.Windows.Forms.GroupBox groupBoxCredits;
        private System.Windows.Forms.DataGridView dataGridViewCredits;
        private System.Windows.Forms.GroupBox groupBoxPayments;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxDebitorPhoneNumber;
        private System.Windows.Forms.TextBox textBoxDebitorPostNumber;
        private System.Windows.Forms.TextBox textBoxDebitorName;
        private System.Windows.Forms.TextBox textBoxDebitorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safeAscsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDebitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acceptPaymentToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_DebitorPhoneNumber;
        private System.Windows.Forms.TextBox textBox_SearchDebitorPostNumber;
        private System.Windows.Forms.TextBox textBox_SearchDebitorName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_ClientSearch;
        private System.Windows.Forms.RadioButton radioButton_ServerSearch;
    }
}

