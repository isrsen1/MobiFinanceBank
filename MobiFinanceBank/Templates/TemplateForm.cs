using System;
using System.Windows.Forms;

namespace MobiFinanceBank.Templates
{
    /// <summary>
    /// Template form
    /// </summary>
    /// <seealso cref="Form"/>
    public partial class TemplateForm : Form
    {
        /// <summary>
        /// Initializes new instance of template form
        /// </summary>
        public TemplateForm()
        {
            InitializeComponent();
        }

        // On red cross click
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Close modal
            this.Close();
        }
    }
}
