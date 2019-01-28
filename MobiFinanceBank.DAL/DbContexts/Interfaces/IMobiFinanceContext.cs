using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.DbContexts.Interfaces
{
    /// <summary>
    /// Mobi finance context interface
    /// </summary>
    public interface IMobiFinanceContext
    {
        DbSet<BalanceSheet> BalanceSheets { get; set; }
        DbSet<Asset> Assets { get; set; }
        DbSet<Liability> Liabilities { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<Loan> Loans { get; set; }
        DbSet<RepaymentPlan> RepaymentPlan { get; set; }
        DbSet<Account> Accounts { get; set; }
        DbSet<SavingAccount> SavingAccounts { get; set; }
        DbSet<sysdiagram> sysdiagrams { get; set; }
        DbSet<EmployeeType> EmployeeTypes { get; set; }
        DbSet<AccountType> AccountTypes { get; set; }
        DbSet<SavingAccountType> SavingAccountTypes { get; set; }
        DbSet<Employee> Employees { get; set; }
    }
}
