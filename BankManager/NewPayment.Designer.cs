namespace BankManager
{
    partial class NewPayment
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
            this.groupBoxDebitorDetails = new System.Windows.Forms.GroupBox();
            this.button_PaymentClear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox_CreditBalance = new System.Windows.Forms.ListBox();
            this.listBox_CreditID = new System.Windows.Forms.ListBox();
            this.listBox_CreditAmount = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_PaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_DebitorName = new System.Windows.Forms.ListBox();
            this.listBox_DebitorID = new System.Windows.Forms.ListBox();
            this.button_SaveNewPayment = new System.Windows.Forms.Button();
            this.textBox_PaymentAmount = new System.Windows.Forms.TextBox();
            this.textBox_PaymentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_PaymentMessage = new System.Windows.Forms.Label();
            this.groupBoxDebitorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDebitorDetails
            // 
            this.groupBoxDebitorDetails.Controls.Add(this.label_PaymentMessage);
            this.groupBoxDebitorDetails.Controls.Add(this.button_PaymentClear);
            this.groupBoxDebitorDetails.Controls.Add(this.label11);
            this.groupBoxDebitorDetails.Controls.Add(this.label10);
            this.groupBoxDebitorDetails.Controls.Add(this.label9);
            this.groupBoxDebitorDetails.Controls.Add(this.label8);
            this.groupBoxDebitorDetails.Controls.Add(this.label7);
            this.groupBoxDebitorDetails.Controls.Add(this.listBox_CreditBalance);
            this.groupBoxDebitorDetails.Controls.Add(this.listBox_CreditID);
            this.groupBoxDebitorDetails.Controls.Add(this.listBox_CreditAmount);
            this.groupBoxDebitorDetails.Controls.Add(this.label6);
            this.groupBoxDebitorDetails.Controls.Add(this.dateTimePicker_PaymentDate);
            this.groupBoxDebitorDetails.Controls.Add(this.label5);
            this.groupBoxDebitorDetails.Controls.Add(this.listBox_DebitorName);
            this.groupBoxDebitorDetails.Controls.Add(this.listBox_DebitorID);
            this.groupBoxDebitorDetails.Controls.Add(this.button_SaveNewPayment);
            this.groupBoxDebitorDetails.Controls.Add(this.textBox_PaymentAmount);
            this.groupBoxDebitorDetails.Controls.Add(this.textBox_PaymentID);
            this.groupBoxDebitorDetails.Controls.Add(this.label3);
            this.groupBoxDebitorDetails.Controls.Add(this.label2);
            this.groupBoxDebitorDetails.Controls.Add(this.label1);
            this.groupBoxDebitorDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDebitorDetails.Name = "groupBoxDebitorDetails";
            this.groupBoxDebitorDetails.Size = new System.Drawing.Size(455, 445);
            this.groupBoxDebitorDetails.TabIndex = 4;
            this.groupBoxDebitorDetails.TabStop = false;
            this.groupBoxDebitorDetails.Text = "Payment";
            // 
            // button_PaymentClear
            // 
            this.button_PaymentClear.Location = new System.Drawing.Point(226, 315);
            this.button_PaymentClear.Name = "button_PaymentClear";
            this.button_PaymentClear.Size = new System.Drawing.Size(47, 23);
            this.button_PaymentClear.TabIndex = 23;
            this.button_PaymentClear.Text = "Clear";
            this.button_PaymentClear.UseVisualStyleBackColor = true;
            this.button_PaymentClear.Click += new System.EventHandler(this.button_PaymentClear_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(358, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID";
            // 
            // listBox_CreditBalance
            // 
            this.listBox_CreditBalance.DisplayMember = "Balance";
            this.listBox_CreditBalance.FormattingEnabled = true;
            this.listBox_CreditBalance.HorizontalScrollbar = true;
            this.listBox_CreditBalance.Location = new System.Drawing.Point(361, 206);
            this.listBox_CreditBalance.Name = "listBox_CreditBalance";
            this.listBox_CreditBalance.Size = new System.Drawing.Size(87, 95);
            this.listBox_CreditBalance.TabIndex = 16;
            this.listBox_CreditBalance.ValueMember = "ID";
            // 
            // listBox_CreditID
            // 
            this.listBox_CreditID.DisplayMember = "ID";
            this.listBox_CreditID.FormattingEnabled = true;
            this.listBox_CreditID.HorizontalScrollbar = true;
            this.listBox_CreditID.Location = new System.Drawing.Point(82, 206);
            this.listBox_CreditID.Name = "listBox_CreditID";
            this.listBox_CreditID.Size = new System.Drawing.Size(177, 95);
            this.listBox_CreditID.TabIndex = 15;
            this.listBox_CreditID.ValueMember = "ID";
            // 
            // listBox_CreditAmount
            // 
            this.listBox_CreditAmount.DisplayMember = "Amount";
            this.listBox_CreditAmount.FormattingEnabled = true;
            this.listBox_CreditAmount.HorizontalScrollbar = true;
            this.listBox_CreditAmount.Location = new System.Drawing.Point(265, 206);
            this.listBox_CreditAmount.Name = "listBox_CreditAmount";
            this.listBox_CreditAmount.Size = new System.Drawing.Size(90, 95);
            this.listBox_CreditAmount.TabIndex = 14;
            this.listBox_CreditAmount.ValueMember = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Credit";
            // 
            // dateTimePicker_PaymentDate
            // 
            this.dateTimePicker_PaymentDate.Location = new System.Drawing.Point(82, 355);
            this.dateTimePicker_PaymentDate.Name = "dateTimePicker_PaymentDate";
            this.dateTimePicker_PaymentDate.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker_PaymentDate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // listBox_DebitorName
            // 
            this.listBox_DebitorName.DisplayMember = "Name";
            this.listBox_DebitorName.FormattingEnabled = true;
            this.listBox_DebitorName.HorizontalScrollbar = true;
            this.listBox_DebitorName.Location = new System.Drawing.Point(230, 73);
            this.listBox_DebitorName.Name = "listBox_DebitorName";
            this.listBox_DebitorName.Size = new System.Drawing.Size(219, 95);
            this.listBox_DebitorName.TabIndex = 9;
            this.listBox_DebitorName.ValueMember = "ID";
            this.listBox_DebitorName.SelectedIndexChanged += new System.EventHandler(this.listBox_DebitorName_SelectedIndexChanged);
            // 
            // listBox_DebitorID
            // 
            this.listBox_DebitorID.DisplayMember = "ID";
            this.listBox_DebitorID.FormattingEnabled = true;
            this.listBox_DebitorID.HorizontalScrollbar = true;
            this.listBox_DebitorID.Location = new System.Drawing.Point(82, 73);
            this.listBox_DebitorID.Name = "listBox_DebitorID";
            this.listBox_DebitorID.Size = new System.Drawing.Size(142, 95);
            this.listBox_DebitorID.TabIndex = 8;
            this.listBox_DebitorID.ValueMember = "ID";
            this.listBox_DebitorID.SelectedIndexChanged += new System.EventHandler(this.listBox_DebitorName_SelectedIndexChanged);
            // 
            // button_SaveNewPayment
            // 
            this.button_SaveNewPayment.Location = new System.Drawing.Point(27, 399);
            this.button_SaveNewPayment.Name = "button_SaveNewPayment";
            this.button_SaveNewPayment.Size = new System.Drawing.Size(399, 35);
            this.button_SaveNewPayment.TabIndex = 3;
            this.button_SaveNewPayment.Text = " Save new payment";
            this.button_SaveNewPayment.UseVisualStyleBackColor = true;
            this.button_SaveNewPayment.Click += new System.EventHandler(this.button_SaveNewPayment_Click);
            // 
            // textBox_PaymentAmount
            // 
            this.textBox_PaymentAmount.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_PaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PaymentAmount.Location = new System.Drawing.Point(82, 316);
            this.textBox_PaymentAmount.MaxLength = 12;
            this.textBox_PaymentAmount.Name = "textBox_PaymentAmount";
            this.textBox_PaymentAmount.Size = new System.Drawing.Size(137, 23);
            this.textBox_PaymentAmount.TabIndex = 6;
            this.textBox_PaymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PaymentAmount_KeyPress);
            this.textBox_PaymentAmount.Leave += new System.EventHandler(this.textBox_PaymentAmount_Leave);
            // 
            // textBox_PaymentID
            // 
            this.textBox_PaymentID.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_PaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PaymentID.Location = new System.Drawing.Point(79, 18);
            this.textBox_PaymentID.Name = "textBox_PaymentID";
            this.textBox_PaymentID.ReadOnly = true;
            this.textBox_PaymentID.Size = new System.Drawing.Size(367, 23);
            this.textBox_PaymentID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Debitor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PaymentID";
            // 
            // label_PaymentMessage
            // 
            this.label_PaymentMessage.AutoSize = true;
            this.label_PaymentMessage.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_PaymentMessage.Location = new System.Drawing.Point(292, 321);
            this.label_PaymentMessage.Name = "label_PaymentMessage";
            this.label_PaymentMessage.Size = new System.Drawing.Size(130, 13);
            this.label_PaymentMessage.TabIndex = 24;
            this.label_PaymentMessage.Text = "Введите сумму платежа";
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 469);
            this.Controls.Add(this.groupBoxDebitorDetails);
            this.MaximizeBox = false;
            this.Name = "NewPayment";
            this.Text = "NewPayment";
            this.groupBoxDebitorDetails.ResumeLayout(false);
            this.groupBoxDebitorDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDebitorDetails;
        private System.Windows.Forms.ListBox listBox_CreditBalance;
        private System.Windows.Forms.ListBox listBox_CreditID;
        private System.Windows.Forms.ListBox listBox_CreditAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PaymentDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_DebitorName;
        private System.Windows.Forms.ListBox listBox_DebitorID;
        private System.Windows.Forms.Button button_SaveNewPayment;
        private System.Windows.Forms.TextBox textBox_PaymentAmount;
        private System.Windows.Forms.TextBox textBox_PaymentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_PaymentClear;
        private System.Windows.Forms.Label label_PaymentMessage;
    }
}