using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Saving account repository interface.
    /// </summary>
    public interface ISavingAccountRepository
    {
        /// <summary>
        /// Adds the specified saving account.
        /// </summary>
        /// <param name="savingAccount">Saving account</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created saving account.</returns>
        SavingAccount Add(SavingAccount savingAccount, bool shouldSaveChanges = true);

        /// <summary>
        /// Gets all saving accounts as queryable
        /// </summary>
        /// <returns>LINQ upgradable query</returns>
        IQueryable<SavingAccount> GetAsQueryable();

        /// <summary>
        /// Gets the account on given date for given person.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        SavingAccount Get(long personId);

        /// <summary>
        /// Gets saving account collection filtered by client
        /// </summary>
        /// <param name="clientId">Client id</param>
        /// <returns>Saving account collection</returns>
        IEnumerable<SavingAccount> GetByClient(int clientId);

        /// <summary>
        /// Edits the specified saving account.
        /// </summary>
        /// <param name="savingAccount">Saving account</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited saving account.</returns>
        /// <exception cref="ArgumentNullException">Saving account - saving account is not instantiated or Id &lt;= 0</exception>
        SavingAccount Edit(SavingAccount savingAccount, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified saving account.
        /// </summary>
        /// <param name="savingAccountId">Saving account identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long savingAccountId, bool shouldSaveChanges = true);

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        void SaveChanges();
    }
}
