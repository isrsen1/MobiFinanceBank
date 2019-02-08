using System;
using System.Collections.Generic;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Saving account type repository interface.
    /// </summary>
    public interface ISavingAccountTypeRepository
    {
        /// <summary>
        /// Adds the specified saving account type.
        /// </summary>
        /// <param name="savingAccountType">Saving account type</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created saving account type.</returns>
        SavingAccountType Add(SavingAccountType savingAccountType, bool shouldSaveChanges = true);

        IEnumerable<SavingAccountType> GetAll();

        /// <summary>
        /// Gets the account on given date for given person.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        SavingAccountType Get(long personId);

        /// <summary>
        /// Edits the specified saving account type.
        /// </summary>
        /// <param name="savingAccountType">Saving account type</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited saving account type.</returns>
        /// <exception cref="ArgumentNullException">Saving account type - saving account type is not instantiated or Id &lt;= 0</exception>
        SavingAccountType Edit(SavingAccountType savingAccountType, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified saving account type.
        /// </summary>
        /// <param name="savingAccountTypeId">Saving account type identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long savingAccountTypeId, bool shouldSaveChanges = true);

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        void SaveChanges();
    }
}
