using System;
using System.Threading;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Templates;

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Login form
    /// </summary>
    /// <seealso cref="TemplateForm"/>
    public partial class LoginForm : TemplateForm
    {
        private IMenuForm menuForm;

        /// <summary>
        /// Initializes new instance of login form
        /// </summary>
        /// <param name="_menuForm">Menu form</param>
        public LoginForm(IMenuForm _menuForm)
        {
            InitializeComponent();
            this.menuForm = _menuForm;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.menuForm.Show();
        }
    }
}
