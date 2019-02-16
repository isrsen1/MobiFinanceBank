using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MobiFinanceBank.DAL.DbContexts.Interfaces;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories
{
    /// <summary>
    /// Loan repository.
    /// </summary>
    /// <seealso cref="ILoanRepository"/>
    public class LoanRepository: ILoanRepository
    {
        private readonly IMobiFinanceContext context;

        public LoanRepository(IMobiFinanceContext _context)
        {
            this.context = _context;
        }

        /// <summary>
        /// Adds the specified loan.
        /// </summary>
        /// <param name="loan">Loan</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created loan.</returns>
        public Loan Add(Loan loan, bool shouldSaveChanges = true)
        {
            // Checks if loan is instantiated
            if (loan == null)
                throw new ArgumentNullException(nameof(loan), "Loan is not instantiated");

            try
            {
                // Adds loan instance to database 
                this.context.Loans.Add(loan);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return loan;
        }

        /// <summary>
        /// Gets all loans as queryable
        /// </summary>
        /// <returns>LINQ upgradable query</returns>
        public IQueryable<Loan> GetAsQueryable()
        {
            return this.context.Loans;
        }

        /// <summary>
        /// Gets the asset
        /// </summary>
        /// <param name="liabilityId">Liability id</param>
        /// <returns>Asset</returns>
        public Loan Get(long loanId)
        {
            return this.context.Loans.FirstOrDefault(loan => loan.Id == loanId);
        }

        /// <summary>
        /// Get all loans by client
        /// </summary>
        /// <param name="clientId">Client id</param>
        /// <returns>Collection of loans</returns>
        public IEnumerable<Loan> GetByClientId(int clientId)
        {
            return this.context.Loans.Where(loan => loan.ClientId == clientId).ToList();
        }

        public IEnumerable<Loan> GetAllLoanRequests()
        {
            return this.context.Loans.Where(loan => loan.Status == (int) LoanStatus.Zahtjev);
        }

        /// <summary>
        /// Edits the specified loan.
        /// </summary>
        /// <param name="loan">Loan</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited loan.</returns>
        /// <exception cref="ArgumentNullException">Loan - loan is not instantiated or Id &lt;= 0</exception>
        public Loan Edit(Loan loan, bool shouldSaveChanges = true)
        {
            // Checks if loan is instantiated
            if (loan == null)
                throw new ArgumentNullException(nameof(loan), "Loan is not instantiated");

            try
            {
                // Modifies loan
                this.context.Entry(loan).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return loan;
        }

        /// <summary>
        /// Removes the specified loan.
        /// </summary>
        /// <param name="loanId">Loan identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        public void Remove(long loanId, bool shouldSaveChanges = true)
        {
            var loan = this.Get(loanId);

            if (loan == null)
                throw new ArgumentException($"Cannot delete non existing loan with id {loanId}");

            this.context.Loans.Remove(loan);

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
