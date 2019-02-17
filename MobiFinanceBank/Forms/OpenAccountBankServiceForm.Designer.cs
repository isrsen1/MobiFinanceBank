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
            this.clientDetails = new System.Windows.Forms.Label();
            this.firstNameTitleLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameTitleLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.incomeTitleLbl = new System.Windows.Forms.Label();
            this.oibLbl = new System.Windows.Forms.Label();
            this.oibTitleLbl = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.addressTitleLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.incomeBottomLineLbl = new System.Windows.Forms.Label();
            this.incomeBottomLineTitleLbl = new System.Windows.Forms.Label();
            this.negativeBalanceLbl = new System.Windows.Forms.Label();
            this.currencyTitleLbl = new System.Windows.Forms.Label();
            this.currencyLbl = new System.Windows.Forms.Label();
            this.balanceLimitTitleLbl = new System.Windows.Forms.Label();
            this.foreignCurrencyTitleLbl = new System.Windows.Forms.Label();
            this.accountNameLbl = new System.Windows.Forms.Label();
            this.accountNameTitleLbl = new System.Windows.Forms.Label();
            this.foreignCurrencyLbl = new System.Windows.Forms.CheckBox();
            this.negativeBalanceMonthlyFeeTitleLbl = new System.Windows.Forms.Label();
            this.negativeBalanceMonthlyFeeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paymentNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ibanLbl
            // 
            this.ibanLbl.AutoSize = true;
            this.ibanLbl.Location = new System.Drawing.Point(106, 154);
            this.ibanLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ibanLbl.Name = "ibanLbl";
            this.ibanLbl.Size = new System.Drawing.Size(32, 13);
            this.ibanLbl.TabIndex = 3;
            this.ibanLbl.Text = "IBAN";
            // 
            // cardNumberLbl
            // 
            this.cardNumberLbl.AutoSize = true;
            this.cardNumberLbl.Location = new System.Drawing.Point(106, 191);
            this.cardNumberLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardNumberLbl.Name = "cardNumberLbl";
            this.cardNumberLbl.Size = new System.Drawing.Size(60, 13);
            this.cardNumberLbl.TabIndex = 4;
            this.cardNumberLbl.Text = "Broj kartice";
            // 
            // paymentLbl
            // 
            this.paymentLbl.AutoSize = true;
            this.paymentLbl.Location = new System.Drawing.Point(106, 221);
            this.paymentLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paymentLbl.Name = "paymentLbl";
            this.paymentLbl.Size = new System.Drawing.Size(38, 13);
            this.paymentLbl.TabIndex = 5;
            this.paymentLbl.Text = "Uplata";
            // 
            // ibanTb
            // 
            this.ibanTb.Location = new System.Drawing.Point(194, 152);
            this.ibanTb.Margin = new System.Windows.Forms.Padding(2);
            this.ibanTb.Name = "ibanTb";
            this.ibanTb.Size = new System.Drawing.Size(174, 20);
            this.ibanTb.TabIndex = 8;
            this.ibanTb.Enter += new System.EventHandler(this.ibanTb_Enter);
            this.ibanTb.Leave += new System.EventHandler(this.ibanTb_Leave);
            // 
            // cardNumberTb
            // 
            this.cardNumberTb.Location = new System.Drawing.Point(194, 187);
            this.cardNumberTb.Margin = new System.Windows.Forms.Padding(2);
            this.cardNumberTb.Name = "cardNumberTb";
            this.cardNumberTb.Size = new System.Drawing.Size(174, 20);
            this.cardNumberTb.TabIndex = 9;
            this.cardNumberTb.Enter += new System.EventHandler(this.cardNumberTb_Enter);
            this.cardNumberTb.Leave += new System.EventHandler(this.cardNumberTb_Leave);
            // 
            // paymentNum
            // 
            this.paymentNum.Location = new System.Drawing.Point(194, 219);
            this.paymentNum.Margin = new System.Windows.Forms.Padding(2);
            this.paymentNum.Name = "paymentNum";
            this.paymentNum.Size = new System.Drawing.Size(131, 20);
            this.paymentNum.TabIndex = 11;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createAccountBtn.Location = new System.Drawing.Point(286, 251);
            this.createAccountBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(80, 25);
            this.createAccountBtn.TabIndex = 12;
            this.createAccountBtn.Text = "Kreiraj račun";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // clientDetails
            // 
            this.clientDetails.AutoSize = true;
            this.clientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDetails.Location = new System.Drawing.Point(500, 118);
            this.clientDetails.Name = "clientDetails";
            this.clientDetails.Size = new System.Drawing.Size(110, 20);
            this.clientDetails.TabIndex = 13;
            this.clientDetails.Text = "Detalji klijenta:";
            // 
            // firstNameTitleLbl
            // 
            this.firstNameTitleLbl.AutoSize = true;
            this.firstNameTitleLbl.Location = new System.Drawing.Point(517, 155);
            this.firstNameTitleLbl.Name = "firstNameTitleLbl";
            this.firstNameTitleLbl.Size = new System.Drawing.Size(27, 13);
            this.firstNameTitleLbl.TabIndex = 14;
            this.firstNameTitleLbl.Text = "Ime:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(622, 159);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(35, 13);
            this.firstNameLbl.TabIndex = 15;
            this.firstNameLbl.Text = "label3";
            // 
            // lastNameTitleLbl
            // 
            this.lastNameTitleLbl.AutoSize = true;
            this.lastNameTitleLbl.Location = new System.Drawing.Point(517, 187);
            this.lastNameTitleLbl.Name = "lastNameTitleLbl";
            this.lastNameTitleLbl.Size = new System.Drawing.Size(47, 13);
            this.lastNameTitleLbl.TabIndex = 16;
            this.lastNameTitleLbl.Text = "Prezime:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(622, 191);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(35, 13);
            this.lastNameLbl.TabIndex = 17;
            this.lastNameLbl.Text = "label5";
            // 
            // incomeTitleLbl
            // 
            this.incomeTitleLbl.AutoSize = true;
            this.incomeTitleLbl.Location = new System.Drawing.Point(517, 256);
            this.incomeTitleLbl.Name = "incomeTitleLbl";
            this.incomeTitleLbl.Size = new System.Drawing.Size(84, 13);
            this.incomeTitleLbl.TabIndex = 18;
            this.incomeTitleLbl.Text = "Mjesečni prihod:";
            // 
            // oibLbl
            // 
            this.oibLbl.AutoSize = true;
            this.oibLbl.Location = new System.Drawing.Point(622, 221);
            this.oibLbl.Name = "oibLbl";
            this.oibLbl.Size = new System.Drawing.Size(35, 13);
            this.oibLbl.TabIndex = 19;
            this.oibLbl.Text = "label7";
            // 
            // oibTitleLbl
            // 
            this.oibTitleLbl.AutoSize = true;
            this.oibTitleLbl.Location = new System.Drawing.Point(517, 221);
            this.oibTitleLbl.Name = "oibTitleLbl";
            this.oibTitleLbl.Size = new System.Drawing.Size(28, 13);
            this.oibTitleLbl.TabIndex = 20;
            this.oibTitleLbl.Text = "OIB:";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(622, 257);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(35, 13);
            this.incomeLbl.TabIndex = 21;
            this.incomeLbl.Text = "label9";
            // 
            // addressTitleLbl
            // 
            this.addressTitleLbl.AutoSize = true;
            this.addressTitleLbl.Location = new System.Drawing.Point(517, 291);
            this.addressTitleLbl.Name = "addressTitleLbl";
            this.addressTitleLbl.Size = new System.Drawing.Size(43, 13);
            this.addressTitleLbl.TabIndex = 22;
            this.addressTitleLbl.Text = "Adresa:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(616, 291);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(41, 13);
            this.addressLbl.TabIndex = 23;
            this.addressLbl.Text = "label11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(735, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tip računa:";
            // 
            // incomeBottomLineLbl
            // 
            this.incomeBottomLineLbl.AutoSize = true;
            this.incomeBottomLineLbl.Location = new System.Drawing.Point(849, 290);
            this.incomeBottomLineLbl.Name = "incomeBottomLineLbl";
            this.incomeBottomLineLbl.Size = new System.Drawing.Size(41, 13);
            this.incomeBottomLineLbl.TabIndex = 34;
            this.incomeBottomLineLbl.Text = "label11";
            // 
            // incomeBottomLineTitleLbl
            // 
            this.incomeBottomLineTitleLbl.AutoSize = true;
            this.incomeBottomLineTitleLbl.Location = new System.Drawing.Point(748, 290);
            this.incomeBottomLineTitleLbl.Name = "incomeBottomLineTitleLbl";
            this.incomeBottomLineTitleLbl.Size = new System.Drawing.Size(87, 13);
            this.incomeBottomLineTitleLbl.TabIndex = 33;
            this.incomeBottomLineTitleLbl.Text = "Minimalni prihodi:";
            // 
            // negativeBalanceLbl
            // 
            this.negativeBalanceLbl.AutoSize = true;
            this.negativeBalanceLbl.Location = new System.Drawing.Point(849, 256);
            this.negativeBalanceLbl.Name = "negativeBalanceLbl";
            this.negativeBalanceLbl.Size = new System.Drawing.Size(35, 13);
            this.negativeBalanceLbl.TabIndex = 32;
            this.negativeBalanceLbl.Text = "label9";
            // 
            // currencyTitleLbl
            // 
            this.currencyTitleLbl.AutoSize = true;
            this.currencyTitleLbl.Location = new System.Drawing.Point(751, 220);
            this.currencyTitleLbl.Name = "currencyTitleLbl";
            this.currencyTitleLbl.Size = new System.Drawing.Size(40, 13);
            this.currencyTitleLbl.TabIndex = 31;
            this.currencyTitleLbl.Text = "Valuta:";
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.Location = new System.Drawing.Point(849, 220);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(35, 13);
            this.currencyLbl.TabIndex = 30;
            this.currencyLbl.Text = "label7";
            // 
            // balanceLimitTitleLbl
            // 
            this.balanceLimitTitleLbl.AutoSize = true;
            this.balanceLimitTitleLbl.Location = new System.Drawing.Point(748, 256);
            this.balanceLimitTitleLbl.Name = "balanceLimitTitleLbl";
            this.balanceLimitTitleLbl.Size = new System.Drawing.Size(31, 13);
            this.balanceLimitTitleLbl.TabIndex = 29;
            this.balanceLimitTitleLbl.Text = "Limit:";
            // 
            // foreignCurrencyTitleLbl
            // 
            this.foreignCurrencyTitleLbl.AutoSize = true;
            this.foreignCurrencyTitleLbl.Location = new System.Drawing.Point(751, 186);
            this.foreignCurrencyTitleLbl.Name = "foreignCurrencyTitleLbl";
            this.foreignCurrencyTitleLbl.Size = new System.Drawing.Size(45, 13);
            this.foreignCurrencyTitleLbl.TabIndex = 27;
            this.foreignCurrencyTitleLbl.Text = "Devizni:";
            // 
            // accountNameLbl
            // 
            this.accountNameLbl.AutoSize = true;
            this.accountNameLbl.Location = new System.Drawing.Point(849, 158);
            this.accountNameLbl.Name = "accountNameLbl";
            this.accountNameLbl.Size = new System.Drawing.Size(35, 13);
            this.accountNameLbl.TabIndex = 26;
            this.accountNameLbl.Text = "label3";
            // 
            // accountNameTitleLbl
            // 
            this.accountNameTitleLbl.AutoSize = true;
            this.accountNameTitleLbl.Location = new System.Drawing.Point(751, 154);
            this.accountNameTitleLbl.Name = "accountNameTitleLbl";
            this.accountNameTitleLbl.Size = new System.Drawing.Size(37, 13);
            this.accountNameTitleLbl.TabIndex = 25;
            this.accountNameTitleLbl.Text = "Naziv:";
            // 
            // foreignCurrencyLbl
            // 
            this.foreignCurrencyLbl.AutoSize = true;
            this.foreignCurrencyLbl.Location = new System.Drawing.Point(852, 189);
            this.foreignCurrencyLbl.Name = "foreignCurrencyLbl";
            this.foreignCurrencyLbl.Size = new System.Drawing.Size(15, 14);
            this.foreignCurrencyLbl.TabIndex = 35;
            this.foreignCurrencyLbl.UseVisualStyleBackColor = true;
            // 
            // negativeBalanceMonthlyFeeTitleLbl
            // 
            this.negativeBalanceMonthlyFeeTitleLbl.AutoSize = true;
            this.negativeBalanceMonthlyFeeTitleLbl.Location = new System.Drawing.Point(748, 324);
            this.negativeBalanceMonthlyFeeTitleLbl.Name = "negativeBalanceMonthlyFeeTitleLbl";
            this.negativeBalanceMonthlyFeeTitleLbl.Size = new System.Drawing.Size(91, 13);
            this.negativeBalanceMonthlyFeeTitleLbl.TabIndex = 36;
            this.negativeBalanceMonthlyFeeTitleLbl.Text = "Kamata na minus:";
            // 
            // negativeBalanceMonthlyFeeLbl
            // 
            this.negativeBalanceMonthlyFeeLbl.AutoSize = true;
            this.negativeBalanceMonthlyFeeLbl.Location = new System.Drawing.Point(849, 324);
            this.negativeBalanceMonthlyFeeLbl.Name = "negativeBalanceMonthlyFeeLbl";
            this.negativeBalanceMonthlyFeeLbl.Size = new System.Drawing.Size(42, 13);
            this.negativeBalanceMonthlyFeeLbl.TabIndex = 37;
            this.negativeBalanceMonthlyFeeLbl.Text = "e.g. 3%";
            // 
            // OpenAccountBankServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 518);
            this.Controls.Add(this.negativeBalanceMonthlyFeeLbl);
            this.Controls.Add(this.negativeBalanceMonthlyFeeTitleLbl);
            this.Controls.Add(this.foreignCurrencyLbl);
            this.Controls.Add(this.incomeBottomLineLbl);
            this.Controls.Add(this.incomeBottomLineTitleLbl);
            this.Controls.Add(this.negativeBalanceLbl);
            this.Controls.Add(this.currencyTitleLbl);
            this.Controls.Add(this.currencyLbl);
            this.Controls.Add(this.balanceLimitTitleLbl);
            this.Controls.Add(this.foreignCurrencyTitleLbl);
            this.Controls.Add(this.accountNameLbl);
            this.Controls.Add(this.accountNameTitleLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.addressTitleLbl);
            this.Controls.Add(this.incomeLbl);
            this.Controls.Add(this.oibTitleLbl);
            this.Controls.Add(this.oibLbl);
            this.Controls.Add(this.incomeTitleLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.lastNameTitleLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.firstNameTitleLbl);
            this.Controls.Add(this.clientDetails);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.paymentNum);
            this.Controls.Add(this.cardNumberTb);
            this.Controls.Add(this.ibanTb);
            this.Controls.Add(this.paymentLbl);
            this.Controls.Add(this.cardNumberLbl);
            this.Controls.Add(this.ibanLbl);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "OpenAccountBankServiceForm";
            this.Text = "OpenAccountBankServiceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenAccountBankServiceForm_FormClosing);
            this.Load += new System.EventHandler(this.OpenAccountBankServiceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpenAccountBankServiceForm_KeyDown);
            this.Controls.SetChildIndex(this.ibanLbl, 0);
            this.Controls.SetChildIndex(this.cardNumberLbl, 0);
            this.Controls.SetChildIndex(this.paymentLbl, 0);
            this.Controls.SetChildIndex(this.ibanTb, 0);
            this.Controls.SetChildIndex(this.cardNumberTb, 0);
            this.Controls.SetChildIndex(this.paymentNum, 0);
            this.Controls.SetChildIndex(this.createAccountBtn, 0);
            this.Controls.SetChildIndex(this.clientDetails, 0);
            this.Controls.SetChildIndex(this.firstNameTitleLbl, 0);
            this.Controls.SetChildIndex(this.firstNameLbl, 0);
            this.Controls.SetChildIndex(this.lastNameTitleLbl, 0);
            this.Controls.SetChildIndex(this.lastNameLbl, 0);
            this.Controls.SetChildIndex(this.incomeTitleLbl, 0);
            this.Controls.SetChildIndex(this.oibLbl, 0);
            this.Controls.SetChildIndex(this.oibTitleLbl, 0);
            this.Controls.SetChildIndex(this.incomeLbl, 0);
            this.Controls.SetChildIndex(this.addressTitleLbl, 0);
            this.Controls.SetChildIndex(this.addressLbl, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.accountNameTitleLbl, 0);
            this.Controls.SetChildIndex(this.accountNameLbl, 0);
            this.Controls.SetChildIndex(this.foreignCurrencyTitleLbl, 0);
            this.Controls.SetChildIndex(this.balanceLimitTitleLbl, 0);
            this.Controls.SetChildIndex(this.currencyLbl, 0);
            this.Controls.SetChildIndex(this.currencyTitleLbl, 0);
            this.Controls.SetChildIndex(this.negativeBalanceLbl, 0);
            this.Controls.SetChildIndex(this.incomeBottomLineTitleLbl, 0);
            this.Controls.SetChildIndex(this.incomeBottomLineLbl, 0);
            this.Controls.SetChildIndex(this.foreignCurrencyLbl, 0);
            this.Controls.SetChildIndex(this.negativeBalanceMonthlyFeeTitleLbl, 0);
            this.Controls.SetChildIndex(this.negativeBalanceMonthlyFeeLbl, 0);
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
        private System.Windows.Forms.Label clientDetails;
        private System.Windows.Forms.Label firstNameTitleLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameTitleLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label incomeTitleLbl;
        private System.Windows.Forms.Label oibLbl;
        private System.Windows.Forms.Label oibTitleLbl;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Label addressTitleLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label incomeBottomLineLbl;
        private System.Windows.Forms.Label incomeBottomLineTitleLbl;
        private System.Windows.Forms.Label negativeBalanceLbl;
        private System.Windows.Forms.Label currencyTitleLbl;
        private System.Windows.Forms.Label currencyLbl;
        private System.Windows.Forms.Label balanceLimitTitleLbl;
        private System.Windows.Forms.Label foreignCurrencyTitleLbl;
        private System.Windows.Forms.Label accountNameLbl;
        private System.Windows.Forms.Label accountNameTitleLbl;
        private System.Windows.Forms.CheckBox foreignCurrencyLbl;
        private System.Windows.Forms.Label negativeBalanceMonthlyFeeTitleLbl;
        private System.Windows.Forms.Label negativeBalanceMonthlyFeeLbl;
    }
}