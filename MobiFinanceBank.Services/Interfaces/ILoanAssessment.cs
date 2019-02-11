using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.Services.Interfaces
{
    /// <summary>
    /// Loan assessment interface
    /// </summary>
    public interface ILoanAssessment
    {
        /// <summary>
        /// Calculates loan assessment for private clients
        /// </summary>
        /// <returns>
        /// Decimal number between 0 and 1 
        /// </returns>
        double CalculateLoanAssessmentForPrivateClients(long clientId, Loan requiredLoan);
    }
}
