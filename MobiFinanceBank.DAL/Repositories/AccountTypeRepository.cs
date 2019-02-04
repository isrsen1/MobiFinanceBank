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
    /// Account type repository.
    /// </summary>
    /// <seealso cref="IAccountTypeRepository"/>
    public class AccountTypeRepository: IAccountTypeRepository
    {
        private readonly IMobiFinanceContext context;

        /// <summary>
        /// Initializes new account type repository instance
        /// </summary>
        /// <param name="_mobiFinanceContext">Mobi finance context</param>
        public AccountTypeRepository(IMobiFinanceContext _mobiFinanceContext)
        {
            this.context = _mobiFinanceContext;
        }

        /// <summary>
        /// Adds new account type to database
        /// </summary>
        /// <param name="accountType">The account type</param>
        /// <param name="shouldSaveChanges">Should save changes <c>true</c> if should save changes, otherwise <c>false</c></param>
        /// <returns>Added account type</returns>
        public AccountType Add(AccountType accountType, bool shouldSaveChanges = true)
        {
            // Checks if account type is instantiated
            if (accountType == null)
                throw new ArgumentNullException(nameof(accountType), "Account type is not instantiated");

            try
            {
                // Adds account type instance to database 
                this.context.AccountTypes.Add(accountType);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return accountType;
        }

        public IEnumerable<AccountType> GetAll()
        {
            return this.context.AccountTypes.ToList();
        }

        /// <summary>
        /// Gets the account type
        /// </summary>
        /// <param name="accountTypeId">Account type id</param>
        /// <returns>Account type</returns>
        public AccountType Get(long accountTypeId)
        {
            return this.context.AccountTypes.FirstOrDefault(accountType => accountType.Id == accountTypeId);
        }

        /// <summary>
        /// Edits the account type
        /// </summary>
        /// <param name="accountType">The account type</param>
        /// <param name="shouldSaveChanges">Should save changes <c>true</c> if should save changes, otherwise <c>false</c></param>
        /// <returns>Edited account type</returns>
        public AccountType Edit(AccountType accountType, bool shouldSaveChanges = true)
        {
            // Checks if account type is instantiated
            if (accountType == null)
                throw new ArgumentNullException(nameof(accountType), "Account type is not instantiated");

            try
            {
                // Modifies account type
                this.context.Entry(accountType).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return accountType;
        }

        /// <summary>
        /// Removes the account type
        /// </summary>
        /// <param name="accountTypeId">Account type id</param>
        /// <param name="shouldSaveChanges">Should save changes <c>true</c> if should save changes, otherwise <c>false</c></param>
        public void Remove(long accountTypeId, bool shouldSaveChanges = true)
        {
            var accountType = this.Get(accountTypeId);

            if (accountType == null)
                throw new ArgumentException($"Cannot delete non existing account type with id {accountTypeId}");

            this.context.AccountTypes.Remove(accountType);

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
