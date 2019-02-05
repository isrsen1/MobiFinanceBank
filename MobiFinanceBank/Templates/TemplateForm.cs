using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
