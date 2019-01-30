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
    /// Liability repository.
    /// </summary>
    /// <seealso cref="ILiabilityRepository"/>
    public class LiabilityRepository: ILiabilityRepository
    {
        private readonly IMobiFinanceContext context;

        /// <summary>
        /// Adds the specified liability.
        /// </summary>
        /// <param name="liability">Liability</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created liability.</returns>
        public Liability Add(Liability liability, bool shouldSaveChanges = true)
        {
            // Checks if liability is instantiated
            if (liability == null)
                throw new ArgumentNullException(nameof(liability), "Liability is not instantiated");

            try
            {
                // Adds liability instance to database 
                this.context.Liabilities.Add(liability);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return liability;
        }

        /// <summary>
        /// Gets the asset
        /// </summary>
        /// <param name="liabilityId">Liability id</param>
        /// <returns>Asset</returns>
        public Liability Get(long liabilityId)
        {
            return this.context.Liabilities.FirstOrDefault(liability => liability.Id == liabilityId);
        }

        /// <summary>
        /// Edits the specified liability.
        /// </summary>
        /// <param name="liability">Liability</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited liability.</returns>
        /// <exception cref="ArgumentNullException">Liability - liability is not instantiated or Id &lt;= 0</exception>
        public Liability Edit(Liability liability, bool shouldSaveChanges = true)
        {
            // Checks if liability is instantiated
            if (liability == null)
                throw new ArgumentNullException(nameof(liability), "Liability is not instantiated");

            try
            {
                // Modifies liability
                this.context.Entry(liability).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return liability;
        }

        /// <summary>
        /// Removes the specified liability.
        /// </summary>
        /// <param name="liabilityId">liability identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        public void Remove(long liabilityId, bool shouldSaveChanges = true)
        {
            var liability = this.Get(liabilityId);

            if (liability == null)
                throw new ArgumentException($"Cannot delete non existing liability with id {liability}");

            this.context.Liabilities.Remove(liability);

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
