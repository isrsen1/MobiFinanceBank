namespace MobiFinanceBank.Forms
{
    partial class OpenSavingAccountBankServiceForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.capitalLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.standingOrderLbl = new System.Windows.Forms.Label();
            this.startDateDtp = new System.Windows.Forms.DateTimePicker();
            this.standingOrderChb = new System.Windows.Forms.CheckBox();
            this.capitalNum = new System.Windows.Forms.NumericUpDown();
            this.accountsDgv = new System.Windows.Forms.DataGridView();
            this.openSavingAccountBtn = new System.Windows.Forms.Button();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressTitleLbl = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.oibTitleLbl = new System.Windows.Forms.Label();
            this.oibLbl = new System.Windows.Forms.Label();
            this.incomeTitleLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.lastNameTitleLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.firstNameTitleLbl = new System.Windows.Forms.Label();
            this.clientDetails = new System.Windows.Forms.Label();
            this.foreignCurrencyLbl = new System.Windows.Forms.CheckBox();
            this.incomeBottomLineTitleLbl = new System.Windows.Forms.Label();
            this.interestRateLbl = new System.Windows.Forms.Label();
            this.currencyTitleLbl = new System.Windows.Forms.Label();
            this.currencyLbl = new System.Windows.Forms.Label();
            this.interestRateTitleLbl = new System.Windows.Forms.Label();
            this.foreignCurrencyTitleLbl = new System.Windows.Forms.Label();
            this.accountNameLbl = new System.Windows.Forms.Label();
            this.accountNameTitleLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingAccountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fixedTermLbl = new System.Windows.Forms.CheckBox();
            this.fixedTermPeriodTitleLbl = new System.Windows.Forms.Label();
            this.fixedTermPeriodLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capitalNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // capitalLbl
            // 
            this.capitalLbl.AutoSize = true;
            this.capitalLbl.Location = new System.Drawing.Point(11, 125);
            this.capitalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.capitalLbl.Name = "capitalLbl";
            this.capitalLbl.Size = new System.Drawing.Size(49, 13);
            this.capitalLbl.TabIndex = 3;
            this.capitalLbl.Text = "Glavnica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum početka";
            // 
            // standingOrderLbl
            // 
            this.standingOrderLbl.AutoSize = true;
            this.standingOrderLbl.Location = new System.Drawing.Point(11, 205);
            this.standingOrderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.standingOrderLbl.Name = "standingOrderLbl";
            this.standingOrderLbl.Size = new System.Drawing.Size(62, 13);
            this.standingOrderLbl.TabIndex = 5;
            this.standingOrderLbl.Text = "Trajni nalog";
            // 
            // startDateDtp
            // 
            this.startDateDtp.Location = new System.Drawing.Point(123, 166);
            this.startDateDtp.Margin = new System.Windows.Forms.Padding(2);
            this.startDateDtp.Name = "startDateDtp";
            this.startDateDtp.Size = new System.Drawing.Size(151, 20);
            this.startDateDtp.TabIndex = 13;
            // 
            // standingOrderChb
            // 
            this.standingOrderChb.AutoSize = true;
            this.standingOrderChb.Location = new System.Drawing.Point(123, 205);
            this.standingOrderChb.Margin = new System.Windows.Forms.Padding(2);
            this.standingOrderChb.Name = "standingOrderChb";
            this.standingOrderChb.Size = new System.Drawing.Size(15, 14);
            this.standingOrderChb.TabIndex = 14;
            this.standingOrderChb.UseVisualStyleBackColor = true;
            this.standingOrderChb.CheckedChanged += new System.EventHandler(this.standingOrderChb_CheckedChanged);
            // 
            // capitalNum
            // 
            this.capitalNum.Location = new System.Drawing.Point(123, 125);
            this.capitalNum.Margin = new System.Windows.Forms.Padding(2);
            this.capitalNum.Name = "capitalNum";
            this.capitalNum.Size = new System.Drawing.Size(90, 20);
            this.capitalNum.TabIndex = 15;
            // 
            // accountsDgv
            // 
            this.accountsDgv.AutoGenerateColumns = false;
            this.accountsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iBANDataGridViewTextBoxColumn,
            this.cardNumberDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.blockedDataGridViewCheckBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.accountTypeIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.loansDataGridViewTextBoxColumn,
            this.savingAccountsDataGridViewTextBoxColumn});
            this.accountsDgv.DataSource = this.accountBindingSource;
            this.accountsDgv.Location = new System.Drawing.Point(614, 109);
            this.accountsDgv.Margin = new System.Windows.Forms.Padding(2);
            this.accountsDgv.Name = "accountsDgv";
            this.accountsDgv.RowTemplate.Height = 24;
            this.accountsDgv.Size = new System.Drawing.Size(436, 225);
            this.accountsDgv.TabIndex = 16;
            // 
            // openSavingAccountBtn
            // 
            this.openSavingAccountBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openSavingAccountBtn.Location = new System.Drawing.Point(194, 282);
            this.openSavingAccountBtn.Margin = new System.Windows.Forms.Padding(2);
            this.openSavingAccountBtn.Name = "openSavingAccountBtn";
            this.openSavingAccountBtn.Size = new System.Drawing.Size(80, 29);
            this.openSavingAccountBtn.TabIndex = 17;
            this.openSavingAccountBtn.Text = "Otvori štednju";
            this.openSavingAccountBtn.UseVisualStyleBackColor = true;
            this.openSavingAccountBtn.Click += new System.EventHandler(this.openSavingAccountBtn_Click);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(453, 282);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(41, 13);
            this.addressLbl.TabIndex = 34;
            this.addressLbl.Text = "label11";
            // 
            // addressTitleLbl
            // 
            this.addressTitleLbl.AutoSize = true;
            this.addressTitleLbl.Location = new System.Drawing.Point(354, 282);
            this.addressTitleLbl.Name = "addressTitleLbl";
            this.addressTitleLbl.Size = new System.Drawing.Size(43, 13);
            this.addressTitleLbl.TabIndex = 33;
            this.addressTitleLbl.Text = "Adresa:";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(459, 248);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(35, 13);
            this.incomeLbl.TabIndex = 32;
            this.incomeLbl.Text = "label9";
            // 
            // oibTitleLbl
            // 
            this.oibTitleLbl.AutoSize = true;
            this.oibTitleLbl.Location = new System.Drawing.Point(354, 212);
            this.oibTitleLbl.Name = "oibTitleLbl";
            this.oibTitleLbl.Size = new System.Drawing.Size(28, 13);
            this.oibTitleLbl.TabIndex = 31;
            this.oibTitleLbl.Text = "OIB:";
            // 
            // oibLbl
            // 
            this.oibLbl.AutoSize = true;
            this.oibLbl.Location = new System.Drawing.Point(459, 212);
            this.oibLbl.Name = "oibLbl";
            this.oibLbl.Size = new System.Drawing.Size(35, 13);
            this.oibLbl.TabIndex = 30;
            this.oibLbl.Text = "label7";
            // 
            // incomeTitleLbl
            // 
            this.incomeTitleLbl.AutoSize = true;
            this.incomeTitleLbl.Location = new System.Drawing.Point(354, 247);
            this.incomeTitleLbl.Name = "incomeTitleLbl";
            this.incomeTitleLbl.Size = new System.Drawing.Size(84, 13);
            this.incomeTitleLbl.TabIndex = 29;
            this.incomeTitleLbl.Text = "Mjesečni prihod:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(459, 182);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(35, 13);
            this.lastNameLbl.TabIndex = 28;
            this.lastNameLbl.Text = "label5";
            // 
            // lastNameTitleLbl
            // 
            this.lastNameTitleLbl.AutoSize = true;
            this.lastNameTitleLbl.Location = new System.Drawing.Point(354, 178);
            this.lastNameTitleLbl.Name = "lastNameTitleLbl";
            this.lastNameTitleLbl.Size = new System.Drawing.Size(47, 13);
            this.lastNameTitleLbl.TabIndex = 27;
            this.lastNameTitleLbl.Text = "Prezime:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(459, 150);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(35, 13);
            this.firstNameLbl.TabIndex = 26;
            this.firstNameLbl.Text = "label3";
            // 
            // firstNameTitleLbl
            // 
            this.firstNameTitleLbl.AutoSize = true;
            this.firstNameTitleLbl.Location = new System.Drawing.Point(354, 146);
            this.firstNameTitleLbl.Name = "firstNameTitleLbl";
            this.firstNameTitleLbl.Size = new System.Drawing.Size(27, 13);
            this.firstNameTitleLbl.TabIndex = 25;
            this.firstNameTitleLbl.Text = "Ime:";
            // 
            // clientDetails
            // 
            this.clientDetails.AutoSize = true;
            this.clientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDetails.Location = new System.Drawing.Point(328, 109);
            this.clientDetails.Name = "clientDetails";
            this.clientDetails.Size = new System.Drawing.Size(110, 20);
            this.clientDetails.TabIndex = 24;
            this.clientDetails.Text = "Detalji klijenta:";
            // 
            // foreignCurrencyLbl
            // 
            this.foreignCurrencyLbl.AutoSize = true;
            this.foreignCurrencyLbl.Location = new System.Drawing.Point(465, 390);
            this.foreignCurrencyLbl.Name = "foreignCurrencyLbl";
            this.foreignCurrencyLbl.Size = new System.Drawing.Size(15, 14);
            this.foreignCurrencyLbl.TabIndex = 48;
            this.foreignCurrencyLbl.UseVisualStyleBackColor = true;
            // 
            // incomeBottomLineTitleLbl
            // 
            this.incomeBottomLineTitleLbl.AutoSize = true;
            this.incomeBottomLineTitleLbl.Location = new System.Drawing.Point(361, 491);
            this.incomeBottomLineTitleLbl.Name = "incomeBottomLineTitleLbl";
            this.incomeBottomLineTitleLbl.Size = new System.Drawing.Size(88, 13);
            this.incomeBottomLineTitleLbl.TabIndex = 46;
            this.incomeBottomLineTitleLbl.Text = "Oročena štednja:";
            // 
            // interestRateLbl
            // 
            this.interestRateLbl.AutoSize = true;
            this.interestRateLbl.Location = new System.Drawing.Point(462, 457);
            this.interestRateLbl.Name = "interestRateLbl";
            this.interestRateLbl.Size = new System.Drawing.Size(35, 13);
            this.interestRateLbl.TabIndex = 45;
            this.interestRateLbl.Text = "label9";
            // 
            // currencyTitleLbl
            // 
            this.currencyTitleLbl.AutoSize = true;
            this.currencyTitleLbl.Location = new System.Drawing.Point(364, 421);
            this.currencyTitleLbl.Name = "currencyTitleLbl";
            this.currencyTitleLbl.Size = new System.Drawing.Size(40, 13);
            this.currencyTitleLbl.TabIndex = 44;
            this.currencyTitleLbl.Text = "Valuta:";
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.Location = new System.Drawing.Point(462, 421);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(35, 13);
            this.currencyLbl.TabIndex = 43;
            this.currencyLbl.Text = "label7";
            // 
            // interestRateTitleLbl
            // 
            this.interestRateTitleLbl.AutoSize = true;
            this.interestRateTitleLbl.Location = new System.Drawing.Point(361, 457);
            this.interestRateTitleLbl.Name = "interestRateTitleLbl";
            this.interestRateTitleLbl.Size = new System.Drawing.Size(46, 13);
            this.interestRateTitleLbl.TabIndex = 42;
            this.interestRateTitleLbl.Text = "Kamata:";
            // 
            // foreignCurrencyTitleLbl
            // 
            this.foreignCurrencyTitleLbl.AutoSize = true;
            this.foreignCurrencyTitleLbl.Location = new System.Drawing.Point(364, 387);
            this.foreignCurrencyTitleLbl.Name = "foreignCurrencyTitleLbl";
            this.foreignCurrencyTitleLbl.Size = new System.Drawing.Size(45, 13);
            this.foreignCurrencyTitleLbl.TabIndex = 41;
            this.foreignCurrencyTitleLbl.Text = "Devizni:";
            // 
            // accountNameLbl
            // 
            this.accountNameLbl.AutoSize = true;
            this.accountNameLbl.Location = new System.Drawing.Point(462, 359);
            this.accountNameLbl.Name = "accountNameLbl";
            this.accountNameLbl.Size = new System.Drawing.Size(35, 13);
            this.accountNameLbl.TabIndex = 40;
            this.accountNameLbl.Text = "label3";
            // 
            // accountNameTitleLbl
            // 
            this.accountNameTitleLbl.AutoSize = true;
            this.accountNameTitleLbl.Location = new System.Drawing.Point(364, 355);
            this.accountNameTitleLbl.Name = "accountNameTitleLbl";
            this.accountNameTitleLbl.Size = new System.Drawing.Size(37, 13);
            this.accountNameTitleLbl.TabIndex = 39;
            this.accountNameTitleLbl.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tip štednog računa:";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // iBANDataGridViewTextBoxColumn
            // 
            this.iBANDataGridViewTextBoxColumn.DataPropertyName = "IBAN";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.iBANDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.iBANDataGridViewTextBoxColumn.HeaderText = "IBAN";
            this.iBANDataGridViewTextBoxColumn.Name = "iBANDataGridViewTextBoxColumn";
            // 
            // cardNumberDataGridViewTextBoxColumn
            // 
            this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "CardNumber";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.cardNumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cardNumberDataGridViewTextBoxColumn.HeaderText = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.balanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // blockedDataGridViewCheckBoxColumn
            // 
            this.blockedDataGridViewCheckBoxColumn.DataPropertyName = "Blocked";
            this.blockedDataGridViewCheckBoxColumn.HeaderText = "Blocked";
            this.blockedDataGridViewCheckBoxColumn.Name = "blockedDataGridViewCheckBoxColumn";
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountTypeIdDataGridViewTextBoxColumn
            // 
            this.accountTypeIdDataGridViewTextBoxColumn.DataPropertyName = "AccountTypeId";
            this.accountTypeIdDataGridViewTextBoxColumn.HeaderText = "AccountTypeId";
            this.accountTypeIdDataGridViewTextBoxColumn.Name = "accountTypeIdDataGridViewTextBoxColumn";
            this.accountTypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            this.accountTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.Visible = false;
            // 
            // loansDataGridViewTextBoxColumn
            // 
            this.loansDataGridViewTextBoxColumn.DataPropertyName = "Loans";
            this.loansDataGridViewTextBoxColumn.HeaderText = "Loans";
            this.loansDataGridViewTextBoxColumn.Name = "loansDataGridViewTextBoxColumn";
            this.loansDataGridViewTextBoxColumn.Visible = false;
            // 
            // savingAccountsDataGridViewTextBoxColumn
            // 
            this.savingAccountsDataGridViewTextBoxColumn.DataPropertyName = "SavingAccounts";
            this.savingAccountsDataGridViewTextBoxColumn.HeaderText = "SavingAccounts";
            this.savingAccountsDataGridViewTextBoxColumn.Name = "savingAccountsDataGridViewTextBoxColumn";
            this.savingAccountsDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(MobiFinanceBank.Model.Models.Account);
            // 
            // fixedTermLbl
            // 
            this.fixedTermLbl.AutoSize = true;
            this.fixedTermLbl.Location = new System.Drawing.Point(465, 491);
            this.fixedTermLbl.Name = "fixedTermLbl";
            this.fixedTermLbl.Size = new System.Drawing.Size(15, 14);
            this.fixedTermLbl.TabIndex = 49;
            this.fixedTermLbl.UseVisualStyleBackColor = true;
            // 
            // fixedTermPeriodTitleLbl
            // 
            this.fixedTermPeriodTitleLbl.AutoSize = true;
            this.fixedTermPeriodTitleLbl.Location = new System.Drawing.Point(361, 525);
            this.fixedTermPeriodTitleLbl.Name = "fixedTermPeriodTitleLbl";
            this.fixedTermPeriodTitleLbl.Size = new System.Drawing.Size(84, 13);
            this.fixedTermPeriodTitleLbl.TabIndex = 50;
            this.fixedTermPeriodTitleLbl.Text = "Period oročenja:";
            // 
            // fixedTermPeriodLbl
            // 
            this.fixedTermPeriodLbl.AutoSize = true;
            this.fixedTermPeriodLbl.Location = new System.Drawing.Point(462, 525);
            this.fixedTermPeriodLbl.Name = "fixedTermPeriodLbl";
            this.fixedTermPeriodLbl.Size = new System.Drawing.Size(35, 13);
            this.fixedTermPeriodLbl.TabIndex = 51;
            this.fixedTermPeriodLbl.Text = "label9";
            // 
            // OpenSavingAccountBankServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 567);
            this.Controls.Add(this.fixedTermPeriodLbl);
            this.Controls.Add(this.fixedTermPeriodTitleLbl);
            this.Controls.Add(this.fixedTermLbl);
            this.Controls.Add(this.foreignCurrencyLbl);
            this.Controls.Add(this.incomeBottomLineTitleLbl);
            this.Controls.Add(this.interestRateLbl);
            this.Controls.Add(this.currencyTitleLbl);
            this.Controls.Add(this.currencyLbl);
            this.Controls.Add(this.interestRateTitleLbl);
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
            this.Controls.Add(this.openSavingAccountBtn);
            this.Controls.Add(this.accountsDgv);
            this.Controls.Add(this.capitalNum);
            this.Controls.Add(this.startDateDtp);
            this.Controls.Add(this.standingOrderChb);
            this.Controls.Add(this.capitalLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.standingOrderLbl);
            this.Name = "OpenSavingAccountBankServiceForm";
            this.Text = "OpenSavingAccountBankServiceForm";
            this.Load += new System.EventHandler(this.OpenSavingAccountBankServiceForm_Load);
            this.Controls.SetChildIndex(this.standingOrderLbl, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.capitalLbl, 0);
            this.Controls.SetChildIndex(this.standingOrderChb, 0);
            this.Controls.SetChildIndex(this.startDateDtp, 0);
            this.Controls.SetChildIndex(this.capitalNum, 0);
            this.Controls.SetChildIndex(this.accountsDgv, 0);
            this.Controls.SetChildIndex(this.openSavingAccountBtn, 0);
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
            this.Controls.SetChildIndex(this.interestRateTitleLbl, 0);
            this.Controls.SetChildIndex(this.currencyLbl, 0);
            this.Controls.SetChildIndex(this.currencyTitleLbl, 0);
            this.Controls.SetChildIndex(this.interestRateLbl, 0);
            this.Controls.SetChildIndex(this.incomeBottomLineTitleLbl, 0);
            this.Controls.SetChildIndex(this.foreignCurrencyLbl, 0);
            this.Controls.SetChildIndex(this.fixedTermLbl, 0);
            this.Controls.SetChildIndex(this.fixedTermPeriodTitleLbl, 0);
            this.Controls.SetChildIndex(this.fixedTermPeriodLbl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.capitalNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label capitalLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label standingOrderLbl;
        private System.Windows.Forms.DateTimePicker startDateDtp;
        private System.Windows.Forms.CheckBox standingOrderChb;
        private System.Windows.Forms.NumericUpDown capitalNum;
        private System.Windows.Forms.DataGridView accountsDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn blockedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savingAccountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.Button openSavingAccountBtn;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label addressTitleLbl;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Label oibTitleLbl;
        private System.Windows.Forms.Label oibLbl;
        private System.Windows.Forms.Label incomeTitleLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label lastNameTitleLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label firstNameTitleLbl;
        private System.Windows.Forms.Label clientDetails;
        private System.Windows.Forms.CheckBox foreignCurrencyLbl;
        private System.Windows.Forms.Label incomeBottomLineTitleLbl;
        private System.Windows.Forms.Label interestRateLbl;
        private System.Windows.Forms.Label currencyTitleLbl;
        private System.Windows.Forms.Label currencyLbl;
        private System.Windows.Forms.Label interestRateTitleLbl;
        private System.Windows.Forms.Label foreignCurrencyTitleLbl;
        private System.Windows.Forms.Label accountNameLbl;
        private System.Windows.Forms.Label accountNameTitleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox fixedTermLbl;
        private System.Windows.Forms.Label fixedTermPeriodTitleLbl;
        private System.Windows.Forms.Label fixedTermPeriodLbl;
    }
}