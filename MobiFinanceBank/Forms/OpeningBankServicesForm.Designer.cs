namespace MobiFinanceBank.Forms
{
    partial class OpeningBankServicesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.savingAccountDgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedTermDepositingPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingAccountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingAccountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negativeBalanceLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeBottomLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negativeBalanceMonthlyFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanDgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankServicesCb = new System.Windows.Forms.ComboBox();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.createLoanBtn = new System.Windows.Forms.Button();
            this.createSavingAccountBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savingAccountDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savingAccountTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanTypeBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.savingAccountDgv);
            this.flowLayoutPanel1.Controls.Add(this.accountDgv);
            this.flowLayoutPanel1.Controls.Add(this.loanDgv);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(972, 343);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // savingAccountDgv
            // 
            this.savingAccountDgv.AutoGenerateColumns = false;
            this.savingAccountDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savingAccountDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.interestRateDataGridViewTextBoxColumn,
            this.fixedTermDepositingPeriodDataGridViewTextBoxColumn,
            this.savingAccountsDataGridViewTextBoxColumn});
            this.savingAccountDgv.DataSource = this.savingAccountTypeBindingSource;
            this.savingAccountDgv.Location = new System.Drawing.Point(3, 3);
            this.savingAccountDgv.Name = "savingAccountDgv";
            this.savingAccountDgv.RowTemplate.Height = 24;
            this.savingAccountDgv.Size = new System.Drawing.Size(417, 309);
            this.savingAccountDgv.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // interestRateDataGridViewTextBoxColumn
            // 
            this.interestRateDataGridViewTextBoxColumn.DataPropertyName = "InterestRate";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.interestRateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.interestRateDataGridViewTextBoxColumn.HeaderText = "InterestRate";
            this.interestRateDataGridViewTextBoxColumn.Name = "interestRateDataGridViewTextBoxColumn";
            // 
            // fixedTermDepositingPeriodDataGridViewTextBoxColumn
            // 
            this.fixedTermDepositingPeriodDataGridViewTextBoxColumn.DataPropertyName = "FixedTermDepositingPeriod";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.fixedTermDepositingPeriodDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fixedTermDepositingPeriodDataGridViewTextBoxColumn.HeaderText = "FixedTermDepositingPeriod";
            this.fixedTermDepositingPeriodDataGridViewTextBoxColumn.Name = "fixedTermDepositingPeriodDataGridViewTextBoxColumn";
            // 
            // savingAccountsDataGridViewTextBoxColumn
            // 
            this.savingAccountsDataGridViewTextBoxColumn.DataPropertyName = "SavingAccounts";
            this.savingAccountsDataGridViewTextBoxColumn.HeaderText = "SavingAccounts";
            this.savingAccountsDataGridViewTextBoxColumn.Name = "savingAccountsDataGridViewTextBoxColumn";
            this.savingAccountsDataGridViewTextBoxColumn.Visible = false;
            // 
            // savingAccountTypeBindingSource
            // 
            this.savingAccountTypeBindingSource.DataSource = typeof(MobiFinanceBank.Model.Models.SavingAccountType);
            // 
            // accountDgv
            // 
            this.accountDgv.AutoGenerateColumns = false;
            this.accountDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.negativeBalanceLimitDataGridViewTextBoxColumn,
            this.incomeBottomLimitDataGridViewTextBoxColumn,
            this.negativeBalanceMonthlyFeeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.accountsDataGridViewTextBoxColumn});
            this.accountDgv.DataSource = this.accountTypeBindingSource;
            this.accountDgv.Location = new System.Drawing.Point(426, 3);
            this.accountDgv.Name = "accountDgv";
            this.accountDgv.Size = new System.Drawing.Size(379, 306);
            this.accountDgv.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.nameDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // negativeBalanceLimitDataGridViewTextBoxColumn
            // 
            this.negativeBalanceLimitDataGridViewTextBoxColumn.DataPropertyName = "NegativeBalanceLimit";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.negativeBalanceLimitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.negativeBalanceLimitDataGridViewTextBoxColumn.HeaderText = "NegativeBalanceLimit";
            this.negativeBalanceLimitDataGridViewTextBoxColumn.Name = "negativeBalanceLimitDataGridViewTextBoxColumn";
            // 
            // incomeBottomLimitDataGridViewTextBoxColumn
            // 
            this.incomeBottomLimitDataGridViewTextBoxColumn.DataPropertyName = "IncomeBottomLimit";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.incomeBottomLimitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.incomeBottomLimitDataGridViewTextBoxColumn.HeaderText = "IncomeBottomLimit";
            this.incomeBottomLimitDataGridViewTextBoxColumn.Name = "incomeBottomLimitDataGridViewTextBoxColumn";
            // 
            // negativeBalanceMonthlyFeeDataGridViewTextBoxColumn
            // 
            this.negativeBalanceMonthlyFeeDataGridViewTextBoxColumn.DataPropertyName = "NegativeBalanceMonthlyFee";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.negativeBalanceMonthlyFeeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.negativeBalanceMonthlyFeeDataGridViewTextBoxColumn.HeaderText = "NegativeBalanceMonthlyFee";
            this.negativeBalanceMonthlyFeeDataGridViewTextBoxColumn.Name = "negativeBalanceMonthlyFeeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // accountsDataGridViewTextBoxColumn
            // 
            this.accountsDataGridViewTextBoxColumn.DataPropertyName = "Accounts";
            this.accountsDataGridViewTextBoxColumn.HeaderText = "Accounts";
            this.accountsDataGridViewTextBoxColumn.Name = "accountsDataGridViewTextBoxColumn";
            this.accountsDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountTypeBindingSource
            // 
            this.accountTypeBindingSource.DataSource = typeof(MobiFinanceBank.Model.Models.AccountType);
            // 
            // loanDgv
            // 
            this.loanDgv.AutoGenerateColumns = false;
            this.loanDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.loanDurationDataGridViewTextBoxColumn,
            this.interestRateDataGridViewTextBoxColumn1});
            this.loanDgv.DataSource = this.loanTypeBindingSource;
            this.loanDgv.Location = new System.Drawing.Point(811, 3);
            this.loanDgv.Name = "loanDgv";
            this.loanDgv.Size = new System.Drawing.Size(388, 306);
            this.loanDgv.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.nameDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // loanDurationDataGridViewTextBoxColumn
            // 
            this.loanDurationDataGridViewTextBoxColumn.DataPropertyName = "LoanDuration";
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.loanDurationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.loanDurationDataGridViewTextBoxColumn.HeaderText = "LoanDuration";
            this.loanDurationDataGridViewTextBoxColumn.Name = "loanDurationDataGridViewTextBoxColumn";
            // 
            // interestRateDataGridViewTextBoxColumn1
            // 
            this.interestRateDataGridViewTextBoxColumn1.DataPropertyName = "InterestRate";
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.interestRateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.interestRateDataGridViewTextBoxColumn1.HeaderText = "InterestRate";
            this.interestRateDataGridViewTextBoxColumn1.Name = "interestRateDataGridViewTextBoxColumn1";
            // 
            // loanTypeBindingSource
            // 
            this.loanTypeBindingSource.DataSource = typeof(MobiFinanceBank.Model.Models.LoanType);
            // 
            // bankServicesCb
            // 
            this.bankServicesCb.FormattingEnabled = true;
            this.bankServicesCb.Location = new System.Drawing.Point(1008, 132);
            this.bankServicesCb.Name = "bankServicesCb";
            this.bankServicesCb.Size = new System.Drawing.Size(203, 24);
            this.bankServicesCb.TabIndex = 4;
            this.bankServicesCb.SelectedIndexChanged += new System.EventHandler(this.bankServicesCb_SelectedIndexChanged);
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createAccountBtn.Location = new System.Drawing.Point(3, 43);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(95, 34);
            this.createAccountBtn.TabIndex = 5;
            this.createAccountBtn.Text = "Otvori račun";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // createLoanBtn
            // 
            this.createLoanBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createLoanBtn.Location = new System.Drawing.Point(3, 3);
            this.createLoanBtn.Name = "createLoanBtn";
            this.createLoanBtn.Size = new System.Drawing.Size(95, 34);
            this.createLoanBtn.TabIndex = 6;
            this.createLoanBtn.Text = "Otvori kredit";
            this.createLoanBtn.UseVisualStyleBackColor = true;
            // 
            // createSavingAccountBtn
            // 
            this.createSavingAccountBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createSavingAccountBtn.Location = new System.Drawing.Point(104, 3);
            this.createSavingAccountBtn.Name = "createSavingAccountBtn";
            this.createSavingAccountBtn.Size = new System.Drawing.Size(104, 34);
            this.createSavingAccountBtn.TabIndex = 7;
            this.createSavingAccountBtn.Text = "Otvori štednju";
            this.createSavingAccountBtn.UseVisualStyleBackColor = true;
            this.createSavingAccountBtn.Click += new System.EventHandler(this.createSavingAccountBtn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.createLoanBtn);
            this.flowLayoutPanel2.Controls.Add(this.createAccountBtn);
            this.flowLayoutPanel2.Controls.Add(this.createSavingAccountBtn);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1008, 269);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(219, 100);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // OpeningBankServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 484);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.bankServicesCb);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OpeningBankServicesForm";
            this.Text = "OpeningBankServicesForm";
            this.Load += new System.EventHandler(this.OpeningBankServicesForm_Load);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.bankServicesCb, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel2, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.savingAccountDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savingAccountTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanTypeBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView savingAccountDgv;
        private System.Windows.Forms.DataGridView accountDgv;
        private System.Windows.Forms.DataGridView loanDgv;
        private System.Windows.Forms.ComboBox bankServicesCb;
        private System.Windows.Forms.BindingSource savingAccountTypeBindingSource;
        private System.Windows.Forms.BindingSource accountTypeBindingSource;
        private System.Windows.Forms.BindingSource loanTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedTermDepositingPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savingAccountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn negativeBalanceLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeBottomLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn negativeBalanceMonthlyFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.Button createLoanBtn;
        private System.Windows.Forms.Button createSavingAccountBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}