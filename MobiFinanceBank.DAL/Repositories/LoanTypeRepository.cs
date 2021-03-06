﻿using System.Collections.Generic;
using System.Linq;
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

        public LoanType GetById(int loanTypeId)
        {
            return this.context.LoanTypes.FirstOrDefault(lt => lt.Id == loanTypeId);
        }
    }
}
