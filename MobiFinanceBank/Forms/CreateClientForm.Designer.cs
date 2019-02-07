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
            this.contactTb = new System.Windows.Forms.TextBox();
            this.addressTb = new System.Windows.Forms.TextBox();
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
            this.addClientBtn = new System.Windows.Forms.Button();
            this.monthlyIncomeNum = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyIncomeNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameTb
            // 
            this.lastNameTb.Location = new System.Drawing.Point(3, 31);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(226, 22);
            this.lastNameTb.TabIndex = 2;
            // 
            // firstNameTb
            // 
            this.firstNameTb.Location = new System.Drawing.Point(3, 3);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(226, 22);
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
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(175, 169);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 224);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // companyTb
            // 
            this.companyTb.Location = new System.Drawing.Point(3, 59);
            this.companyTb.Name = "companyTb";
            this.companyTb.Size = new System.Drawing.Size(226, 22);
            this.companyTb.TabIndex = 3;
            // 
            // oibTb
            // 
            this.oibTb.Location = new System.Drawing.Point(3, 87);
            this.oibTb.Name = "oibTb";
            this.oibTb.Size = new System.Drawing.Size(226, 22);
            this.oibTb.TabIndex = 4;
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(3, 115);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(226, 22);
            this.emailTb.TabIndex = 5;
            this.emailTb.Enter += new System.EventHandler(this.emailTb_Enter);
            this.emailTb.Leave += new System.EventHandler(this.emailTb_Leave);
            // 
            // contactTb
            // 
            this.contactTb.Location = new System.Drawing.Point(3, 171);
            this.contactTb.Name = "contactTb";
            this.contactTb.Size = new System.Drawing.Size(226, 22);
            this.contactTb.TabIndex = 7;
            // 
            // addressTb
            // 
            this.addressTb.Location = new System.Drawing.Point(3, 199);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(226, 22);
            this.addressTb.TabIndex = 8;
            // 
            // clientTypeCb
            // 
            this.clientTypeCb.DisplayMember = "ClientType";
            this.clientTypeCb.FormattingEnabled = true;
            this.clientTypeCb.Location = new System.Drawing.Point(469, 169);
            this.clientTypeCb.Name = "clientTypeCb";
            this.clientTypeCb.Size = new System.Drawing.Size(145, 24);
            this.clientTypeCb.TabIndex = 7;
            this.clientTypeCb.ValueMember = "ClientType";
            this.clientTypeCb.SelectedIndexChanged += new System.EventHandler(this.clientTypeCb_SelectedIndexChanged);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(3, 0);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(32, 18);
            this.firstNameLbl.TabIndex = 8;
            this.firstNameLbl.Text = "Ime";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(3, 29);
            this.lastNameLbl.Margin = new System.Windows.Forms.Padding(3, 11, 3, 0);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(63, 18);
            this.lastNameLbl.TabIndex = 9;
            this.lastNameLbl.Text = "Prezime";
            // 
            // oibLbl
            // 
            this.oibLbl.AutoSize = true;
            this.oibLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oibLbl.Location = new System.Drawing.Point(3, 86);
            this.oibLbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.oibLbl.Name = "oibLbl";
            this.oibLbl.Size = new System.Drawing.Size(33, 18);
            this.oibLbl.TabIndex = 10;
            this.oibLbl.Text = "OIB";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(3, 114);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(45, 18);
            this.emailLbl.TabIndex = 11;
            this.emailLbl.Text = "Email";
            // 
            // monthlyIncomeLbl
            // 
            this.monthlyIncomeLbl.AutoSize = true;
            this.monthlyIncomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyIncomeLbl.Location = new System.Drawing.Point(3, 142);
            this.monthlyIncomeLbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.monthlyIncomeLbl.Name = "monthlyIncomeLbl";
            this.monthlyIncomeLbl.Size = new System.Drawing.Size(132, 18);
            this.monthlyIncomeLbl.TabIndex = 12;
            this.monthlyIncomeLbl.Text = "Mjesečna primanja";
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLbl.Location = new System.Drawing.Point(3, 170);
            this.contactLbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(59, 18);
            this.contactLbl.TabIndex = 13;
            this.contactLbl.Text = "Kontakt";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(3, 198);
            this.addressLbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(54, 18);
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
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 169);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(157, 221);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // companyLbl
            // 
            this.companyLbl.AutoSize = true;
            this.companyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLbl.Location = new System.Drawing.Point(3, 58);
            this.companyLbl.Margin = new System.Windows.Forms.Padding(3, 11, 3, 0);
            this.companyLbl.Name = "companyLbl";
            this.companyLbl.Size = new System.Drawing.Size(49, 18);
            this.companyLbl.TabIndex = 15;
            this.companyLbl.Text = "Tvrtka";
            // 
            // addClientBtn
            // 
            this.addClientBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addClientBtn.Location = new System.Drawing.Point(469, 200);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(145, 34);
            this.addClientBtn.TabIndex = 17;
            this.addClientBtn.Text = "Stvori klijenta";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // monthlyIncomeNum
            // 
            this.monthlyIncomeNum.Location = new System.Drawing.Point(3, 143);
            this.monthlyIncomeNum.Name = "monthlyIncomeNum";
            this.monthlyIncomeNum.Size = new System.Drawing.Size(143, 22);
            this.monthlyIncomeNum.TabIndex = 18;
            // 
            // CreateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 638);
            this.Controls.Add(this.addClientBtn);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.clientTypeCb);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CreateClientForm";
            this.Text = "CreateClientForm";
            this.Load += new System.EventHandler(this.CreateClient_Load);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.clientTypeCb, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.addClientBtn, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyIncomeNum)).EndInit();
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
    }
}