namespace MobiFinanceBank.Forms
{
    partial class CreateClientForm
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
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.companyTb = new System.Windows.Forms.TextBox();
            this.oibTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.monthlyIncomeNum = new System.Windows.Forms.NumericUpDown();
            this.contactTb = new System.Windows.Forms.TextBox();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.employedChb = new System.Windows.Forms.CheckBox();
            this.fixedTermContractChb = new System.Windows.Forms.CheckBox();
            this.riskProfessionChb = new System.Windows.Forms.CheckBox();
            this.clientTypeCb = new System.Windows.Forms.ComboBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.oibLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.monthlyIncomeLbl = new System.Windows.Forms.Label();
            this.contactLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.companyLbl = new System.Windows.Forms.Label();
            this.employedLbl = new System.Windows.Forms.Label();
            this.fixedTermContractLbl = new System.Windows.Forms.Label();
            this.riskProfessionLbl = new System.Windows.Forms.Label();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyIncomeNum)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameTb
            // 
            this.lastNameTb.Location = new System.Drawing.Point(2, 26);
            this.lastNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(170, 20);
            this.lastNameTb.TabIndex = 2;
            // 
            // firstNameTb
            // 
            this.firstNameTb.Location = new System.Drawing.Point(2, 2);
            this.firstNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(170, 20);
            this.firstNameTb.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.firstNameTb);
            this.flowLayoutPanel1.Controls.Add(this.lastNameTb);
            this.flowLayoutPanel1.Controls.Add(this.companyTb);
            this.flowLayoutPanel1.Controls.Add(this.oibTb);
            this.flowLayoutPanel1.Controls.Add(this.emailTb);
            this.flowLayoutPanel1.Controls.Add(this.monthlyIncomeNum);
            this.flowLayoutPanel1.Controls.Add(this.contactTb);
            this.flowLayoutPanel1.Controls.Add(this.addressTb);
            this.flowLayoutPanel1.Controls.Add(this.employedChb);
            this.flowLayoutPanel1.Controls.Add(this.fixedTermContractChb);
            this.flowLayoutPanel1.Controls.Add(this.riskProfessionChb);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(180, 137);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(174, 277);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // companyTb
            // 
            this.companyTb.Location = new System.Drawing.Point(2, 50);
            this.companyTb.Margin = new System.Windows.Forms.Padding(2);
            this.companyTb.Name = "companyTb";
            this.companyTb.Size = new System.Drawing.Size(170, 20);
            this.companyTb.TabIndex = 3;
            // 
            // oibTb
            // 
            this.oibTb.Location = new System.Drawing.Point(2, 74);
            this.oibTb.Margin = new System.Windows.Forms.Padding(2);
            this.oibTb.Name = "oibTb";
            this.oibTb.Size = new System.Drawing.Size(170, 20);
            this.oibTb.TabIndex = 4;
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(2, 98);
            this.emailTb.Margin = new System.Windows.Forms.Padding(2);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(170, 20);
            this.emailTb.TabIndex = 5;
            this.emailTb.Enter += new System.EventHandler(this.emailTb_Enter);
            this.emailTb.Leave += new System.EventHandler(this.emailTb_Leave);
            // 
            // monthlyIncomeNum
            // 
            this.monthlyIncomeNum.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.monthlyIncomeNum.Location = new System.Drawing.Point(2, 122);
            this.monthlyIncomeNum.Margin = new System.Windows.Forms.Padding(2);
            this.monthlyIncomeNum.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.monthlyIncomeNum.Name = "monthlyIncomeNum";
            this.monthlyIncomeNum.Size = new System.Drawing.Size(107, 20);
            this.monthlyIncomeNum.TabIndex = 18;
            // 
            // contactTb
            // 
            this.contactTb.Location = new System.Drawing.Point(2, 146);
            this.contactTb.Margin = new System.Windows.Forms.Padding(2);
            this.contactTb.Name = "contactTb";
            this.contactTb.Size = new System.Drawing.Size(170, 20);
            this.contactTb.TabIndex = 7;
            // 
            // addressTb
            // 
            this.addressTb.Location = new System.Drawing.Point(2, 170);
            this.addressTb.Margin = new System.Windows.Forms.Padding(2);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(170, 20);
            this.addressTb.TabIndex = 8;
            // 
            // employedChb
            // 
            this.employedChb.AutoSize = true;
            this.employedChb.Location = new System.Drawing.Point(2, 197);
            this.employedChb.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.employedChb.Name = "employedChb";
            this.employedChb.Size = new System.Drawing.Size(15, 14);
            this.employedChb.TabIndex = 19;
            this.employedChb.UseVisualStyleBackColor = true;
            this.employedChb.CheckedChanged += new System.EventHandler(this.employedChb_CheckedChanged);
            // 
            // fixedTermContractChb
            // 
            this.fixedTermContractChb.AutoSize = true;
            this.fixedTermContractChb.Location = new System.Drawing.Point(2, 229);
            this.fixedTermContractChb.Margin = new System.Windows.Forms.Padding(2, 16, 2, 2);
            this.fixedTermContractChb.Name = "fixedTermContractChb";
            this.fixedTermContractChb.Size = new System.Drawing.Size(15, 14);
            this.fixedTermContractChb.TabIndex = 20;
            this.fixedTermContractChb.UseVisualStyleBackColor = true;
            // 
            // riskProfessionChb
            // 
            this.riskProfessionChb.AutoSize = true;
            this.riskProfessionChb.Location = new System.Drawing.Point(2, 261);
            this.riskProfessionChb.Margin = new System.Windows.Forms.Padding(2, 16, 2, 2);
            this.riskProfessionChb.Name = "riskProfessionChb";
            this.riskProfessionChb.Size = new System.Drawing.Size(15, 14);
            this.riskProfessionChb.TabIndex = 21;
            this.riskProfessionChb.UseVisualStyleBackColor = true;
            // 
            // clientTypeCb
            // 
            this.clientTypeCb.DisplayMember = "ClientType";
            this.clientTypeCb.FormattingEnabled = true;
            this.clientTypeCb.Location = new System.Drawing.Point(401, 136);
            this.clientTypeCb.Margin = new System.Windows.Forms.Padding(2);
            this.clientTypeCb.Name = "clientTypeCb";
            this.clientTypeCb.Size = new System.Drawing.Size(110, 21);
            this.clientTypeCb.TabIndex = 7;
            this.clientTypeCb.ValueMember = "ClientType";
            this.clientTypeCb.SelectedIndexChanged += new System.EventHandler(this.clientTypeCb_SelectedIndexChanged);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(2, 0);
            this.firstNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(28, 15);
            this.firstNameLbl.TabIndex = 8;
            this.firstNameLbl.Text = "Ime";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(2, 24);
            this.lastNameLbl.Margin = new System.Windows.Forms.Padding(2, 9, 2, 0);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(53, 15);
            this.lastNameLbl.TabIndex = 9;
            this.lastNameLbl.Text = "Prezime";
            // 
            // oibLbl
            // 
            this.oibLbl.AutoSize = true;
            this.oibLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oibLbl.Location = new System.Drawing.Point(2, 71);
            this.oibLbl.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.oibLbl.Name = "oibLbl";
            this.oibLbl.Size = new System.Drawing.Size(27, 15);
            this.oibLbl.TabIndex = 10;
            this.oibLbl.Text = "OIB";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(2, 94);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(39, 15);
            this.emailLbl.TabIndex = 11;
            this.emailLbl.Text = "Email";
            // 
            // monthlyIncomeLbl
            // 
            this.monthlyIncomeLbl.AutoSize = true;
            this.monthlyIncomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyIncomeLbl.Location = new System.Drawing.Point(2, 117);
            this.monthlyIncomeLbl.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.monthlyIncomeLbl.Name = "monthlyIncomeLbl";
            this.monthlyIncomeLbl.Size = new System.Drawing.Size(113, 15);
            this.monthlyIncomeLbl.TabIndex = 12;
            this.monthlyIncomeLbl.Text = "Mjesečna primanja";
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLbl.Location = new System.Drawing.Point(2, 140);
            this.contactLbl.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(48, 15);
            this.contactLbl.TabIndex = 13;
            this.contactLbl.Text = "Kontakt";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(2, 163);
            this.addressLbl.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(45, 15);
            this.addressLbl.TabIndex = 14;
            this.addressLbl.Text = "Adresa";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.firstNameLbl);
            this.flowLayoutPanel2.Controls.Add(this.lastNameLbl);
            this.flowLayoutPanel2.Controls.Add(this.companyLbl);
            this.flowLayoutPanel2.Controls.Add(this.oibLbl);
            this.flowLayoutPanel2.Controls.Add(this.emailLbl);
            this.flowLayoutPanel2.Controls.Add(this.monthlyIncomeLbl);
            this.flowLayoutPanel2.Controls.Add(this.contactLbl);
            this.flowLayoutPanel2.Controls.Add(this.addressLbl);
            this.flowLayoutPanel2.Controls.Add(this.employedLbl);
            this.flowLayoutPanel2.Controls.Add(this.fixedTermContractLbl);
            this.flowLayoutPanel2.Controls.Add(this.riskProfessionLbl);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(58, 137);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(118, 280);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // companyLbl
            // 
            this.companyLbl.AutoSize = true;
            this.companyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLbl.Location = new System.Drawing.Point(2, 48);
            this.companyLbl.Margin = new System.Windows.Forms.Padding(2, 9, 2, 0);
            this.companyLbl.Name = "companyLbl";
            this.companyLbl.Size = new System.Drawing.Size(39, 15);
            this.companyLbl.TabIndex = 15;
            this.companyLbl.Text = "Tvrtka";
            // 
            // employedLbl
            // 
            this.employedLbl.AutoSize = true;
            this.employedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employedLbl.Location = new System.Drawing.Point(2, 186);
            this.employedLbl.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.employedLbl.Name = "employedLbl";
            this.employedLbl.Size = new System.Drawing.Size(58, 15);
            this.employedLbl.TabIndex = 16;
            this.employedLbl.Text = "Zaposlen";
            // 
            // fixedTermContractLbl
            // 
            this.fixedTermContractLbl.AutoSize = true;
            this.fixedTermContractLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixedTermContractLbl.Location = new System.Drawing.Point(2, 209);
            this.fixedTermContractLbl.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.fixedTermContractLbl.Name = "fixedTermContractLbl";
            this.fixedTermContractLbl.Size = new System.Drawing.Size(74, 30);
            this.fixedTermContractLbl.TabIndex = 17;
            this.fixedTermContractLbl.Text = "Ugovor na neodređeno";
            // 
            // riskProfessionLbl
            // 
            this.riskProfessionLbl.AutoSize = true;
            this.riskProfessionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riskProfessionLbl.Location = new System.Drawing.Point(2, 247);
            this.riskProfessionLbl.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.riskProfessionLbl.Name = "riskProfessionLbl";
            this.riskProfessionLbl.Size = new System.Drawing.Size(107, 30);
            this.riskProfessionLbl.TabIndex = 18;
            this.riskProfessionLbl.Text = "Financijski rizično zanimanje";
            // 
            // addClientBtn
            // 
            this.addClientBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addClientBtn.Location = new System.Drawing.Point(401, 162);
            this.addClientBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(109, 28);
            this.addClientBtn.TabIndex = 17;
            this.addClientBtn.Text = "Stvori klijenta";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MobiFinanceBank.Properties.Resources.clienthelper;
            this.pictureBox3.Location = new System.Drawing.Point(639, 139);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(369, 280);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // CreateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 518);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.addClientBtn);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.clientTypeCb);
            this.Controls.Add(this.flowLayoutPanel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "CreateClientForm";
            this.Text = "CreateClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateClientForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateClient_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateClientForm_KeyDown);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.clientTypeCb, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.addClientBtn, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyIncomeNum)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox oibTb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.TextBox contactTb;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.ComboBox clientTypeCb;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label oibLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label monthlyIncomeLbl;
        private System.Windows.Forms.Label contactLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox companyTb;
        private System.Windows.Forms.Label companyLbl;
        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.NumericUpDown monthlyIncomeNum;
        private System.Windows.Forms.Label employedLbl;
        private System.Windows.Forms.Label fixedTermContractLbl;
        private System.Windows.Forms.Label riskProfessionLbl;
        private System.Windows.Forms.CheckBox employedChb;
        private System.Windows.Forms.CheckBox fixedTermContractChb;
        private System.Windows.Forms.CheckBox riskProfessionChb;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}