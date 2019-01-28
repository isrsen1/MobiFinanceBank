using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Balance sheet repository interface.
    /// </summary>
    public interface IBalanceSheetRepository
    {
        /// <summary>
        /// Adds the specified balance sheet.
        /// </summary>
        /// <param name="balanceSheet">Balance sheet</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created balance sheet.</returns>
        BalanceSheet Add(BalanceSheet balanceSheet, bool shouldSaveChanges = true);


        /// <summary>
        /// Gets the account on given date for given person.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        BalanceSheet Get(long personId);

        /// <summary>
        /// Edits the specified balance sheet.
        /// </summary>
        /// <param name="balanceSheet">Balance sheet</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited balance sheet.</returns>
        /// <exception cref="ArgumentNullException">Balance sheet - balance sheet is not instantiated or Id &lt;= 0</exception>
        BalanceSheet Edit(BalanceSheet balanceSheet, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified balance sheet.
        /// </summary>
        /// <param name="balanceSheetId">Balance sheet identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long balanceSheetId, bool shouldSaveChanges = true);
    }
}
