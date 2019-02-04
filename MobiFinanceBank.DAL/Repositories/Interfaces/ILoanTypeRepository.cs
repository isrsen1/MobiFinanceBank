using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    public interface ILoanTypeRepository
    {
        IEnumerable<LoanType> GetAll();
    }
}
