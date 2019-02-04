using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Vm;

namespace MobiFinanceBank.VmService.Interfaces
{
    /// <summary>
    /// Saving and account vm service interface
    /// </summary>
    public interface IBankServicesVmService
    {
        /// <summary>
        /// Gets filtered saving accounts overview data
        /// </summary>
        /// <param name="overviewFilter">Overview filter</param>
        /// <returns>Collection of saving accounts</returns>
        IEnumerable<SavingAccount> GetSavingAccountsOverview(SavingOverviewFilter overviewFilter);

        /// <summary>
        /// Gets filtered accounts overview data
        /// </summary>
        /// <param name="overviewFilter">Overview filter</param>
        /// <returns>Collection of accounts</returns>
        IEnumerable<Account> GetAccountsOverview(AccountOverviewFilter overviewFilter);

        /// <summary>
        /// Gets filtered loans overview data
        /// </summary>
        /// <param name="overviewFilter">Overview filter</param>
        /// <returns>Collection of loans</returns>
        IEnumerable<Loan> GetLoansOverview(LoanOverviewFilter overviewFilter);
    }
}
