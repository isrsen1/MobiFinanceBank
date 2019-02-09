using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Services;
using MobiFinanceBank.Templates;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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

        }
    }
}
