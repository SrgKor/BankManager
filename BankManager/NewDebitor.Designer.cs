namespace BankManager
{
    partial class NewDebitor
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
            this.textBoxDebitorPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxDebitorPostNumber = new System.Windows.Forms.TextBox();
            this.textBoxDebitorName = new System.Windows.Forms.TextBox();
            this.textBoxDebitorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SaveNewDebitor = new System.Windows.Forms.Button();
            this.groupBoxDebitorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDebitorDetails
            // 
            this.groupBoxDebitorDetails.Controls.Add(this.button_SaveNewDebitor);
            this.groupBoxDebitorDetails.Controls.Add(this.textBoxDebitorPhoneNumber);
            this.groupBoxDebitorDetails.Controls.Add(this.textBoxDebitorPostNumber);
            this.groupBoxDebitorDetails.Controls.Add(this.textBoxDebitorName);
            this.groupBoxDebitorDetails.Controls.Add(this.textBoxDebitorID);
            this.groupBoxDebitorDetails.Controls.Add(this.label4);
            this.groupBoxDebitorDetails.Controls.Add(this.label3);
            this.groupBoxDebitorDetails.Controls.Add(this.label2);
            this.groupBoxDebitorDetails.Controls.Add(this.label1);
            this.groupBoxDebitorDetails.Location = new System.Drawing.Point(10, 7);
            this.groupBoxDebitorDetails.Name = "groupBoxDebitorDetails";
            this.groupBoxDebitorDetails.Size = new System.Drawing.Size(410, 168);
            this.groupBoxDebitorDetails.TabIndex = 2;
            this.groupBoxDebitorDetails.TabStop = false;
            this.groupBoxDebitorDetails.Text = "Adding a record";
            // 
            // textBoxDebitorPhoneNumber
            // 
            this.textBoxDebitorPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDebitorPhoneNumber.Location = new System.Drawing.Point(130, 130);
            this.textBoxDebitorPhoneNumber.Name = "textBoxDebitorPhoneNumber";
            this.textBoxDebitorPhoneNumber.Size = new System.Drawing.Size(106, 23);
            this.textBoxDebitorPhoneNumber.TabIndex = 7;
            // 
            // textBoxDebitorPostNumber
            // 
            this.textBoxDebitorPostNumber.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorPostNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDebitorPostNumber.Location = new System.Drawing.Point(130, 101);
            this.textBoxDebitorPostNumber.Name = "textBoxDebitorPostNumber";
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
            this.textBoxDebitorName.Size = new System.Drawing.Size(266, 23);
            this.textBoxDebitorName.TabIndex = 5;
            // 
            // textBoxDebitorID
            // 
            this.textBoxDebitorID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDebitorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDebitorID.Location = new System.Drawing.Point(130, 43);
            this.textBoxDebitorID.Name = "textBoxDebitorID";
            this.textBoxDebitorID.ReadOnly = true;
            this.textBoxDebitorID.Size = new System.Drawing.Size(266, 23);
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
            // button_SaveNewDebitor
            // 
            this.button_SaveNewDebitor.Location = new System.Drawing.Point(242, 106);
            this.button_SaveNewDebitor.Name = "button_SaveNewDebitor";
            this.button_SaveNewDebitor.Size = new System.Drawing.Size(154, 56);
            this.button_SaveNewDebitor.TabIndex = 3;
            this.button_SaveNewDebitor.Text = "Save new debitor";
            this.button_SaveNewDebitor.UseVisualStyleBackColor = true;
            this.button_SaveNewDebitor.Click += new System.EventHandler(this.button_SaveNewDebitor_Click);
            // 
            // NewDebitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 187);
            this.Controls.Add(this.groupBoxDebitorDetails);
            this.MaximizeBox = false;
            this.Name = "NewDebitor";
            this.Text = "NewDebitor";
            this.groupBoxDebitorDetails.ResumeLayout(false);
            this.groupBoxDebitorDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDebitorDetails;
        private System.Windows.Forms.TextBox textBoxDebitorPhoneNumber;
        private System.Windows.Forms.TextBox textBoxDebitorPostNumber;
        private System.Windows.Forms.TextBox textBoxDebitorName;
        private System.Windows.Forms.TextBox textBoxDebitorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SaveNewDebitor;
    }
}