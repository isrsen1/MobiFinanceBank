using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public RepaymentPlan Add(RepaymentPlan repaymentPlan, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public RepaymentPlan Get(long personId)
        {
            throw new NotImplementedException();
        }

        public RepaymentPlan Edit(RepaymentPlan repaymentPlan, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void Remove(long repaymentPlanId, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
