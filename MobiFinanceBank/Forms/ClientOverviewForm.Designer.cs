namespace MobiFinanceBank.Forms
{
    partial class ClientOverviewForm
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
            this.clientOverviewDgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceSheetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingAccountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTypeCb = new System.Windows.Forms.ComboBox();
            this.bankServicesOverviewBtn = new System.Windows.Forms.Button();
            this.openingBankServicesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientOverviewDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientOverviewDgv
            // 
            this.clientOverviewDgv.AutoGenerateColumns = false;
            this.clientOverviewDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientOverviewDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.clientTypeIdDataGridViewTextBoxColumn,
            this.balanceSheetsDataGridViewTextBoxColumn,
            this.loansDataGridViewTextBoxColumn,
            this.accountsDataGridViewTextBoxColumn,
            this.savingAccountsDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn});
            this.clientOverviewDgv.DataSource = this.clientBindingSource;
            this.clientOverviewDgv.Location = new System.Drawing.Point(12, 114);
            this.clientOverviewDgv.MultiSelect = false;
            this.clientOverviewDgv.Name = "clientOverviewDgv";
            this.clientOverviewDgv.RowTemplate.Height = 24;
            this.clientOverviewDgv.Size = new System.Drawing.Size(952, 320);
            this.clientOverviewDgv.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.firstNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.lastNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.companyNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.oIBDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.phoneNumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.incomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Income";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.addressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // clientTypeIdDataGridViewTextBoxColumn
            // 
            this.clientTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ClientTypeId";
            this.clientTypeIdDataGridViewTextBoxColumn.HeaderText = "ClientTypeId";
            this.clientTypeIdDataGridViewTextBoxColumn.Name = "clientTypeIdDataGridViewTextBoxColumn";
            this.clientTypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // balanceSheetsDataGridViewTextBoxColumn
            // 
            this.balanceSheetsDataGridViewTextBoxColumn.DataPropertyName = "BalanceSheets";
            this.balanceSheetsDataGridViewTextBoxColumn.HeaderText = "BalanceSheets";
            this.balanceSheetsDataGridViewTextBoxColumn.Name = "balanceSheetsDataGridViewTextBoxColumn";
            this.balanceSheetsDataGridViewTextBoxColumn.Visible = false;
            // 
            // loansDataGridViewTextBoxColumn
            // 
            this.loansDataGridViewTextBoxColumn.DataPropertyName = "Loans";
            this.loansDataGridViewTextBoxColumn.HeaderText = "Loans";
            this.loansDataGridViewTextBoxColumn.Name = "loansDataGridViewTextBoxColumn";
            this.loansDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountsDataGridViewTextBoxColumn
            // 
            this.accountsDataGridViewTextBoxColumn.DataPropertyName = "Accounts";
            this.accountsDataGridViewTextBoxColumn.HeaderText = "Accounts";
            this.accountsDataGridViewTextBoxColumn.Name = "accountsDataGridViewTextBoxColumn";
            this.accountsDataGridViewTextBoxColumn.Visible = false;
            // 
            // savingAccountsDataGridViewTextBoxColumn
            // 
            this.savingAccountsDataGridViewTextBoxColumn.DataPropertyName = "SavingAccounts";
            this.savingAccountsDataGridViewTextBoxColumn.HeaderText = "SavingAccounts";
            this.savingAccountsDataGridViewTextBoxColumn.Name = "savingAccountsDataGridViewTextBoxColumn";
            this.savingAccountsDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            this.clientTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(MobiFinanceBank.Model.Models.Client);
            // 
            // clientTypeCb
            // 
            this.clientTypeCb.FormattingEnabled = true;
            this.clientTypeCb.Location = new System.Drawing.Point(970, 114);
            this.clientTypeCb.Name = "clientTypeCb";
            this.clientTypeCb.Size = new System.Drawing.Size(246, 24);
            this.clientTypeCb.TabIndex = 4;
            this.clientTypeCb.SelectedIndexChanged += new System.EventHandler(this.clientTypeCb_SelectedIndexChanged);
            // 
            // bankServicesOverviewBtn
            // 
            this.bankServicesOverviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankServicesOverviewBtn.ForeColor = System.Drawing.Color.Black;
            this.bankServicesOverviewBtn.Image = global::MobiFinanceBank.Properties.Resources.ugovaranje;
            this.bankServicesOverviewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bankServicesOverviewBtn.Location = new System.Drawing.Point(970, 300);
            this.bankServicesOverviewBtn.Name = "bankServicesOverviewBtn";
            this.bankServicesOverviewBtn.Size = new System.Drawing.Size(241, 64);
            this.bankServicesOverviewBtn.TabIndex = 14;
            this.bankServicesOverviewBtn.Text = "Pregled usluga";
            this.bankServicesOverviewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bankServicesOverviewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bankServicesOverviewBtn.UseVisualStyleBackColor = true;
            this.bankServicesOverviewBtn.Click += new System.EventHandler(this.bankServicesOverview_Click);
            // 
            // openingBankServicesBtn
            // 
            this.openingBankServicesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openingBankServicesBtn.ForeColor = System.Drawing.Color.Black;
            this.openingBankServicesBtn.Image = global::MobiFinanceBank.Properties.Resources.ugovaranje;
            this.openingBankServicesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openingBankServicesBtn.Location = new System.Drawing.Point(970, 370);
            this.openingBankServicesBtn.Name = "openingBankServicesBtn";
            this.openingBankServicesBtn.Size = new System.Drawing.Size(241, 64);
            this.openingBankServicesBtn.TabIndex = 15;
            this.openingBankServicesBtn.Text = "Otvaranje usluga";
            this.openingBankServicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openingBankServicesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.openingBankServicesBtn.UseVisualStyleBackColor = true;
            this.openingBankServicesBtn.Click += new System.EventHandler(this.openingBankServicesBtn_Click);
            // 
            // ClientOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 503);
            this.Controls.Add(this.openingBankServicesBtn);
            this.Controls.Add(this.bankServicesOverviewBtn);
            this.Controls.Add(this.clientTypeCb);
            this.Controls.Add(this.clientOverviewDgv);
            this.Name = "ClientOverviewForm";
            this.Text = "ClientOverviewForm";
            this.Load += new System.EventHandler(this.ClientOverview_Load);
            this.Controls.SetChildIndex(this.clientOverviewDgv, 0);
            this.Controls.SetChildIndex(this.clientTypeCb, 0);
            this.Controls.SetChildIndex(this.bankServicesOverviewBtn, 0);
            this.Controls.SetChildIndex(this.openingBankServicesBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.clientOverviewDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientOverviewDgv;
        private System.Windows.Forms.ComboBox clientTypeCb;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceSheetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savingAccountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bankServicesOverviewBtn;
        private System.Windows.Forms.Button openingBankServicesBtn;
    }
}