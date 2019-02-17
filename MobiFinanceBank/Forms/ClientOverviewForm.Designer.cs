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
            this.isEmployedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isFixedTermContractDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isUnusualProfessionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingAccountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTypeCb = new System.Windows.Forms.ComboBox();
            this.bankServicesOverviewBtn = new System.Windows.Forms.Button();
            this.openingBankServicesBtn = new System.Windows.Forms.Button();
            this.clientTypeLbl = new System.Windows.Forms.Label();
            this.filterLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.firstNameFilterLbl = new System.Windows.Forms.Label();
            this.firstNameFilterTb = new System.Windows.Forms.TextBox();
            this.lastNameFilterLbl = new System.Windows.Forms.Label();
            this.lastNameFilterTb = new System.Windows.Forms.TextBox();
            this.companyFilterLb = new System.Windows.Forms.Label();
            this.companyFilterTb = new System.Windows.Forms.TextBox();
            this.applyFilterBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.editClientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientOverviewDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.isEmployedDataGridViewCheckBoxColumn,
            this.isFixedTermContractDataGridViewCheckBoxColumn,
            this.isUnusualProfessionDataGridViewCheckBoxColumn,
            this.clientTypeIdDataGridViewTextBoxColumn,
            this.loansDataGridViewTextBoxColumn,
            this.accountsDataGridViewTextBoxColumn,
            this.savingAccountsDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn});
            this.clientOverviewDgv.DataSource = this.clientBindingSource;
            this.clientOverviewDgv.Location = new System.Drawing.Point(12, 178);
            this.clientOverviewDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // isEmployedDataGridViewCheckBoxColumn
            // 
            this.isEmployedDataGridViewCheckBoxColumn.DataPropertyName = "IsEmployed";
            this.isEmployedDataGridViewCheckBoxColumn.HeaderText = "IsEmployed";
            this.isEmployedDataGridViewCheckBoxColumn.Name = "isEmployedDataGridViewCheckBoxColumn";
            // 
            // isFixedTermContractDataGridViewCheckBoxColumn
            // 
            this.isFixedTermContractDataGridViewCheckBoxColumn.DataPropertyName = "IsFixedTermContract";
            this.isFixedTermContractDataGridViewCheckBoxColumn.HeaderText = "IsFixedTermContract";
            this.isFixedTermContractDataGridViewCheckBoxColumn.Name = "isFixedTermContractDataGridViewCheckBoxColumn";
            // 
            // isUnusualProfessionDataGridViewCheckBoxColumn
            // 
            this.isUnusualProfessionDataGridViewCheckBoxColumn.DataPropertyName = "IsUnusualProfession";
            this.isUnusualProfessionDataGridViewCheckBoxColumn.HeaderText = "IsUnusualProfession";
            this.isUnusualProfessionDataGridViewCheckBoxColumn.Name = "isUnusualProfessionDataGridViewCheckBoxColumn";
            // 
            // clientTypeIdDataGridViewTextBoxColumn
            // 
            this.clientTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ClientTypeId";
            this.clientTypeIdDataGridViewTextBoxColumn.HeaderText = "ClientTypeId";
            this.clientTypeIdDataGridViewTextBoxColumn.Name = "clientTypeIdDataGridViewTextBoxColumn";
            this.clientTypeIdDataGridViewTextBoxColumn.Visible = false;
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
            this.clientTypeCb.Location = new System.Drawing.Point(1029, 193);
            this.clientTypeCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientTypeCb.Name = "clientTypeCb";
            this.clientTypeCb.Size = new System.Drawing.Size(247, 24);
            this.clientTypeCb.TabIndex = 4;
            this.clientTypeCb.SelectedIndexChanged += new System.EventHandler(this.clientTypeCb_SelectedIndexChanged);
            // 
            // bankServicesOverviewBtn
            // 
            this.bankServicesOverviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankServicesOverviewBtn.ForeColor = System.Drawing.Color.Black;
            this.bankServicesOverviewBtn.Image = global::MobiFinanceBank.Properties.Resources.ugovaranje;
            this.bankServicesOverviewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bankServicesOverviewBtn.Location = new System.Drawing.Point(1028, 434);
            this.bankServicesOverviewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bankServicesOverviewBtn.Name = "bankServicesOverviewBtn";
            this.bankServicesOverviewBtn.Size = new System.Drawing.Size(332, 64);
            this.bankServicesOverviewBtn.TabIndex = 14;
            this.bankServicesOverviewBtn.Text = "Pregled postojećih usluga";
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
            this.openingBankServicesBtn.Location = new System.Drawing.Point(1028, 502);
            this.openingBankServicesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openingBankServicesBtn.Name = "openingBankServicesBtn";
            this.openingBankServicesBtn.Size = new System.Drawing.Size(332, 64);
            this.openingBankServicesBtn.TabIndex = 15;
            this.openingBankServicesBtn.Text = "Otvaranje novih usluga";
            this.openingBankServicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openingBankServicesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.openingBankServicesBtn.UseVisualStyleBackColor = true;
            this.openingBankServicesBtn.Click += new System.EventHandler(this.openingBankServicesBtn_Click);
            // 
            // clientTypeLbl
            // 
            this.clientTypeLbl.AutoSize = true;
            this.clientTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientTypeLbl.Location = new System.Drawing.Point(1025, 171);
            this.clientTypeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientTypeLbl.Name = "clientTypeLbl";
            this.clientTypeLbl.Size = new System.Drawing.Size(132, 18);
            this.clientTypeLbl.TabIndex = 16;
            this.clientTypeLbl.Text = "Odaberi tip klijenta:";
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.Location = new System.Drawing.Point(1024, 129);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(68, 29);
            this.filterLbl.TabIndex = 17;
            this.filterLbl.Text = "Filter";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.firstNameFilterLbl);
            this.flowLayoutPanel1.Controls.Add(this.firstNameFilterTb);
            this.flowLayoutPanel1.Controls.Add(this.lastNameFilterLbl);
            this.flowLayoutPanel1.Controls.Add(this.lastNameFilterTb);
            this.flowLayoutPanel1.Controls.Add(this.companyFilterLb);
            this.flowLayoutPanel1.Controls.Add(this.companyFilterTb);
            this.flowLayoutPanel1.Controls.Add(this.applyFilterBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1029, 222);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 178);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // firstNameFilterLbl
            // 
            this.firstNameFilterLbl.AutoSize = true;
            this.firstNameFilterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameFilterLbl.Location = new System.Drawing.Point(3, 0);
            this.firstNameFilterLbl.Name = "firstNameFilterLbl";
            this.firstNameFilterLbl.Size = new System.Drawing.Size(36, 18);
            this.firstNameFilterLbl.TabIndex = 0;
            this.firstNameFilterLbl.Text = "Ime:";
            // 
            // firstNameFilterTb
            // 
            this.firstNameFilterTb.Location = new System.Drawing.Point(3, 20);
            this.firstNameFilterTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameFilterTb.Name = "firstNameFilterTb";
            this.firstNameFilterTb.Size = new System.Drawing.Size(172, 22);
            this.firstNameFilterTb.TabIndex = 1;
            // 
            // lastNameFilterLbl
            // 
            this.lastNameFilterLbl.AutoSize = true;
            this.lastNameFilterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameFilterLbl.Location = new System.Drawing.Point(3, 44);
            this.lastNameFilterLbl.Name = "lastNameFilterLbl";
            this.lastNameFilterLbl.Size = new System.Drawing.Size(67, 18);
            this.lastNameFilterLbl.TabIndex = 2;
            this.lastNameFilterLbl.Text = "Prezime:";
            // 
            // lastNameFilterTb
            // 
            this.lastNameFilterTb.Location = new System.Drawing.Point(3, 64);
            this.lastNameFilterTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameFilterTb.Name = "lastNameFilterTb";
            this.lastNameFilterTb.Size = new System.Drawing.Size(172, 22);
            this.lastNameFilterTb.TabIndex = 3;
            // 
            // companyFilterLb
            // 
            this.companyFilterLb.AutoSize = true;
            this.companyFilterLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyFilterLb.Location = new System.Drawing.Point(3, 88);
            this.companyFilterLb.Name = "companyFilterLb";
            this.companyFilterLb.Size = new System.Drawing.Size(53, 18);
            this.companyFilterLb.TabIndex = 4;
            this.companyFilterLb.Text = "Tvrtka:";
            // 
            // companyFilterTb
            // 
            this.companyFilterTb.Location = new System.Drawing.Point(3, 108);
            this.companyFilterTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.companyFilterTb.Name = "companyFilterTb";
            this.companyFilterTb.Size = new System.Drawing.Size(172, 22);
            this.companyFilterTb.TabIndex = 5;
            // 
            // applyFilterBtn
            // 
            this.applyFilterBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.applyFilterBtn.Location = new System.Drawing.Point(3, 134);
            this.applyFilterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyFilterBtn.Name = "applyFilterBtn";
            this.applyFilterBtn.Size = new System.Drawing.Size(75, 27);
            this.applyFilterBtn.TabIndex = 6;
            this.applyFilterBtn.Text = "Primijeni";
            this.applyFilterBtn.UseVisualStyleBackColor = true;
            this.applyFilterBtn.Click += new System.EventHandler(this.applyFilterBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MobiFinanceBank.Properties.Resources.home1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 114);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // editClientButton
            // 
            this.editClientButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editClientButton.Location = new System.Drawing.Point(797, 532);
            this.editClientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(116, 38);
            this.editClientButton.TabIndex = 20;
            this.editClientButton.Text = "Ažuriraj klijenta";
            this.editClientButton.UseVisualStyleBackColor = true;
            this.editClientButton.Click += new System.EventHandler(this.editClientButton_Click);
            // 
            // ClientOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 638);
            this.Controls.Add(this.editClientButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.clientTypeLbl);
            this.Controls.Add(this.openingBankServicesBtn);
            this.Controls.Add(this.bankServicesOverviewBtn);
            this.Controls.Add(this.clientTypeCb);
            this.Controls.Add(this.clientOverviewDgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientOverviewForm";
            this.Text = "ClientOverviewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientOverviewForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientOverview_Load);
            this.Controls.SetChildIndex(this.clientOverviewDgv, 0);
            this.Controls.SetChildIndex(this.clientTypeCb, 0);
            this.Controls.SetChildIndex(this.bankServicesOverviewBtn, 0);
            this.Controls.SetChildIndex(this.openingBankServicesBtn, 0);
            this.Controls.SetChildIndex(this.clientTypeLbl, 0);
            this.Controls.SetChildIndex(this.filterLbl, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.editClientButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.clientOverviewDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientOverviewDgv;
        private System.Windows.Forms.ComboBox clientTypeCb;
        private System.Windows.Forms.Button bankServicesOverviewBtn;
        private System.Windows.Forms.Button openingBankServicesBtn;
        private System.Windows.Forms.Label clientTypeLbl;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label firstNameFilterLbl;
        private System.Windows.Forms.TextBox firstNameFilterTb;
        private System.Windows.Forms.Label lastNameFilterLbl;
        private System.Windows.Forms.Label companyFilterLb;
        private System.Windows.Forms.TextBox companyFilterTb;
        private System.Windows.Forms.Button applyFilterBtn;
        private System.Windows.Forms.TextBox lastNameFilterTb;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEmployedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFixedTermContractDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isUnusualProfessionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceSheetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savingAccountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Button editClientButton;
    }
}