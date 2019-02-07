using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    /// <summary>
    /// Loan type database model class
    /// </summary>
    [Table("LoanType")]
    public class LoanType
    {
        /// <summary>
        /// Initializes new loan
        /// </summary>
        public LoanType()
        {
            Loans = new HashSet<Loan>();
        }

        /// <summary>
        /// Gets or sets the loan type id
        /// </summary>
        /// <value>
        /// Loan type id
        /// </value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the loan type name
        /// </summary>
        /// <value>
        /// Loan type name
        /// </value>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the loan duration - unit - year
        /// </summary>
        /// <value>
        /// Loan duration
        /// </value>
        public int LoanDuration { get; set; }

        /// <summary>
        /// Gets or sets loan interest rate
        /// </summary>
        public double InterestRate { get; set; }
        
        /// <summary>
        /// Gets or sets repayment plans
        /// </summary>
        /// <value>
        /// Repayment plans collection
        /// </value>
        public virtual ICollection<Loan> Loans { get; set; }
    }
}
