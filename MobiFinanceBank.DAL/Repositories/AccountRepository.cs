using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.DbContexts.Interfaces;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories
{
    /// <summary>
    /// Account repository.
    /// </summary>
    /// <seealso cref="IAccountRepository"/>
    public class AccountRepository: IAccountRepository
    {
        private readonly IMobiFinanceContext context;

        public AccountRepository(IMobiFinanceContext _context)
        {
            this.context = _context;
        }

        /// <summary>
        /// Adds new account to database
        /// </summary>
        /// <param name="account">The account</param>
        /// <param name="shouldSaveChanges">Should save changes <c>true</c> if should save changes, otherwise <c>false</c></param>
        /// <returns>Added account</returns>
        public Account Add(Account account, bool shouldSaveChanges = true)
        {
            // Checks if account is instantiated
            if (account == null)
                throw new ArgumentNullException(nameof(account), "Account is not instantiated");

            try
            {
                // Adds account instance to database 
                this.context.Accounts.Add(account);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return account;
        }

        /// <summary>
        /// Gets all accounts as queryable
        /// </summary>
        /// <returns>LINQ upgradable query</returns>
        public IQueryable<Account> GetAsQueryable()
        {
            return this.context.Accounts;
        }

        /// <summary>
        /// Gets the account
        /// </summary>
        /// <param name="accountId">Account id</param>
        /// <returns>Account</returns>
        public Account Get(long accountId)
        {
            return this.context.Accounts.FirstOrDefault(account => account.Id == accountId);
        }

        /// <summary>
        /// Gets saving account collection filtered by client
        /// </summary>
        /// <param name="clientId">Client id</param>
        /// <returns>Saving account collection</returns>
        public IEnumerable<Account> GetByClient(int clientId)
        {
            return this.context.Accounts.Where(acc => acc.ClientId == clientId);
        }

        /// <summary>
        /// Edits the account
        /// </summary>
        /// <param name="account">The account</param>
        /// <param name="shouldSaveChanges">Should save changes <c>true</c> if should save changes, otherwise <c>false</c></param>
        /// <returns>Edited account</returns>
        public Account Edit(Account account, bool shouldSaveChanges = true)
        {
            // Checks if account is instantiated
            if (account == null)
                throw new ArgumentNullException(nameof(account), "Account is not instantiated");

            try
            {
                // Modifies account
                this.context.Entry(account).State = EntityState.Modified;

                // Saves changes
                if(shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return account;
        }

        /// <summary>
        /// Removes the account
        /// </summary>
        /// <param name="accountId">Account id</param>
        /// <param name="shouldSaveChanges">Should save changes <c>true</c> if should save changes, otherwise <c>false</c></param>
        public void Remove(long accountId, bool shouldSaveChanges = true)
        {
            var account = this.Get(accountId);

            if (account == null)
                throw new ArgumentException($"Cannot delete non existing account with id {accountId}");

            this.context.Accounts.Remove(account);

            if (shouldSaveChanges)
            {
                try
                {
                    this.SaveChanges();
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
