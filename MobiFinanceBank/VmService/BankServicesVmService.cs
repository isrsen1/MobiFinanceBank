using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService.Interfaces;

namespace MobiFinanceBank.VmService
{
    public class BankServicesVmService: IBankServicesVmService
    {
        private readonly ISavingAccountRepository savingAccountRepository;
        private readonly IAccountRepository accountRepository;
        private readonly ILoanRepository loanRepository;

        public BankServicesVmService
        (ISavingAccountRepository _savingAccountRepository,
            IAccountRepository _accountRepository,
            ILoanRepository _loanRepository)
        {
            this.savingAccountRepository = _savingAccountRepository;
            this.accountRepository = _accountRepository;
            this.loanRepository = _loanRepository;
        }

        /// <summary>
        /// Gets filtered saving accounts overview data
        /// </summary>
        /// <param name="overviewFilter">Overview filter</param>
        /// <returns>Collection of saving accounts</returns>
        public IEnumerable<SavingAccount> GetSavingAccountsOverview(SavingOverviewFilter overviewFilter)
        {
            var clients = this.savingAccountRepository.GetAsQueryable();

            if (overviewFilter.Client != null)
                clients = clients.Where(sa => sa.ClientId == overviewFilter.Client.Id);

            var clientsFiltered = clients.ToList();

            return clientsFiltered;
        }

        /// <summary>
        /// Gets filtered accounts overview data
        /// </summary>
        /// <param name="overviewFilter">Overview filter</param>
        /// <returns>Collection of accounts</returns>
        public IEnumerable<Account> GetAccountsOverview(AccountOverviewFilter overviewFilter)
        {
            var clients = this.accountRepository.GetAsQueryable();

            if (overviewFilter.Client != null)
                clients = clients.Where(acc => acc.ClientId == overviewFilter.Client.Id);

            var clientsFiltered = clients.ToList();

            return clientsFiltered;
        }

        /// <summary>
        /// Gets filtered loans overview data
        /// </summary>
        /// <param name="overviewFilter">Overview filter</param>
        /// <returns>Collection of loans</returns>
        public IEnumerable<Loan> GetLoansOverview(LoanOverviewFilter overviewFilter)
        {
            var clients = this.loanRepository.GetAsQueryable();

            if (overviewFilter.Client != null)
                clients = clients.Where(loan => loan.ClientId == overviewFilter.Client.Id);

            var clientsFiltered = clients.ToList();

            return clientsFiltered;
        }
    }
}
