namespace BankManager
{
    partial class NewCredit
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
            this.dateTimePickerCreditOpenDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxDebitorName = new System.Windows.Forms.ListBox();
            this.listBoxDebitorID = new System.Windows.Forms.ListBox();
            this.button_SaveNewCredit = new System.Windows.Forms.Button();
            this.textBoxCreditBalance = new System.Windows.Forms.TextBox();
            this.textBoxCreditAmount = new System.Windows.Forms.TextBox();
            this.textBoxCreditID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CreditAmountMessage = new System.Windows.Forms.Label();
            this.groupBoxDebitorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDebitorDetails
            // 
            this.groupBoxDebitorDetails.Controls.Add(this.label_CreditAmountMessage);
            this.groupBoxDebitorDetails.Controls.Add(this.dateTimePickerCreditOpenDate);
            this.groupBoxDebitorDetails.Controls.Add(this.label5);
            this.groupBoxDebitorDetails.Controls.Add(this.listBoxDebitorName);
            this.groupBoxDebitorDetails.Controls.Add(this.listBoxDebitorID);
            this.groupBoxDebitorDetails.Controls.Add(this.button_SaveNewCredit);
            this.groupBoxDebitorDetails.Controls.Add(this.textBoxCreditBalance);
            this.groupBoxDebitorDetails.Controls.Add(this.textBoxCreditAmount);
            this.groupBoxDebitorDetails.Controls.Add(this.textBoxCreditID);
            this.groupBoxDebitorDetails.Controls.Add(this.label4);
            this.groupBoxDebitorDetails.Controls.Add(this.label3);
            this.groupBoxDebitorDetails.Controls.Add(this.label2);
            this.groupBoxDebitorDetails.Controls.Add(this.label1);
            this.groupBoxDebitorDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDebitorDetails.Name = "groupBoxDebitorDetails";
            this.groupBoxDebitorDetails.Size = new System.Drawing.Size(415, 259);
            this.groupBoxDebitorDetails.TabIndex = 3;
            this.groupBoxDebitorDetails.TabStop = false;
            this.groupBoxDebitorDetails.Text = "Credit";
            // 
            // dateTimePickerCreditOpenDate
            // 
            this.dateTimePickerCreditOpenDate.Location = new System.Drawing.Point(79, 197);
            this.dateTimePickerCreditOpenDate.Name = "dateTimePickerCreditOpenDate";
            this.dateTimePickerCreditOpenDate.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerCreditOpenDate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // listBoxDebitorName
            // 
            this.listBoxDebitorName.DisplayMember = "Name";
            this.listBoxDebitorName.FormattingEnabled = true;
            this.listBoxDebitorName.HorizontalScrollbar = true;
            this.listBoxDebitorName.Location = new System.Drawing.Point(79, 59);
            this.listBoxDebitorName.Name = "listBoxDebitorName";
            this.listBoxDebitorName.Size = new System.Drawing.Size(177, 95);
            this.listBoxDebitorName.TabIndex = 9;
            this.listBoxDebitorName.ValueMember = "ID";
            // 
            // listBoxDebitorID
            // 
            this.listBoxDebitorID.DisplayMember = "ID";
            this.listBoxDebitorID.FormattingEnabled = true;
            this.listBoxDebitorID.HorizontalScrollbar = true;
            this.listBoxDebitorID.Location = new System.Drawing.Point(262, 59);
            this.listBoxDebitorID.Name = "listBoxDebitorID";
            this.listBoxDebitorID.Size = new System.Drawing.Size(142, 95);
            this.listBoxDebitorID.TabIndex = 8;
            this.listBoxDebitorID.ValueMember = "ID";
            // 
            // button_SaveNewCredit
            // 
            this.button_SaveNewCredit.Location = new System.Drawing.Point(222, 197);
            this.button_SaveNewCredit.Name = "button_SaveNewCredit";
            this.button_SaveNewCredit.Size = new System.Drawing.Size(182, 53);
            this.button_SaveNewCredit.TabIndex = 3;
            this.button_SaveNewCredit.Text = "Open New Credit";
            this.button_SaveNewCredit.UseVisualStyleBackColor = true;
            this.button_SaveNewCredit.Click += new System.EventHandler(this.button_SaveNewCredit_Click);
            // 
            // textBoxCreditBalance
            // 
            this.textBoxCreditBalance.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCreditBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCreditBalance.Location = new System.Drawing.Point(79, 227);
            this.textBoxCreditBalance.Name = "textBoxCreditBalance";
            this.textBoxCreditBalance.ReadOnly = true;
            this.textBoxCreditBalance.Size = new System.Drawing.Size(137, 23);
            this.textBoxCreditBalance.TabIndex = 7;
            // 
            // textBoxCreditAmount
            // 
            this.textBoxCreditAmount.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCreditAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCreditAmount.Location = new System.Drawing.Point(79, 164);
            this.textBoxCreditAmount.MaxLength = 7;
            this.textBoxCreditAmount.Name = "textBoxCreditAmount";
            this.textBoxCreditAmount.Size = new System.Drawing.Size(137, 23);
            this.textBoxCreditAmount.TabIndex = 6;
            this.textBoxCreditAmount.TextChanged += new System.EventHandler(this.textBoxCreditAmount_TextChanged);
            this.textBoxCreditAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCreditAmount_KeyPress);
            this.textBoxCreditAmount.Leave += new System.EventHandler(this.textBoxCreditAmount_Leave);
            // 
            // textBoxCreditID
            // 
            this.textBoxCreditID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCreditID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCreditID.Location = new System.Drawing.Point(79, 18);
            this.textBoxCreditID.Name = "textBoxCreditID";
            this.textBoxCreditID.ReadOnly = true;
            this.textBoxCreditID.Size = new System.Drawing.Size(325, 23);
            this.textBoxCreditID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Credit Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credit Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Debitor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit ID";
            // 
            // label_CreditAmountMessage
            // 
            this.label_CreditAmountMessage.AutoSize = true;
            this.label_CreditAmountMessage.Location = new System.Drawing.Point(223, 173);
            this.label_CreditAmountMessage.Name = "label_CreditAmountMessage";
            this.label_CreditAmountMessage.Size = new System.Drawing.Size(0, 13);
            this.label_CreditAmountMessage.TabIndex = 12;
            // 
            // NewCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 279);
            this.Controls.Add(this.groupBoxDebitorDetails);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(452, 317);
            this.Name = "NewCredit";
            this.Text = "NewCredit";
            this.groupBoxDebitorDetails.ResumeLayout(false);
            this.groupBoxDebitorDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDebitorDetails;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreditOpenDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxDebitorName;
        private System.Windows.Forms.ListBox listBoxDebitorID;
        private System.Windows.Forms.Button button_SaveNewCredit;
        private System.Windows.Forms.TextBox textBoxCreditBalance;
        private System.Windows.Forms.TextBox textBoxCreditAmount;
        private System.Windows.Forms.TextBox textBoxCreditID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_CreditAmountMessage;
    }
}