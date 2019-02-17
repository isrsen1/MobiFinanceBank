namespace MobiFinanceBank.Templates
{
    partial class TemplateForm
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
            this.exitPb = new System.Windows.Forms.PictureBox();
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.appNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitPb
            // 
            this.exitPb.Image = global::MobiFinanceBank.Properties.Resources.exit;
            this.exitPb.Location = new System.Drawing.Point(1305, 3);
            this.exitPb.Name = "exitPb";
            this.exitPb.Size = new System.Drawing.Size(80, 53);
            this.exitPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPb.TabIndex = 1;
            this.exitPb.TabStop = false;
            this.exitPb.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // logoPb
            // 
            this.logoPb.Image = global::MobiFinanceBank.Properties.Resources.logo;
            this.logoPb.Location = new System.Drawing.Point(-2, -2);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(123, 96);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPb.TabIndex = 0;
            this.logoPb.TabStop = false;
            // 
            // titlePanel
            // 
            this.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titlePanel.Controls.Add(this.exitPb);
            this.titlePanel.Controls.Add(this.appNameLbl);
            this.titlePanel.Controls.Add(this.logoPb);
            this.titlePanel.Location = new System.Drawing.Point(12, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1392, 96);
            this.titlePanel.TabIndex = 2;
            // 
            // appNameLbl
            // 
            this.appNameLbl.AutoSize = true;
            this.appNameLbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLbl.Location = new System.Drawing.Point(619, 18);
            this.appNameLbl.Name = "appNameLbl";
            this.appNameLbl.Size = new System.Drawing.Size(281, 50);
            this.appNameLbl.TabIndex = 0;
            this.appNameLbl.Text = "Mobi Finance";
            this.appNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1417, 638);
            this.Controls.Add(this.titlePanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TemplateForm";
            ((System.ComponentModel.ISupportInitialize)(this.exitPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.PictureBox exitPb;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label appNameLbl;
    }
}