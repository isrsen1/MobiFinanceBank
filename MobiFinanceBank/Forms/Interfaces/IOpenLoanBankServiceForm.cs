using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.Forms.Interfaces
{
    /// <summary>
    /// Open loan bank service form
    /// </summary>
    public interface IOpenLoanBankServiceForm
    {
        /// <summary>
        /// Hides base show method
        /// </summary>
        /// <param name="client">The client</param>
        /// <param name="loanType">Loan type</param>
        void Show(Client client, LoanType loanType);
    }
}
