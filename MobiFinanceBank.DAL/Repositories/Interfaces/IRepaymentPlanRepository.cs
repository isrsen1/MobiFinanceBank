using System;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Repayment plan repository interface.
    /// </summary>
    public interface IRepaymentPlanRepository
    {
        /// <summary>
        /// Adds the specified repayment plan.
        /// </summary>
        /// <param name="repaymentPlan">Repayment plan</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created repayment plan.</returns>
        RepaymentPlan Add(RepaymentPlan repaymentPlan, bool shouldSaveChanges = true);


        /// <summary>
        /// Gets the account on given date for given person.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        RepaymentPlan Get(long personId);

        /// <summary>
        /// Edits the specified repayment plan.
        /// </summary>
        /// <param name="repaymentPlan">Repayment plan</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited repayment plan.</returns>
        /// <exception cref="ArgumentNullException">Repayment plan - repayment plan is not instantiated or Id &lt;= 0</exception>
        RepaymentPlan Edit(RepaymentPlan repaymentPlan, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified repayment plan.
        /// </summary>
        /// <param name="repaymentPlanId">Repayment plan identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long repaymentPlanId, bool shouldSaveChanges = true);

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        void SaveChanges();
    }
}
