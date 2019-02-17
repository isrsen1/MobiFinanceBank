using System.Collections.Generic;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    public interface ILoanTypeRepository
    {
        IEnumerable<LoanType> GetAll();
        LoanType GetById(int loanTypeId);
    }
}
