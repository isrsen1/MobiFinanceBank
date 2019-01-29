using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Liability repository interface.
    /// </summary>
    public interface ILiabilityRepository
    {
        /// <summary>
        /// Adds the specified liability.
        /// </summary>
        /// <param name="liability">Liability</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created liability.</returns>
        Liability Add(Liability liability, bool shouldSaveChanges = true);


        /// <summary>
        /// Gets the account on given date for given person.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        Liability Get(long personId);

        /// <summary>
        /// Edits the specified liability.
        /// </summary>
        /// <param name="liability">Liability</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited liability.</returns>
        /// <exception cref="ArgumentNullException">Liability - liability is not instantiated or Id &lt;= 0</exception>
        Liability Edit(Liability liability, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified liability.
        /// </summary>
        /// <param name="liabilityId">liability identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long liabilityId, bool shouldSaveChanges = true);
    }
}
