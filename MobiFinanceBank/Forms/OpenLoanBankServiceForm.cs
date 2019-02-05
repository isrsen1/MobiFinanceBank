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
    /// <summary>
    /// Open loan bank service form
    /// </summary>
    /// <seealso cref="TemplateForm"/>
    /// <seealso cref="IOpenLoanBankServiceForm"/>
    public partial class OpenLoanBankServiceForm : TemplateForm, IOpenLoanBankServiceForm
    {
        /// <summary>
        /// Initializes new instance of open loan bank service form
        /// </summary>
        public OpenLoanBankServiceForm()
        {
            InitializeComponent();
        }
    }
}
