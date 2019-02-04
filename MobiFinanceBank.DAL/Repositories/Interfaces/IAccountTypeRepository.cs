using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.DbContexts.Interfaces;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Acount type repository interface.
    /// </summary>
    public interface IAccountTypeRepository
    {
        /// <summary>
        /// Adds the specified account type.
        /// </summary>
        /// <param name="accountType">Account type</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created account type.</returns>
        AccountType Add(AccountType accountType, bool shouldSaveChanges = true);

        IEnumerable<AccountType> GetAll();

        /// <summary>
        /// Gets the account on given date for given person.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        AccountType Get(long personId);

        /// <summary>
        /// Edits the specified account type.
        /// </summary>
        /// <param name="accountType">Account type</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited account type.</returns>
        /// <exception cref="ArgumentNullException">account type - account type is not instantiated or Id &lt;= 0</exception>
        AccountType Edit(AccountType accountType, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified account type.
        /// </summary>
        /// <param name="accountTypeId">Account type identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long accountTypeId, bool shouldSaveChanges = true);

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        void SaveChanges();
    }
}
