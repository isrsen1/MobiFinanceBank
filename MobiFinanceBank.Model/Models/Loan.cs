namespace MobiFinanceBank.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Loan database model class.
    /// </summary>
    [Table("Loan")]
    public partial class Loan
    {
        /// <summary>
        /// Initializes new loan
        /// </summary>
        public Loan()
        {
            RepaymentPlans = new HashSet<RepaymentPlan>();
        }

        /// <summary>
        /// Gets or sets loan id
        /// </summary>
        /// <value>
        /// Loan id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets loan status
        /// </summary>
        /// <value>
        /// Loan status
        /// </value>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets loan start date
        /// </summary>
        /// <value>
        /// Loan start date
        /// </value>
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        public double Glavnica { get; set; }

        public int RokOtplate { get; set; }

        /// <summary>
        /// Gets or sets employee's id which issued loan
        /// </summary>
        /// <value>
        /// Employee id
        /// </value>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets client id which loan belongs
        /// </summary>
        /// <value>
        /// Client id
        /// </value>
        public int? ClientId { get; set; }

        public double KamatnaStopa { get; set; }
        
        /// <summary>
        /// Gets or sets loan name
        /// </summary>
        /// <value>
        /// Loan name
        /// </value>
        public string LoanName { get; set; }

        /// <summary>
        /// Gets or sets client which issued loan
        /// </summary>
        /// <value>
        /// Client
        /// </value>
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        /// <summary>
        /// Gets or sets employee which issued loan
        /// </summary>
        /// <value>
        /// Employee
        /// </value>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// Gets or sets repayment plans
        /// </summary>
        /// <value>
        /// Repayment plans collection
        /// </value>
        public virtual ICollection<RepaymentPlan> RepaymentPlans { get; set; }
    }
}
