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
using MobiFinanceBank.Templates;

namespace MobiFinanceBank.Forms
{
    public partial class LoginForm : TemplateForm, ILoginForm
    {
        private IAccountRepository ar;
        public LoginForm(IAccountRepository repo)
        {
            InitializeComponent();
            ar = repo;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ar.Add(null, true);
        }
    }
}
