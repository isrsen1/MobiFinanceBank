namespace MobiFinanceBank.Forms
{
    partial class BankServicesOverviewForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.accountDgv = new System.Windows.Forms.DataGridView();
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
            this.loanDgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.savingAccountDgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankServicesCb = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savingAccountDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savingAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.accountDgv);
            this.flowLayoutPanel1.Controls.Add(this.loanDgv);
            this.flowLayoutPanel1.Controls.Add(this.savingAccountDgv);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 137);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(976, 331);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // accountDgv
            // 
            this.accountDgv.AutoGenerateColumns = false;
            this.accountDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.accountDgv.DataSource = this.accountBindingSource;
            this.accountDgv.Location = new System.Drawing.Point(3, 3);
            this.accountDgv.Name = "accountDgv";
            this.accountDgv.RowTemplate.Height = 24;
            this.accountDgv.Size = new System.Drawing.Size(822, 150);
            this.accountDgv.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // iBANDataGridViewTextBoxColumn
            // 
            this.iBANDataGridViewTextBoxColumn.DataPropertyName = "IBAN";
            this.iBANDataGridViewTextBoxColumn.HeaderText = "IBAN";
            this.iBANDataGridViewTextBoxColumn.Name = "iBANDataGridViewTextBoxColumn";
            // 
            // cardNumberDataGridViewTextBoxColumn
            // 
            this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.HeaderText = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
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
            // 
            // accountTypeIdDataGridViewTextBoxColumn
            // 
            this.accountTypeIdDataGridViewTextBoxColumn.DataPropertyName = "AccountTypeId";
            this.accountTypeIdDataGridViewTextBoxColumn.HeaderText = "AccountTypeId";
            this.accountTypeIdDataGridViewTextBoxColumn.Name = "accountTypeIdDataGridViewTextBoxColumn";
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            // 
            // loansDataGridViewTextBoxColumn
            // 
            this.loansDataGridViewTextBoxColumn.DataPropertyName = "Loans";
            this.loansDataGridViewTextBoxColumn.HeaderText = "Loans";
            this.loansDataGridViewTextBoxColumn.Name = "loansDataGridViewTextBoxColumn";
            // 
            // savingAccountsDataGridViewTextBoxColumn
            // 
            this.savingAccountsDataGridViewTextBoxColumn.DataPropertyName = "SavingAccounts";
            this.savingAccountsDataGridViewTextBoxColumn.HeaderText = "SavingAccounts";
            this.savingAccountsDataGridViewTextBoxColumn.Name = "savingAccountsDataGridViewTextBoxColumn";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(MobiFinanceBank.Model.Models.Account);
            // 
            // loanDgv
            // 
            this.loanDgv.AutoGenerateColumns = false;
            this.loanDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10});
            this.loanDgv.DataSource = this.loanBindingSource;
            this.loanDgv.Location = new System.Drawing.Point(3, 159);
            this.loanDgv.Name = "loanDgv";
            this.loanDgv.RowTemplate.Height = 24;
            this.loanDgv.Size = new System.Drawing.Size(923, 150);
            this.loanDgv.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ClientId";
            this.dataGridViewTextBoxColumn5.HeaderText = "ClientId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn7.HeaderText = "EmployeeId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn8.HeaderText = "Client";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Employee";
            this.dataGridViewTextBoxColumn10.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(MobiFinanceBank.Model.Models.Loan);
            // 
            // savingAccountDgv
            // 
            this.savingAccountDgv.AutoGenerateColumns = false;
            this.savingAccountDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savingAccountDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn22});
            this.savingAccountDgv.DataSource = this.savingAccountBindingSource;
            this.savingAccountDgv.Location = new System.Drawing.Point(932, 3);
            this.savingAccountDgv.Name = "savingAccountDgv";
            this.savingAccountDgv.RowTemplate.Height = 24;
            this.savingAccountDgv.Size = new System.Drawing.Size(753, 150);
            this.savingAccountDgv.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn13.HeaderText = "Id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn16.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ClientId";
            this.dataGridViewTextBoxColumn17.HeaderText = "ClientId";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn19.HeaderText = "EmployeeId";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn20.HeaderText = "Client";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Employee";
            this.dataGridViewTextBoxColumn22.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // savingAccountBindingSource
            // 
            this.savingAccountBindingSource.DataSource = typeof(MobiFinanceBank.Model.Models.SavingAccount);
            // 
            // bankServicesCb
            // 
            this.bankServicesCb.FormattingEnabled = true;
            this.bankServicesCb.Location = new System.Drawing.Point(1016, 140);
            this.bankServicesCb.Name = "bankServicesCb";
            this.bankServicesCb.Size = new System.Drawing.Size(195, 24);
            this.bankServicesCb.TabIndex = 4;
            this.bankServicesCb.SelectedIndexChanged += new System.EventHandler(this.bankServicesCb_SelectedIndexChanged);
            // 
            // BankServicesOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 559);
            this.Controls.Add(this.bankServicesCb);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BankServicesOverviewForm";
            this.Text = "BankServicesOverviewForm";
            this.Load += new System.EventHandler(this.SavingAndAccountOverviewForm_Load);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.bankServicesCb, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savingAccountDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savingAccountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView accountDgv;
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
        private System.Windows.Forms.DataGridView loanDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridView savingAccountDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.BindingSource savingAccountBindingSource;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private System.Windows.Forms.ComboBox bankServicesCb;
    }
}