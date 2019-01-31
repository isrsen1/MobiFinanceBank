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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MobiFinanceBank.Forms
{
    public partial class LoginForm : TemplateForm
    {
        private IMenuForm menuForm;
        public LoginForm(IMenuForm _menuForm)
        {
            InitializeComponent();
            this.menuForm = _menuForm;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.menuForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
