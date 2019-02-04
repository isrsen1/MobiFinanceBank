using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Templates;

namespace MobiFinanceBank.Forms
{
    public partial class OpenLoanBankServiceForm : TemplateForm, IOpenLoanBankServiceForm
    {
        public OpenLoanBankServiceForm()
        {
            InitializeComponent();
        }
    }
}
