using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiFinanceBank.Model.Enums
{
    public enum LoanStatus
    {
        /// <summary>
        /// Loan request
        /// </summary>
        Zahtjev = 0,

        /// <summary>
        /// Loan denied
        /// </summary>
        Odbijen = 1,

        /// <summary>
        /// Loan approved
        /// </summary>
        Odobren = 2
    }
}
