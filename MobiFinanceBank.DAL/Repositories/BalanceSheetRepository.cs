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
    /// Balance sheet repository.
    /// </summary>
    /// <seealso cref="IBalanceSheetRepository"/>
    public class BalanceSheetRepository: IBalanceSheetRepository
    {
        private readonly IMobiFinanceContext context;

        /// <summary>
        /// Adds the specified balance sheet.
        /// </summary>
        /// <param name="balanceSheet">Balance sheet</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created balance sheet.</returns>
        public BalanceSheet Add(BalanceSheet balanceSheet, bool shouldSaveChanges = true)
        {
            // Checks if balance sheet is instantiated
            if (balanceSheet == null)
                throw new ArgumentNullException(nameof(balanceSheet), "Balance sheet is not instantiated");

            try
            {
                // Adds balance sheet instance to database 
                this.context.BalanceSheets.Add(balanceSheet);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return balanceSheet;
        }

        /// <summary>
        /// Gets the asset
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <returns>Asset</returns>
        public BalanceSheet Get(long balanceSheetId)
        {
            return this.context.BalanceSheets.FirstOrDefault(balanceSheet => balanceSheet.Id == balanceSheetId);
        }

        /// <summary>
        /// Edits the specified balance sheet.
        /// </summary>
        /// <param name="balanceSheet">Balance sheet</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited balance sheet.</returns>
        /// <exception cref="ArgumentNullException">Balance sheet - balance sheet is not instantiated or Id &lt;= 0</exception>
        public BalanceSheet Edit(BalanceSheet balanceSheet, bool shouldSaveChanges = true)
        {
            // Checks if balance sheet is instantiated
            if (balanceSheet == null)
                throw new ArgumentNullException(nameof(balanceSheet), "Balance sheet is not instantiated");

            try
            {
                // Modifies asset
                this.context.Entry(balanceSheet).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return balanceSheet;
        }

        /// <summary>
        /// Removes the specified balance sheet.
        /// </summary>
        /// <param name="balanceSheetId">Balance sheet identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        public void Remove(long balanceSheetId, bool shouldSaveChanges = true)
        {
            var balanceSheet = this.Get(balanceSheetId);

            if (balanceSheet == null)
                throw new ArgumentException($"Cannot delete non existing balance sheet with id {balanceSheetId}");

            this.context.BalanceSheets.Remove(balanceSheet);

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
