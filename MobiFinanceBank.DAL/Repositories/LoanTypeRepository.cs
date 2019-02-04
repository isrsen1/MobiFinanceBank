using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.DbContexts.Interfaces;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories
{
    /// <summary>
    /// Loan type repository
    /// </summary>
    public class LoanTypeRepository: ILoanTypeRepository
    {
        private readonly IMobiFinanceContext context;

        /// <summary>
        /// Initializes new loan type repository instance
        /// </summary>
        /// <param name="_mobiFinanceContext">Mobi finance context</param>
        public LoanTypeRepository(IMobiFinanceContext _mobiFinanceContext)
        {
            this.context = _mobiFinanceContext;
        }

        public IEnumerable<LoanType> GetAll()
        {
            return this.context.LoanTypes.ToList();
        }
    }
}
