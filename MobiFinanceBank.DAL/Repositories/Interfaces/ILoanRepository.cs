using System;
using System.Linq;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Loan repository interface.
    /// </summary>
    public interface ILoanRepository
    {
        /// <summary>
        /// Adds the specified loan.
        /// </summary>
        /// <param name="loan">Loan</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created loan.</returns>
        Loan Add(Loan loan, bool shouldSaveChanges = true);


        /// <summary>
        /// Gets all loans as queryable
        /// </summary>
        /// <returns>LINQ upgradable query</returns>
        IQueryable<Loan> GetAsQueryable();

        /// <summary>
        /// Gets the account on given date for given person.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        Loan Get(long personId);

        /// <summary>
        /// Edits the specified loan.
        /// </summary>
        /// <param name="loan">Loan</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited loan.</returns>
        /// <exception cref="ArgumentNullException">Loan - loan is not instantiated or Id &lt;= 0</exception>
        Loan Edit(Loan loan, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified loan.
        /// </summary>
        /// <param name="loanId">Loan identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long loanId, bool shouldSaveChanges = true);

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        void SaveChanges();
    }
}
