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
    /// Repayment plan repository.
    /// </summary>
    /// <seealso cref="IRepaymentPlanRepository"/>
    public class RepaymentPlanRepository: IRepaymentPlanRepository
    {
        private readonly IMobiFinanceContext context;

        /// <summary>
        /// Adds the specified repayment plan.
        /// </summary>
        /// <param name="repaymentPlan">Repayment plan</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created repayment plan.</returns>
        public RepaymentPlan Add(RepaymentPlan repaymentPlan, bool shouldSaveChanges = true)
        {
            // Checks if repayment plan is instantiated
            if (repaymentPlan == null)
                throw new ArgumentNullException(nameof(repaymentPlan), "Repayment plan is not instantiated");

            try
            {
                // Adds repayment plan instance to database 
                this.context.RepaymentPlan.Add(repaymentPlan);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return repaymentPlan;
        }

        /// <summary>
        /// Gets the asset
        /// </summary>
        /// <param name="liabilityId">Liability id</param>
        /// <returns>Asset</returns>
        public RepaymentPlan Get(long repaymentPlanId)
        {
            return this.context.RepaymentPlan.FirstOrDefault(repaymentPlan => repaymentPlan.Id == repaymentPlanId);
        }

        /// <summary>
        /// Edits the specified repayment plan.
        /// </summary>
        /// <param name="repaymentPlan">Repayment plan</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited repayment plan.</returns>
        /// <exception cref="ArgumentNullException">Repayment plan - repayment plan is not instantiated or Id &lt;= 0</exception>
        public RepaymentPlan Edit(RepaymentPlan repaymentPlan, bool shouldSaveChanges = true)
        {
            // Checks if repayment plan is instantiated
            if (repaymentPlan == null)
                throw new ArgumentNullException(nameof(repaymentPlan), "Repayment plan is not instantiated");

            try
            {
                // Modifies repayment plan
                this.context.Entry(repaymentPlan).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return repaymentPlan;
        }

        /// <summary>
        /// Removes the specified repayment plan.
        /// </summary>
        /// <param name="repaymentPlanId">Repayment plan identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        public void Remove(long repaymentPlanId, bool shouldSaveChanges = true)
        {
            var repaymentPlan = this.Get(repaymentPlanId);

            if (repaymentPlan == null)
                throw new ArgumentException($"Cannot delete non existing repayment plan with id {repaymentPlan}");

            this.context.RepaymentPlan.Remove(repaymentPlan);

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
