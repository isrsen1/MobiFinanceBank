namespace MobiFinanceBank.Forms
{
    partial class MenuForm
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
            this.btnPregledKlijenata = new System.Windows.Forms.Button();
            this.btnMjenjacnica = new System.Windows.Forms.Button();
            this.btnOtvaranjeUsluga = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPregledKlijenata
            // 
            this.btnPregledKlijenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledKlijenata.ForeColor = System.Drawing.Color.Black;
            this.btnPregledKlijenata.Image = global::MobiFinanceBank.Properties.Resources.search;
            this.btnPregledKlijenata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPregledKlijenata.Location = new System.Drawing.Point(352, 162);
            this.btnPregledKlijenata.Name = "btnPregledKlijenata";
            this.btnPregledKlijenata.Size = new System.Drawing.Size(216, 82);
            this.btnPregledKlijenata.TabIndex = 5;
            this.btnPregledKlijenata.Text = "Pregled klijenata";
            this.btnPregledKlijenata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPregledKlijenata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPregledKlijenata.UseVisualStyleBackColor = true;
            this.btnPregledKlijenata.Click += new System.EventHandler(this.btnPregledKlijenata_Click);
            // 
            // btnMjenjacnica
            // 
            this.btnMjenjacnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMjenjacnica.ForeColor = System.Drawing.Color.Black;
            this.btnMjenjacnica.Image = global::MobiFinanceBank.Properties.Resources.exchange;
            this.btnMjenjacnica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMjenjacnica.Location = new System.Drawing.Point(352, 311);
            this.btnMjenjacnica.Name = "btnMjenjacnica";
            this.btnMjenjacnica.Size = new System.Drawing.Size(216, 82);
            this.btnMjenjacnica.TabIndex = 6;
            this.btnMjenjacnica.Text = "Mjenjačnica";
            this.btnMjenjacnica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMjenjacnica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMjenjacnica.UseVisualStyleBackColor = true;
            this.btnMjenjacnica.Click += new System.EventHandler(this.btnMjenjacnica_Click);
            // 
            // btnOtvaranjeUsluga
            // 
            this.btnOtvaranjeUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtvaranjeUsluga.ForeColor = System.Drawing.Color.Black;
            this.btnOtvaranjeUsluga.Image = global::MobiFinanceBank.Properties.Resources.ugovaranje;
            this.btnOtvaranjeUsluga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtvaranjeUsluga.Location = new System.Drawing.Point(900, 311);
            this.btnOtvaranjeUsluga.Name = "btnOtvaranjeUsluga";
            this.btnOtvaranjeUsluga.Size = new System.Drawing.Size(222, 82);
            this.btnOtvaranjeUsluga.TabIndex = 13;
            this.btnOtvaranjeUsluga.Text = "Otvaranje računa";
            this.btnOtvaranjeUsluga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOtvaranjeUsluga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOtvaranjeUsluga.UseVisualStyleBackColor = true;
            this.btnOtvaranjeUsluga.Click += new System.EventHandler(this.btnOtvaranjeUsluga_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposlenici.ForeColor = System.Drawing.Color.Black;
            this.btnZaposlenici.Image = global::MobiFinanceBank.Properties.Resources.emp1;
            this.btnZaposlenici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZaposlenici.Location = new System.Drawing.Point(900, 162);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(222, 82);
            this.btnZaposlenici.TabIndex = 12;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZaposlenici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 638);
            this.Controls.Add(this.btnOtvaranjeUsluga);
            this.Controls.Add(this.btnZaposlenici);
            this.Controls.Add(this.btnMjenjacnica);
            this.Controls.Add(this.btnPregledKlijenata);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Controls.SetChildIndex(this.btnPregledKlijenata, 0);
            this.Controls.SetChildIndex(this.btnMjenjacnica, 0);
            this.Controls.SetChildIndex(this.btnZaposlenici, 0);
            this.Controls.SetChildIndex(this.btnOtvaranjeUsluga, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPregledKlijenata;
        private System.Windows.Forms.Button btnMjenjacnica;
        private System.Windows.Forms.Button btnOtvaranjeUsluga;
        private System.Windows.Forms.Button btnZaposlenici;
    }
}