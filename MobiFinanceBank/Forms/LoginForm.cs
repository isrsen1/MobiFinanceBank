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
        private LoginEmployeeData data;
        
        private IMenuForm menuForm;
        private ILoginVmService loginVmService;
        


        /// <summary>
        /// Initializes new instance of login form
        /// </summary>
        /// <param name="_menuForm">Menu form</param>
        public LoginForm(IMenuForm _menuForm, ILoginVmService _loginVmService)
        {
            InitializeComponent();
            this.menuForm = _menuForm;
            this.loginVmService = _loginVmService;
            data = new LoginEmployeeData();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.menuForm.Show();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            
            data.Username = userNameTxt.Text;
            data.Password = passwordTxt.Text;
            var result = loginVmService.GetLoginData(data);
     
            try {
                if (result != null)
                {
                    CurrentUser.SetEmployee(result);
                    menuForm.GetEmployee(result);
                    this.menuForm.Show();
                }
            }
            catch(Exception er) {
                throw;
             }
            
           
            

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                Help.ShowHelp(this, @"file://../../Resources/ help.chm");
            }
        }
    }
}
