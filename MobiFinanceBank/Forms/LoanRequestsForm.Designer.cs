namespace MobiFinanceBank.Forms
{
    partial class LoanRequestsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loanRequestsDgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isStandingOrderActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repaymentPlansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.assessmentProgressBar = new System.Windows.Forms.ProgressBar();
            this.makeAssessmentLbl = new System.Windows.Forms.Label();
            this.approveLoanRequestBtn = new System.Windows.Forms.Button();
            this.declineLoanRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loanRequestsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loanRequestsDgv
            // 
            this.loanRequestsDgv.AutoGenerateColumns = false;
            this.loanRequestsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanRequestsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.loanStartDateDataGridViewTextBoxColumn,
            this.loanEndDateDataGridViewTextBoxColumn,
            this.loanDurationDataGridViewTextBoxColumn,
            this.capitalDataGridViewTextBoxColumn,
            this.isStandingOrderActiveDataGridViewCheckBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.loanTypeIdDataGridViewTextBoxColumn,
            this.accountIdDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.loanTypeDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.repaymentPlansDataGridViewTextBoxColumn});
            this.loanRequestsDgv.DataSource = this.loanBindingSource;
            this.loanRequestsDgv.Location = new System.Drawing.Point(12, 114);
            this.loanRequestsDgv.Name = "loanRequestsDgv";
            this.loanRequestsDgv.RowTemplate.Height = 24;
            this.loanRequestsDgv.Size = new System.Drawing.Size(734, 263);
            this.loanRequestsDgv.TabIndex = 3;
            this.loanRequestsDgv.SelectionChanged += new System.EventHandler(this.loanRequestsDgv_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.statusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // loanStartDateDataGridViewTextBoxColumn
            // 
            this.loanStartDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loanStartDateDataGridViewTextBoxColumn.DataPropertyName = "LoanStartDate";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.loanStartDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.loanStartDateDataGridViewTextBoxColumn.HeaderText = "LoanStartDate";
            this.loanStartDateDataGridViewTextBoxColumn.Name = "loanStartDateDataGridViewTextBoxColumn";
            this.loanStartDateDataGridViewTextBoxColumn.Width = 129;
            // 
            // loanEndDateDataGridViewTextBoxColumn
            // 
            this.loanEndDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loanEndDateDataGridViewTextBoxColumn.DataPropertyName = "LoanEndDate";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.loanEndDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.loanEndDateDataGridViewTextBoxColumn.HeaderText = "LoanEndDate";
            this.loanEndDateDataGridViewTextBoxColumn.Name = "loanEndDateDataGridViewTextBoxColumn";
            this.loanEndDateDataGridViewTextBoxColumn.Width = 124;
            // 
            // loanDurationDataGridViewTextBoxColumn
            // 
            this.loanDurationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loanDurationDataGridViewTextBoxColumn.DataPropertyName = "LoanDuration";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.loanDurationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.loanDurationDataGridViewTextBoxColumn.HeaderText = "LoanDuration";
            this.loanDurationDataGridViewTextBoxColumn.Name = "loanDurationDataGridViewTextBoxColumn";
            this.loanDurationDataGridViewTextBoxColumn.Width = 123;
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            this.capitalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.capitalDataGridViewTextBoxColumn.DataPropertyName = "Capital";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.capitalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.capitalDataGridViewTextBoxColumn.HeaderText = "Capital";
            this.capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            this.capitalDataGridViewTextBoxColumn.Width = 80;
            // 
            // isStandingOrderActiveDataGridViewCheckBoxColumn
            // 
            this.isStandingOrderActiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isStandingOrderActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsStandingOrderActive";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = false;
            this.isStandingOrderActiveDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.isStandingOrderActiveDataGridViewCheckBoxColumn.HeaderText = "IsStandingOrderActive";
            this.isStandingOrderActiveDataGridViewCheckBoxColumn.Name = "isStandingOrderActiveDataGridViewCheckBoxColumn";
            this.isStandingOrderActiveDataGridViewCheckBoxColumn.Width = 155;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // loanTypeIdDataGridViewTextBoxColumn
            // 
            this.loanTypeIdDataGridViewTextBoxColumn.DataPropertyName = "LoanTypeId";
            this.loanTypeIdDataGridViewTextBoxColumn.HeaderText = "LoanTypeId";
            this.loanTypeIdDataGridViewTextBoxColumn.Name = "loanTypeIdDataGridViewTextBoxColumn";
            this.loanTypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.HeaderText = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            this.accountIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.Visible = false;
            // 
            // loanTypeDataGridViewTextBoxColumn
            // 
            this.loanTypeDataGridViewTextBoxColumn.DataPropertyName = "LoanType";
            this.loanTypeDataGridViewTextBoxColumn.HeaderText = "LoanType";
            this.loanTypeDataGridViewTextBoxColumn.Name = "loanTypeDataGridViewTextBoxColumn";
            this.loanTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.Visible = false;
            // 
            // repaymentPlansDataGridViewTextBoxColumn
            // 
            this.repaymentPlansDataGridViewTextBoxColumn.DataPropertyName = "RepaymentPlans";
            this.repaymentPlansDataGridViewTextBoxColumn.HeaderText = "RepaymentPlans";
            this.repaymentPlansDataGridViewTextBoxColumn.Name = "repaymentPlansDataGridViewTextBoxColumn";
            this.repaymentPlansDataGridViewTextBoxColumn.Visible = false;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(MobiFinanceBank.Model.Models.Loan);
            // 
            // foreignCurrencyChb
            // 
            this.foreignCurrencyChb.AutoSize = true;
            this.foreignCurrencyChb.Location = new System.Drawing.Point(1214, 199);
            this.foreignCurrencyChb.Margin = new System.Windows.Forms.Padding(4);
            this.foreignCurrencyChb.Name = "foreignCurrencyChb";
            this.foreignCurrencyChb.Size = new System.Drawing.Size(18, 17);
            this.foreignCurrencyChb.TabIndex = 100;
            this.foreignCurrencyChb.UseVisualStyleBackColor = true;
            // 
            // interestRateLbl
            // 
            this.interestRateLbl.AutoSize = true;
            this.interestRateLbl.Location = new System.Drawing.Point(1211, 280);
            this.interestRateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.interestRateLbl.Name = "interestRateLbl";
            this.interestRateLbl.Size = new System.Drawing.Size(13, 17);
            this.interestRateLbl.TabIndex = 99;
            this.interestRateLbl.Text = "-";
            // 
            // currencyTitleLbl
            // 
            this.currencyTitleLbl.AutoSize = true;
            this.currencyTitleLbl.Location = new System.Drawing.Point(1079, 237);
            this.currencyTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currencyTitleLbl.Name = "currencyTitleLbl";
            this.currencyTitleLbl.Size = new System.Drawing.Size(52, 17);
            this.currencyTitleLbl.TabIndex = 98;
            this.currencyTitleLbl.Text = "Valuta:";
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.Location = new System.Drawing.Point(1211, 237);
            this.currencyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(13, 17);
            this.currencyLbl.TabIndex = 97;
            this.currencyLbl.Text = "-";
            // 
            // interestRateTitleLbl
            // 
            this.interestRateTitleLbl.AutoSize = true;
            this.interestRateTitleLbl.Location = new System.Drawing.Point(1079, 280);
            this.interestRateTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.interestRateTitleLbl.Name = "interestRateTitleLbl";
            this.interestRateTitleLbl.Size = new System.Drawing.Size(60, 17);
            this.interestRateTitleLbl.TabIndex = 96;
            this.interestRateTitleLbl.Text = "Kamata:";
            // 
            // foreignCurrencyTitleLbl
            // 
            this.foreignCurrencyTitleLbl.AutoSize = true;
            this.foreignCurrencyTitleLbl.Location = new System.Drawing.Point(1079, 198);
            this.foreignCurrencyTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foreignCurrencyTitleLbl.Name = "foreignCurrencyTitleLbl";
            this.foreignCurrencyTitleLbl.Size = new System.Drawing.Size(58, 17);
            this.foreignCurrencyTitleLbl.TabIndex = 95;
            this.foreignCurrencyTitleLbl.Text = "Devizni:";
            // 
            // accountNameLbl
            // 
            this.accountNameLbl.AutoSize = true;
            this.accountNameLbl.Location = new System.Drawing.Point(1211, 160);
            this.accountNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountNameLbl.Name = "accountNameLbl";
            this.accountNameLbl.Size = new System.Drawing.Size(13, 17);
            this.accountNameLbl.TabIndex = 94;
            this.accountNameLbl.Text = "-";
            // 
            // accountNameTitleLbl
            // 
            this.accountNameTitleLbl.AutoSize = true;
            this.accountNameTitleLbl.Location = new System.Drawing.Point(1079, 160);
            this.accountNameTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountNameTitleLbl.Name = "accountNameTitleLbl";
            this.accountNameTitleLbl.Size = new System.Drawing.Size(47, 17);
            this.accountNameTitleLbl.TabIndex = 93;
            this.accountNameTitleLbl.Text = "Naziv:";
            // 
            // loanTypeLbl
            // 
            this.loanTypeLbl.AutoSize = true;
            this.loanTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTypeLbl.Location = new System.Drawing.Point(1046, 114);
            this.loanTypeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loanTypeLbl.Name = "loanTypeLbl";
            this.loanTypeLbl.Size = new System.Drawing.Size(109, 25);
            this.loanTypeLbl.TabIndex = 92;
            this.loanTypeLbl.Text = "Tip kredita:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(971, 327);
            this.addressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(13, 17);
            this.addressLbl.TabIndex = 91;
            this.addressLbl.Text = "-";
            // 
            // addressTitleLbl
            // 
            this.addressTitleLbl.AutoSize = true;
            this.addressTitleLbl.Location = new System.Drawing.Point(831, 327);
            this.addressTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressTitleLbl.Name = "addressTitleLbl";
            this.addressTitleLbl.Size = new System.Drawing.Size(57, 17);
            this.addressTitleLbl.TabIndex = 90;
            this.addressTitleLbl.Text = "Adresa:";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(971, 284);
            this.incomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(13, 17);
            this.incomeLbl.TabIndex = 89;
            this.incomeLbl.Text = "-";
            // 
            // oibTitleLbl
            // 
            this.oibTitleLbl.AutoSize = true;
            this.oibTitleLbl.Location = new System.Drawing.Point(831, 241);
            this.oibTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oibTitleLbl.Name = "oibTitleLbl";
            this.oibTitleLbl.Size = new System.Drawing.Size(35, 17);
            this.oibTitleLbl.TabIndex = 88;
            this.oibTitleLbl.Text = "OIB:";
            // 
            // oibLbl
            // 
            this.oibLbl.AutoSize = true;
            this.oibLbl.Location = new System.Drawing.Point(971, 241);
            this.oibLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oibLbl.Name = "oibLbl";
            this.oibLbl.Size = new System.Drawing.Size(13, 17);
            this.oibLbl.TabIndex = 87;
            this.oibLbl.Text = "-";
            // 
            // incomeTitleLbl
            // 
            this.incomeTitleLbl.AutoSize = true;
            this.incomeTitleLbl.Location = new System.Drawing.Point(831, 284);
            this.incomeTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomeTitleLbl.Name = "incomeTitleLbl";
            this.incomeTitleLbl.Size = new System.Drawing.Size(111, 17);
            this.incomeTitleLbl.TabIndex = 86;
            this.incomeTitleLbl.Text = "Mjesečni prihod:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(971, 199);
            this.lastNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(13, 17);
            this.lastNameLbl.TabIndex = 85;
            this.lastNameLbl.Text = "-";
            // 
            // lastNameTitleLbl
            // 
            this.lastNameTitleLbl.AutoSize = true;
            this.lastNameTitleLbl.Location = new System.Drawing.Point(831, 199);
            this.lastNameTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameTitleLbl.Name = "lastNameTitleLbl";
            this.lastNameTitleLbl.Size = new System.Drawing.Size(63, 17);
            this.lastNameTitleLbl.TabIndex = 84;
            this.lastNameTitleLbl.Text = "Prezime:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(971, 160);
            this.firstNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(13, 17);
            this.firstNameLbl.TabIndex = 83;
            this.firstNameLbl.Text = "-";
            // 
            // firstNameTitleLbl
            // 
            this.firstNameTitleLbl.AutoSize = true;
            this.firstNameTitleLbl.Location = new System.Drawing.Point(831, 160);
            this.firstNameTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameTitleLbl.Name = "firstNameTitleLbl";
            this.firstNameTitleLbl.Size = new System.Drawing.Size(34, 17);
            this.firstNameTitleLbl.TabIndex = 82;
            this.firstNameTitleLbl.Text = "Ime:";
            // 
            // clientDetails
            // 
            this.clientDetails.AutoSize = true;
            this.clientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDetails.Location = new System.Drawing.Point(796, 114);
            this.clientDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientDetails.Name = "clientDetails";
            this.clientDetails.Size = new System.Drawing.Size(136, 25);
            this.clientDetails.TabIndex = 81;
            this.clientDetails.Text = "Detalji klijenta:";
            // 
            // assessmentProgressBar
            // 
            this.assessmentProgressBar.Location = new System.Drawing.Point(829, 403);
            this.assessmentProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assessmentProgressBar.Name = "assessmentProgressBar";
            this.assessmentProgressBar.Size = new System.Drawing.Size(303, 23);
            this.assessmentProgressBar.TabIndex = 101;
            // 
            // makeAssessmentLbl
            // 
            this.makeAssessmentLbl.AutoSize = true;
            this.makeAssessmentLbl.Location = new System.Drawing.Point(826, 375);
            this.makeAssessmentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.makeAssessmentLbl.Name = "makeAssessmentLbl";
            this.makeAssessmentLbl.Size = new System.Drawing.Size(68, 17);
            this.makeAssessmentLbl.TabIndex = 102;
            this.makeAssessmentLbl.Text = "Procjena:";
            // 
            // approveLoanRequestBtn
            // 
            this.approveLoanRequestBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.approveLoanRequestBtn.Location = new System.Drawing.Point(829, 431);
            this.approveLoanRequestBtn.Name = "approveLoanRequestBtn";
            this.approveLoanRequestBtn.Size = new System.Drawing.Size(186, 30);
            this.approveLoanRequestBtn.TabIndex = 103;
            this.approveLoanRequestBtn.Text = "Odobri kreditni zahtjev";
            this.approveLoanRequestBtn.UseVisualStyleBackColor = true;
            this.approveLoanRequestBtn.Click += new System.EventHandler(this.approveLoanRequestBtn_Click);
            // 
            // declineLoanRequest
            // 
            this.declineLoanRequest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.declineLoanRequest.Location = new System.Drawing.Point(829, 467);
            this.declineLoanRequest.Name = "declineLoanRequest";
            this.declineLoanRequest.Size = new System.Drawing.Size(186, 30);
            this.declineLoanRequest.TabIndex = 104;
            this.declineLoanRequest.Text = "Odbij kreditni zahtjev";
            this.declineLoanRequest.UseVisualStyleBackColor = true;
            this.declineLoanRequest.Click += new System.EventHandler(this.declineLoanRequest_Click);
            // 
            // LoanRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 572);
            this.Controls.Add(this.declineLoanRequest);
            this.Controls.Add(this.approveLoanRequestBtn);
            this.Controls.Add(this.makeAssessmentLbl);
            this.Controls.Add(this.assessmentProgressBar);
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
            this.Controls.Add(this.loanRequestsDgv);
            this.Name = "LoanRequestsForm";
            this.Text = "LoanRequestsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoanRequestsForm_FormClosing);
            this.Controls.SetChildIndex(this.loanRequestsDgv, 0);
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
            this.Controls.SetChildIndex(this.assessmentProgressBar, 0);
            this.Controls.SetChildIndex(this.makeAssessmentLbl, 0);
            this.Controls.SetChildIndex(this.approveLoanRequestBtn, 0);
            this.Controls.SetChildIndex(this.declineLoanRequest, 0);
            ((System.ComponentModel.ISupportInitialize)(this.loanRequestsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loanRequestsDgv;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isStandingOrderActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repaymentPlansDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.ProgressBar assessmentProgressBar;
        private System.Windows.Forms.Label makeAssessmentLbl;
        private System.Windows.Forms.Button approveLoanRequestBtn;
        private System.Windows.Forms.Button declineLoanRequest;
    }
}