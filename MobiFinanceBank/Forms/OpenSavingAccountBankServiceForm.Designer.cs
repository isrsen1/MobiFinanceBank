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
            this.openSavingAccountBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capitalNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // capitalLbl
            // 
            this.capitalLbl.AutoSize = true;
            this.capitalLbl.Location = new System.Drawing.Point(22, 134);
            this.capitalLbl.Name = "capitalLbl";
            this.capitalLbl.Size = new System.Drawing.Size(63, 17);
            this.capitalLbl.TabIndex = 3;
            this.capitalLbl.Text = "Glavnica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum početka";
            // 
            // standingOrderLbl
            // 
            this.standingOrderLbl.AutoSize = true;
            this.standingOrderLbl.Location = new System.Drawing.Point(22, 317);
            this.standingOrderLbl.Name = "standingOrderLbl";
            this.standingOrderLbl.Size = new System.Drawing.Size(83, 17);
            this.standingOrderLbl.TabIndex = 5;
            this.standingOrderLbl.Text = "Trajni nalog";
            // 
            // startDateDtp
            // 
            this.startDateDtp.Location = new System.Drawing.Point(170, 269);
            this.startDateDtp.Name = "startDateDtp";
            this.startDateDtp.Size = new System.Drawing.Size(200, 22);
            this.startDateDtp.TabIndex = 13;
            // 
            // standingOrderChb
            // 
            this.standingOrderChb.AutoSize = true;
            this.standingOrderChb.Location = new System.Drawing.Point(170, 318);
            this.standingOrderChb.Name = "standingOrderChb";
            this.standingOrderChb.Size = new System.Drawing.Size(18, 17);
            this.standingOrderChb.TabIndex = 14;
            this.standingOrderChb.UseVisualStyleBackColor = true;
            this.standingOrderChb.CheckedChanged += new System.EventHandler(this.standingOrderChb_CheckedChanged);
            // 
            // capitalNum
            // 
            this.capitalNum.Location = new System.Drawing.Point(170, 134);
            this.capitalNum.Name = "capitalNum";
            this.capitalNum.Size = new System.Drawing.Size(120, 22);
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
            this.accountsDgv.Location = new System.Drawing.Point(602, 134);
            this.accountsDgv.Name = "accountsDgv";
            this.accountsDgv.RowTemplate.Height = 24;
            this.accountsDgv.Size = new System.Drawing.Size(581, 277);
            this.accountsDgv.TabIndex = 16;
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
            // openSavingAccountBtn
            // 
            this.openSavingAccountBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openSavingAccountBtn.Location = new System.Drawing.Point(264, 375);
            this.openSavingAccountBtn.Name = "openSavingAccountBtn";
            this.openSavingAccountBtn.Size = new System.Drawing.Size(106, 36);
            this.openSavingAccountBtn.TabIndex = 17;
            this.openSavingAccountBtn.Text = "Otvori štednju";
            this.openSavingAccountBtn.UseVisualStyleBackColor = true;
            this.openSavingAccountBtn.Click += new System.EventHandler(this.openSavingAccountBtn_Click);
            // 
            // OpenSavingAccountBankServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 638);
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
    }
}