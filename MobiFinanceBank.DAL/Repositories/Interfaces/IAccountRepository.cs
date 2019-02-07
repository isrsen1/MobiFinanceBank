using System;
using System.Collections.Generic;
using System.Linq;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Account repository interface.
    /// </summary>
    public interface IAccountRepository
    {
        /// <summary>
        /// Adds the specified account.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created account.</returns>
        Account Add(Account account, bool shouldSaveChanges = true);

        /// <summary>
        /// Gets all accounts as queryable
        /// </summary>
        /// <returns>LINQ upgradable query</returns>
        IQueryable<Account> GetAsQueryable();

        /// <summary>
        /// Gets the account on given date for given person.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        Account Get(long personId);

        /// <summary>
        /// Gets saving account collection filtered by client
        /// </summary>
        /// <param name="clientId">Client id</param>
        /// <returns>Saving account collection</returns>
        IEnumerable<Account> GetByClient(int clientId);

        /// <summary>
        /// Edits the specified account.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited account.</returns>
        /// <exception cref="ArgumentNullException">account - account is not instantiated or Id &lt;= 0</exception>
        Account Edit(Account account, bool shouldSaveChanges = true);
        
        /// <summary>
        /// Removes the specified account.
        /// </summary>
        /// <param name="accountId">Account identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long accountId, bool shouldSaveChanges = true);
    }
}
