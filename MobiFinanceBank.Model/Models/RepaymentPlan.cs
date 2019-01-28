using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    /// <summary>
    /// Repayment plan database model class.
    /// </summary>
    [Table("RepaymentPlan")]
    public partial class RepaymentPlan
    {
        /// <summary>
        /// Gets or sets repayment plan id
        /// </summary>
        /// <value>
        /// Repayment plan id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets repayment plan interest
        /// </summary>
        /// <value>
        /// Repayment plan interest
        /// </value>
        public double Interest { get; set; }

        public double Anuitet { get; set; }

        public double OtplatnaKvota { get; set; }

        public double OstatakDuga { get; set; }

        public double OtplaceniDio { get; set; }

        /// <summary>
        /// Gets or sets repayment plan loan id
        /// </summary>
        /// <value>
        /// Repayment plan loan id
        /// </value>
        public int LoanId { get; set; }

        /// <summary>
        /// Gets or sets repayment plan month
        /// </summary>
        /// <value>
        /// Repayment plan month
        /// </value>
        public int Month { get; set; }

        /// <summary>
        /// Gets or sets loan which repayment plan belongs
        /// </summary>
        /// <value>
        /// Loan
        /// </value>
        [ForeignKey("LoanId")]
        public virtual Loan Loan { get; set; }
    }
}
