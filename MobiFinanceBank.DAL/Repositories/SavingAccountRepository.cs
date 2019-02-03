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
    /// Saving account repository.
    /// </summary>
    /// <seealso cref="ISavingAccountRepository"/>
    public class SavingAccountRepository: ISavingAccountRepository
    {
        private readonly IMobiFinanceContext context;

        /// <summary>
        /// Initializes new saving account repository instance
        /// </summary>
        /// <param name="_mobiFinanceContext">Mobi finance context</param>
        public SavingAccountRepository(IMobiFinanceContext _mobiFinanceContext)
        {
            this.context = _mobiFinanceContext;
        }

        /// <summary>
        /// Adds the specified saving account.
        /// </summary>
        /// <param name="savingAccount">Saving account</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created saving account.</returns>
        public SavingAccount Add(SavingAccount savingAccount, bool shouldSaveChanges = true)
        {
            // Checks if saving account is instantiated
            if (savingAccount == null)
                throw new ArgumentNullException(nameof(savingAccount), "Saving account is not instantiated");

            try
            {
                // Adds saving account instance to database 
                this.context.SavingAccounts.Add(savingAccount);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return savingAccount;
        }

        /// <summary>
        /// Gets all saving accounts as queryable
        /// </summary>
        /// <returns>LINQ upgradable query</returns>
        public IQueryable<SavingAccount> GetAsQueryable()
        {
            return this.context.SavingAccounts;
        }

        /// <summary>
        /// Gets the asset
        /// </summary>
        /// <param name="savingAccountId">Liability id</param>
        /// <returns>Asset</returns>
        public SavingAccount Get(long savingAccountId)
        {
            return this.context.SavingAccounts.FirstOrDefault(savingAccount => savingAccount.Id == savingAccountId);
        }

        /// <summary>
        /// Gets saving account collection filtered by client
        /// </summary>
        /// <param name="clientId">Client id</param>
        /// <returns>Saving account collection</returns>
        public IEnumerable<SavingAccount> GetByClient(int clientId)
        {
            return this.context.SavingAccounts.Where(sa => sa.ClientId == clientId);
        }

        /// <summary>
        /// Edits the specified saving account.
        /// </summary>
        /// <param name="savingAccount">Saving account</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited saving account.</returns>
        /// <exception cref="ArgumentNullException">Saving account - saving account is not instantiated or Id &lt;= 0</exception>
        public SavingAccount Edit(SavingAccount savingAccount, bool shouldSaveChanges = true)
        {
            // Checks if saving account is instantiated
            if (savingAccount == null)
                throw new ArgumentNullException(nameof(savingAccount), "Saving account is not instantiated");

            try
            {
                // Modifies saving account
                this.context.Entry(savingAccount).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return savingAccount;
        }

        /// <summary>
        /// Removes the specified saving account.
        /// </summary>
        /// <param name="savingAccountId">Saving account identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        public void Remove(long savingAccountId, bool shouldSaveChanges = true)
        {
            var savingAccount = this.Get(savingAccountId);

            if (savingAccount == null)
                throw new ArgumentException($"Cannot delete non existing saving account with id {savingAccountId}");

            this.context.SavingAccounts.Remove(savingAccount);

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
