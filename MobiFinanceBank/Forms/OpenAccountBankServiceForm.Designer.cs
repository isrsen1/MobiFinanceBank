namespace MobiFinanceBank.Forms
{
    partial class OpenAccountBankServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ibanLbl = new System.Windows.Forms.Label();
            this.cardNumberLbl = new System.Windows.Forms.Label();
            this.paymentLbl = new System.Windows.Forms.Label();
            this.ibanTb = new System.Windows.Forms.TextBox();
            this.cardNumberTb = new System.Windows.Forms.TextBox();
            this.paymentNum = new System.Windows.Forms.NumericUpDown();
            this.createAccountBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ibanLbl
            // 
            this.ibanLbl.AutoSize = true;
            this.ibanLbl.Location = new System.Drawing.Point(134, 148);
            this.ibanLbl.Name = "ibanLbl";
            this.ibanLbl.Size = new System.Drawing.Size(39, 17);
            this.ibanLbl.TabIndex = 3;
            this.ibanLbl.Text = "IBAN";
            // 
            // cardNumberLbl
            // 
            this.cardNumberLbl.AutoSize = true;
            this.cardNumberLbl.Location = new System.Drawing.Point(134, 193);
            this.cardNumberLbl.Name = "cardNumberLbl";
            this.cardNumberLbl.Size = new System.Drawing.Size(79, 17);
            this.cardNumberLbl.TabIndex = 4;
            this.cardNumberLbl.Text = "Broj kartice";
            // 
            // paymentLbl
            // 
            this.paymentLbl.AutoSize = true;
            this.paymentLbl.Location = new System.Drawing.Point(134, 230);
            this.paymentLbl.Name = "paymentLbl";
            this.paymentLbl.Size = new System.Drawing.Size(49, 17);
            this.paymentLbl.TabIndex = 5;
            this.paymentLbl.Text = "Uplata";
            // 
            // ibanTb
            // 
            this.ibanTb.Location = new System.Drawing.Point(250, 145);
            this.ibanTb.Name = "ibanTb";
            this.ibanTb.Size = new System.Drawing.Size(230, 22);
            this.ibanTb.TabIndex = 8;
            // 
            // cardNumberTb
            // 
            this.cardNumberTb.Location = new System.Drawing.Point(250, 188);
            this.cardNumberTb.Name = "cardNumberTb";
            this.cardNumberTb.Size = new System.Drawing.Size(230, 22);
            this.cardNumberTb.TabIndex = 9;
            // 
            // paymentNum
            // 
            this.paymentNum.Location = new System.Drawing.Point(250, 228);
            this.paymentNum.Name = "paymentNum";
            this.paymentNum.Size = new System.Drawing.Size(175, 22);
            this.paymentNum.TabIndex = 11;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createAccountBtn.Location = new System.Drawing.Point(374, 267);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(106, 31);
            this.createAccountBtn.TabIndex = 12;
            this.createAccountBtn.Text = "Kreiraj račun";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // OpenAccountBankServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 638);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.paymentNum);
            this.Controls.Add(this.cardNumberTb);
            this.Controls.Add(this.ibanTb);
            this.Controls.Add(this.paymentLbl);
            this.Controls.Add(this.cardNumberLbl);
            this.Controls.Add(this.ibanLbl);
            this.Name = "OpenAccountBankServiceForm";
            this.Text = "OpenAccountBankServiceForm";
            this.Controls.SetChildIndex(this.ibanLbl, 0);
            this.Controls.SetChildIndex(this.cardNumberLbl, 0);
            this.Controls.SetChildIndex(this.paymentLbl, 0);
            this.Controls.SetChildIndex(this.ibanTb, 0);
            this.Controls.SetChildIndex(this.cardNumberTb, 0);
            this.Controls.SetChildIndex(this.paymentNum, 0);
            this.Controls.SetChildIndex(this.createAccountBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.paymentNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ibanLbl;
        private System.Windows.Forms.Label cardNumberLbl;
        private System.Windows.Forms.Label paymentLbl;
        private System.Windows.Forms.TextBox ibanTb;
        private System.Windows.Forms.TextBox cardNumberTb;
        private System.Windows.Forms.NumericUpDown paymentNum;
        private System.Windows.Forms.Button createAccountBtn;
    }
}