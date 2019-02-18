namespace MobiFinanceBank.Forms
{
    partial class OpenLoanBankServiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.foreignCurrencyChb = new System.Windows.Forms.CheckBox();
            this.interestRateLbl = new System.Windows.Forms.Label();
            this.currencyTitleLbl = new System.Windows.Forms.Label();
            this.currencyLbl = new System.Windows.Forms.Label();
            this.interestRateTitleLbl = new System.Windows.Forms.Label();
            this.foreignCurrencyTitleLbl = new System.Windows.Forms.Label();
            this.accountNameLbl = new System.Windows.Forms.Label();
            this.accountNameTitleLbl = new System.Windows.Forms.Label();
            this.loanTypeLbl = new System.Windows.Forms.Label();
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
            this.loanRequestButton = new System.Windows.Forms.Button();
            this.accountsDgv = new System.Windows.Forms.DataGridView();
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
            this.capitalNum = new System.Windows.Forms.NumericUpDown();
            this.startDateDtp = new System.Windows.Forms.DateTimePicker();
            this.standingOrderChb = new System.Windows.Forms.CheckBox();
            this.capitalLbl = new System.Windows.Forms.Label();
            this.dateFromLbl = new System.Windows.Forms.Label();
            this.standingOrderLbl = new System.Windows.Forms.Label();
            this.loanDurationTitleLbl = new System.Windows.Forms.Label();
            this.loanDurationNum = new System.Windows.Forms.NumericUpDown();
            this.assessmentProgressBar = new System.Windows.Forms.ProgressBar();
            this.makeAssessmentBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDurationNum)).BeginInit();
            this.SuspendLayout();
            // 
            // foreignCurrencyChb
            // 
            this.foreignCurrencyChb.AutoSize = true;
            this.foreignCurrencyChb.Location = new System.Drawing.Point(555, 209);
            this.foreignCurrencyChb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foreignCurrencyChb.Name = "foreignCurrencyChb";
            this.foreignCurrencyChb.Size = new System.Drawing.Size(18, 17);
            this.foreignCurrencyChb.TabIndex = 80;
            this.foreignCurrencyChb.UseVisualStyleBackColor = true;
            // 
            // interestRateLbl
            // 
            this.interestRateLbl.AutoSize = true;
            this.interestRateLbl.Location = new System.Drawing.Point(551, 290);
            this.interestRateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.interestRateLbl.Name = "interestRateLbl";
            this.interestRateLbl.Size = new System.Drawing.Size(46, 17);
            this.interestRateLbl.TabIndex = 78;
            this.interestRateLbl.Text = "label9";
            // 
            // currencyTitleLbl
            // 
            this.currencyTitleLbl.AutoSize = true;
            this.currencyTitleLbl.Location = new System.Drawing.Point(420, 247);
            this.currencyTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currencyTitleLbl.Name = "currencyTitleLbl";
            this.currencyTitleLbl.Size = new System.Drawing.Size(52, 17);
            this.currencyTitleLbl.TabIndex = 77;
            this.currencyTitleLbl.Text = "Valuta:";
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.Location = new System.Drawing.Point(551, 247);
            this.currencyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(46, 17);
            this.currencyLbl.TabIndex = 76;
            this.currencyLbl.Text = "label7";
            // 
            // interestRateTitleLbl
            // 
            this.interestRateTitleLbl.AutoSize = true;
            this.interestRateTitleLbl.Location = new System.Drawing.Point(416, 290);
            this.interestRateTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.interestRateTitleLbl.Name = "interestRateTitleLbl";
            this.interestRateTitleLbl.Size = new System.Drawing.Size(60, 17);
            this.interestRateTitleLbl.TabIndex = 75;
            this.interestRateTitleLbl.Text = "Kamata:";
            // 
            // foreignCurrencyTitleLbl
            // 
            this.foreignCurrencyTitleLbl.AutoSize = true;
            this.foreignCurrencyTitleLbl.Location = new System.Drawing.Point(420, 206);
            this.foreignCurrencyTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foreignCurrencyTitleLbl.Name = "foreignCurrencyTitleLbl";
            this.foreignCurrencyTitleLbl.Size = new System.Drawing.Size(58, 17);
            this.foreignCurrencyTitleLbl.TabIndex = 74;
            this.foreignCurrencyTitleLbl.Text = "Devizni:";
            // 
            // accountNameLbl
            // 
            this.accountNameLbl.AutoSize = true;
            this.accountNameLbl.Location = new System.Drawing.Point(551, 171);
            this.accountNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountNameLbl.Name = "accountNameLbl";
            this.accountNameLbl.Size = new System.Drawing.Size(46, 17);
            this.accountNameLbl.TabIndex = 73;
            this.accountNameLbl.Text = "label3";
            // 
            // accountNameTitleLbl
            // 
            this.accountNameTitleLbl.AutoSize = true;
            this.accountNameTitleLbl.Location = new System.Drawing.Point(420, 166);
            this.accountNameTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountNameTitleLbl.Name = "accountNameTitleLbl";
            this.accountNameTitleLbl.Size = new System.Drawing.Size(47, 17);
            this.accountNameTitleLbl.TabIndex = 72;
            this.accountNameTitleLbl.Text = "Naziv:";
            // 
            // loanTypeLbl
            // 
            this.loanTypeLbl.AutoSize = true;
            this.loanTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTypeLbl.Location = new System.Drawing.Point(387, 124);
            this.loanTypeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loanTypeLbl.Name = "loanTypeLbl";
            this.loanTypeLbl.Size = new System.Drawing.Size(109, 25);
            this.loanTypeLbl.TabIndex = 71;
            this.loanTypeLbl.Text = "Tip kredita:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(304, 337);
            this.addressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(54, 17);
            this.addressLbl.TabIndex = 70;
            this.addressLbl.Text = "label11";
            // 
            // addressTitleLbl
            // 
            this.addressTitleLbl.AutoSize = true;
            this.addressTitleLbl.Location = new System.Drawing.Point(172, 337);
            this.addressTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressTitleLbl.Name = "addressTitleLbl";
            this.addressTitleLbl.Size = new System.Drawing.Size(57, 17);
            this.addressTitleLbl.TabIndex = 69;
            this.addressTitleLbl.Text = "Adresa:";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(312, 295);
            this.incomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(46, 17);
            this.incomeLbl.TabIndex = 68;
            this.incomeLbl.Text = "label9";
            // 
            // oibTitleLbl
            // 
            this.oibTitleLbl.AutoSize = true;
            this.oibTitleLbl.Location = new System.Drawing.Point(172, 251);
            this.oibTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oibTitleLbl.Name = "oibTitleLbl";
            this.oibTitleLbl.Size = new System.Drawing.Size(35, 17);
            this.oibTitleLbl.TabIndex = 67;
            this.oibTitleLbl.Text = "OIB:";
            // 
            // oibLbl
            // 
            this.oibLbl.AutoSize = true;
            this.oibLbl.Location = new System.Drawing.Point(312, 251);
            this.oibLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oibLbl.Name = "oibLbl";
            this.oibLbl.Size = new System.Drawing.Size(46, 17);
            this.oibLbl.TabIndex = 66;
            this.oibLbl.Text = "label7";
            // 
            // incomeTitleLbl
            // 
            this.incomeTitleLbl.AutoSize = true;
            this.incomeTitleLbl.Location = new System.Drawing.Point(172, 294);
            this.incomeTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomeTitleLbl.Name = "incomeTitleLbl";
            this.incomeTitleLbl.Size = new System.Drawing.Size(111, 17);
            this.incomeTitleLbl.TabIndex = 65;
            this.incomeTitleLbl.Text = "Mjesečni prihod:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(312, 214);
            this.lastNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(46, 17);
            this.lastNameLbl.TabIndex = 64;
            this.lastNameLbl.Text = "label5";
            // 
            // lastNameTitleLbl
            // 
            this.lastNameTitleLbl.AutoSize = true;
            this.lastNameTitleLbl.Location = new System.Drawing.Point(172, 209);
            this.lastNameTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameTitleLbl.Name = "lastNameTitleLbl";
            this.lastNameTitleLbl.Size = new System.Drawing.Size(63, 17);
            this.lastNameTitleLbl.TabIndex = 63;
            this.lastNameTitleLbl.Text = "Prezime:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(312, 175);
            this.firstNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(46, 17);
            this.firstNameLbl.TabIndex = 62;
            this.firstNameLbl.Text = "label3";
            // 
            // firstNameTitleLbl
            // 
            this.firstNameTitleLbl.AutoSize = true;
            this.firstNameTitleLbl.Location = new System.Drawing.Point(172, 170);
            this.firstNameTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameTitleLbl.Name = "firstNameTitleLbl";
            this.firstNameTitleLbl.Size = new System.Drawing.Size(34, 17);
            this.firstNameTitleLbl.TabIndex = 61;
            this.firstNameTitleLbl.Text = "Ime:";
            // 
            // clientDetails
            // 
            this.clientDetails.AutoSize = true;
            this.clientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDetails.Location = new System.Drawing.Point(137, 124);
            this.clientDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientDetails.Name = "clientDetails";
            this.clientDetails.Size = new System.Drawing.Size(136, 25);
            this.clientDetails.TabIndex = 60;
            this.clientDetails.Text = "Detalji klijenta:";
            // 
            // loanRequestButton
            // 
            this.loanRequestButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loanRequestButton.Location = new System.Drawing.Point(408, 590);
            this.loanRequestButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loanRequestButton.Name = "loanRequestButton";
            this.loanRequestButton.Size = new System.Drawing.Size(128, 37);
            this.loanRequestButton.TabIndex = 59;
            this.loanRequestButton.Text = "Predaj zahtjev";
            this.loanRequestButton.UseVisualStyleBackColor = true;
            this.loanRequestButton.Click += new System.EventHandler(this.loanRequestButton_Click);
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
            this.accountsDgv.Location = new System.Drawing.Point(671, 124);
            this.accountsDgv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.accountsDgv.Name = "accountsDgv";
            this.accountsDgv.RowTemplate.Height = 24;
            this.accountsDgv.Size = new System.Drawing.Size(581, 277);
            this.accountsDgv.TabIndex = 58;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = false;
            this.blockedDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
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
            // capitalNum
            // 
            this.capitalNum.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.capitalNum.Location = new System.Drawing.Point(293, 420);
            this.capitalNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capitalNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.capitalNum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.capitalNum.Name = "capitalNum";
            this.capitalNum.Size = new System.Drawing.Size(120, 22);
            this.capitalNum.TabIndex = 57;
            this.capitalNum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // startDateDtp
            // 
            this.startDateDtp.Location = new System.Drawing.Point(293, 470);
            this.startDateDtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDateDtp.Name = "startDateDtp";
            this.startDateDtp.Size = new System.Drawing.Size(200, 22);
            this.startDateDtp.TabIndex = 55;
            // 
            // standingOrderChb
            // 
            this.standingOrderChb.AutoSize = true;
            this.standingOrderChb.Location = new System.Drawing.Point(295, 558);
            this.standingOrderChb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.standingOrderChb.Name = "standingOrderChb";
            this.standingOrderChb.Size = new System.Drawing.Size(18, 17);
            this.standingOrderChb.TabIndex = 56;
            this.standingOrderChb.UseVisualStyleBackColor = true;
            this.standingOrderChb.CheckedChanged += new System.EventHandler(this.standingOrderChb_CheckedChanged);
            // 
            // capitalLbl
            // 
            this.capitalLbl.AutoSize = true;
            this.capitalLbl.Location = new System.Drawing.Point(144, 420);
            this.capitalLbl.Name = "capitalLbl";
            this.capitalLbl.Size = new System.Drawing.Size(63, 17);
            this.capitalLbl.TabIndex = 52;
            this.capitalLbl.Text = "Glavnica";
            // 
            // dateFromLbl
            // 
            this.dateFromLbl.AutoSize = true;
            this.dateFromLbl.Location = new System.Drawing.Point(144, 470);
            this.dateFromLbl.Name = "dateFromLbl";
            this.dateFromLbl.Size = new System.Drawing.Size(103, 17);
            this.dateFromLbl.TabIndex = 53;
            this.dateFromLbl.Text = "Datum početka";
            // 
            // standingOrderLbl
            // 
            this.standingOrderLbl.AutoSize = true;
            this.standingOrderLbl.Location = new System.Drawing.Point(147, 558);
            this.standingOrderLbl.Name = "standingOrderLbl";
            this.standingOrderLbl.Size = new System.Drawing.Size(83, 17);
            this.standingOrderLbl.TabIndex = 54;
            this.standingOrderLbl.Text = "Trajni nalog";
            // 
            // loanDurationTitleLbl
            // 
            this.loanDurationTitleLbl.AutoSize = true;
            this.loanDurationTitleLbl.Location = new System.Drawing.Point(147, 514);
            this.loanDurationTitleLbl.Name = "loanDurationTitleLbl";
            this.loanDurationTitleLbl.Size = new System.Drawing.Size(117, 17);
            this.loanDurationTitleLbl.TabIndex = 84;
            this.loanDurationTitleLbl.Text = "Trajanje(godine):";
            // 
            // loanDurationNum
            // 
            this.loanDurationNum.Location = new System.Drawing.Point(293, 514);
            this.loanDurationNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loanDurationNum.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.loanDurationNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loanDurationNum.Name = "loanDurationNum";
            this.loanDurationNum.Size = new System.Drawing.Size(65, 22);
            this.loanDurationNum.TabIndex = 85;
            this.loanDurationNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // assessmentProgressBar
            // 
            this.assessmentProgressBar.Location = new System.Drawing.Point(408, 517);
            this.assessmentProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assessmentProgressBar.Name = "assessmentProgressBar";
            this.assessmentProgressBar.Size = new System.Drawing.Size(303, 23);
            this.assessmentProgressBar.TabIndex = 86;
            // 
            // makeAssessmentBtn
            // 
            this.makeAssessmentBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.makeAssessmentBtn.Location = new System.Drawing.Point(408, 546);
            this.makeAssessmentBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeAssessmentBtn.Name = "makeAssessmentBtn";
            this.makeAssessmentBtn.Size = new System.Drawing.Size(128, 34);
            this.makeAssessmentBtn.TabIndex = 87;
            this.makeAssessmentBtn.Text = "Napravi procjenu";
            this.makeAssessmentBtn.UseVisualStyleBackColor = true;
            this.makeAssessmentBtn.Click += new System.EventHandler(this.makeAssessmentBtn_Click);
            // 
            // OpenLoanBankServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 638);
            this.Controls.Add(this.makeAssessmentBtn);
            this.Controls.Add(this.assessmentProgressBar);
            this.Controls.Add(this.loanDurationNum);
            this.Controls.Add(this.loanDurationTitleLbl);
            this.Controls.Add(this.foreignCurrencyChb);
            this.Controls.Add(this.interestRateLbl);
            this.Controls.Add(this.currencyTitleLbl);
            this.Controls.Add(this.currencyLbl);
            this.Controls.Add(this.interestRateTitleLbl);
            this.Controls.Add(this.foreignCurrencyTitleLbl);
            this.Controls.Add(this.accountNameLbl);
            this.Controls.Add(this.accountNameTitleLbl);
            this.Controls.Add(this.loanTypeLbl);
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
            this.Controls.Add(this.loanRequestButton);
            this.Controls.Add(this.accountsDgv);
            this.Controls.Add(this.capitalNum);
            this.Controls.Add(this.startDateDtp);
            this.Controls.Add(this.standingOrderChb);
            this.Controls.Add(this.capitalLbl);
            this.Controls.Add(this.dateFromLbl);
            this.Controls.Add(this.standingOrderLbl);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OpenLoanBankServiceForm";
            this.Text = "OpenLoanBankServiceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenLoanBankServiceForm_FormClosing);
            this.Load += new System.EventHandler(this.OpenLoanBankServiceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpenLoanBankServiceForm_KeyDown);
            this.Controls.SetChildIndex(this.standingOrderLbl, 0);
            this.Controls.SetChildIndex(this.dateFromLbl, 0);
            this.Controls.SetChildIndex(this.capitalLbl, 0);
            this.Controls.SetChildIndex(this.standingOrderChb, 0);
            this.Controls.SetChildIndex(this.startDateDtp, 0);
            this.Controls.SetChildIndex(this.capitalNum, 0);
            this.Controls.SetChildIndex(this.accountsDgv, 0);
            this.Controls.SetChildIndex(this.loanRequestButton, 0);
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
            this.Controls.SetChildIndex(this.loanTypeLbl, 0);
            this.Controls.SetChildIndex(this.accountNameTitleLbl, 0);
            this.Controls.SetChildIndex(this.accountNameLbl, 0);
            this.Controls.SetChildIndex(this.foreignCurrencyTitleLbl, 0);
            this.Controls.SetChildIndex(this.interestRateTitleLbl, 0);
            this.Controls.SetChildIndex(this.currencyLbl, 0);
            this.Controls.SetChildIndex(this.currencyTitleLbl, 0);
            this.Controls.SetChildIndex(this.interestRateLbl, 0);
            this.Controls.SetChildIndex(this.foreignCurrencyChb, 0);
            this.Controls.SetChildIndex(this.loanDurationTitleLbl, 0);
            this.Controls.SetChildIndex(this.loanDurationNum, 0);
            this.Controls.SetChildIndex(this.assessmentProgressBar, 0);
            this.Controls.SetChildIndex(this.makeAssessmentBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.accountsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDurationNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox foreignCurrencyChb;
        private System.Windows.Forms.Label interestRateLbl;
        private System.Windows.Forms.Label currencyTitleLbl;
        private System.Windows.Forms.Label currencyLbl;
        private System.Windows.Forms.Label interestRateTitleLbl;
        private System.Windows.Forms.Label foreignCurrencyTitleLbl;
        private System.Windows.Forms.Label accountNameLbl;
        private System.Windows.Forms.Label accountNameTitleLbl;
        private System.Windows.Forms.Label loanTypeLbl;
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
        private System.Windows.Forms.Button loanRequestButton;
        private System.Windows.Forms.DataGridView accountsDgv;
        private System.Windows.Forms.DateTimePicker startDateDtp;
        private System.Windows.Forms.CheckBox standingOrderChb;
        private System.Windows.Forms.Label capitalLbl;
        private System.Windows.Forms.Label dateFromLbl;
        private System.Windows.Forms.Label standingOrderLbl;
        private System.Windows.Forms.Label loanDurationTitleLbl;
        private System.Windows.Forms.NumericUpDown loanDurationNum;
        private System.Windows.Forms.ProgressBar assessmentProgressBar;
        private System.Windows.Forms.Button makeAssessmentBtn;
        private System.Windows.Forms.NumericUpDown capitalNum;
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
    }
}