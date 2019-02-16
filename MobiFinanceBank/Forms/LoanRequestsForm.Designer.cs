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
            this.loanRequestsDgv = new System.Windows.Forms.DataGridView();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.loanRequestsDgv.Location = new System.Drawing.Point(12, 152);
            this.loanRequestsDgv.Name = "loanRequestsDgv";
            this.loanRequestsDgv.RowTemplate.Height = 24;
            this.loanRequestsDgv.Size = new System.Drawing.Size(856, 263);
            this.loanRequestsDgv.TabIndex = 3;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(MobiFinanceBank.Model.Models.Loan);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // loanStartDateDataGridViewTextBoxColumn
            // 
            this.loanStartDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loanStartDateDataGridViewTextBoxColumn.DataPropertyName = "LoanStartDate";
            this.loanStartDateDataGridViewTextBoxColumn.HeaderText = "LoanStartDate";
            this.loanStartDateDataGridViewTextBoxColumn.Name = "loanStartDateDataGridViewTextBoxColumn";
            this.loanStartDateDataGridViewTextBoxColumn.Width = 129;
            // 
            // loanEndDateDataGridViewTextBoxColumn
            // 
            this.loanEndDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loanEndDateDataGridViewTextBoxColumn.DataPropertyName = "LoanEndDate";
            this.loanEndDateDataGridViewTextBoxColumn.HeaderText = "LoanEndDate";
            this.loanEndDateDataGridViewTextBoxColumn.Name = "loanEndDateDataGridViewTextBoxColumn";
            this.loanEndDateDataGridViewTextBoxColumn.Width = 124;
            // 
            // loanDurationDataGridViewTextBoxColumn
            // 
            this.loanDurationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loanDurationDataGridViewTextBoxColumn.DataPropertyName = "LoanDuration";
            this.loanDurationDataGridViewTextBoxColumn.HeaderText = "LoanDuration";
            this.loanDurationDataGridViewTextBoxColumn.Name = "loanDurationDataGridViewTextBoxColumn";
            this.loanDurationDataGridViewTextBoxColumn.Width = 123;
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            this.capitalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.capitalDataGridViewTextBoxColumn.DataPropertyName = "Capital";
            this.capitalDataGridViewTextBoxColumn.HeaderText = "Capital";
            this.capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            this.capitalDataGridViewTextBoxColumn.Width = 80;
            // 
            // isStandingOrderActiveDataGridViewCheckBoxColumn
            // 
            this.isStandingOrderActiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isStandingOrderActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsStandingOrderActive";
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
            // LoanRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 480);
            this.Controls.Add(this.loanRequestsDgv);
            this.Name = "LoanRequestsForm";
            this.Text = "LoanRequestsForm";
            this.Controls.SetChildIndex(this.loanRequestsDgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.loanRequestsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView loanRequestsDgv;
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
        private System.Windows.Forms.BindingSource loanBindingSource;
    }
}