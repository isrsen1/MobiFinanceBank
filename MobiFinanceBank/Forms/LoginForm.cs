using System;
using System.Windows.Forms;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Helpers;
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Services;
using MobiFinanceBank.Templates;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService.Interfaces;
namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Login form
    /// </summary>
    /// <seealso cref="TemplateForm"/>
    public partial class LoginForm : TemplateForm , ILoginForm
    {
        private LoginEmployeeData enteredData;
        
        private IMenuForm menuForm;
        private ILoginVmService loginVmService;
        private Employee result;
        


        /// <summary>
        /// Initializes new instance of login form
        /// </summary>
        /// <param name="_menuForm">Menu form</param>
        public LoginForm(IMenuForm _menuForm, ILoginVmService _loginVmService)
        {
            InitializeComponent();
            this.menuForm = _menuForm;
            this.loginVmService = _loginVmService;
            enteredData = new LoginEmployeeData();
        }

        /// <summary>
        /// Tries to login with given input data
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void btnUnesi_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(userNameTxt.Text) && !string.IsNullOrEmpty(passwordTxt.Text))
            {
                enteredData.Username = userNameTxt.Text;
                enteredData.Password = passwordTxt.Text;
                result = loginVmService.GetLoginData(enteredData);
            }    
            try {
                if (result != null)
                {
                    CurrentUser.SetEmployee(result);
                    menuForm.GetEmployee(result);
                    this.menuForm.Show();
                    this.Hide();
                }
            }
            catch(Exception er) {
                throw;
             }         
        }
        /// <summary>
        /// Opens help for the login form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r18061/wiki/Korisni%C4%8Dka-dokumentacija#12-prijava");
            }
        }
        /// <summary>
        /// Used for dependency injection
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
                this.Hide();
                e.Cancel = true;
            
        }
    }
}
