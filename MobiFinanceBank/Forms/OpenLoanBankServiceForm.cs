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
