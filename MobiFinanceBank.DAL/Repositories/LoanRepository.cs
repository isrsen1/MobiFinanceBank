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
    /// Loan repository.
    /// </summary>
    /// <seealso cref="ILoanRepository"/>
    public class LoanRepository: ILoanRepository
    {
        public Loan Add(Loan loan, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Loan Get(long personId)
        {
            throw new NotImplementedException();
        }

        public Loan Edit(Loan loan, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void Remove(long loanId, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
