using System;

namespace MobiFinanceBank.Model.Models
{
    using System.Collections.Generic;
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
        /// Gets or sets the loan start date
        /// </summary>
        /// <value>
        /// Loan start date
        /// </value>
        public DateTime LoanStartDate { get; set; }
        
        /// <summary>
        /// Gets or sets the loan end date
        /// </summary>
        /// <value>
        /// Loan end date
        /// </value>
        public DateTime LoanEndDate { get; set; }

        /// <summary>
        /// Gets or sets the loan capital
        /// </summary>
        /// <value>
        /// Loan capital
        /// </value>
        public double Capital { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether standing order is active
        /// </summary>
        /// <value>
        /// <c>true</c>if standing order is active, otherwise <c>false</c>
        /// </value>
        public bool IsStandingOrderActive { get; set; }
        
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
        public int ClientId { get; set; }
        
        /// <summary>
        /// Gets or sets the loan type id
        /// </summary>
        /// <value>
        /// Loan type id
        /// </value>
        public int LoanTypeId { get; set; }

        /// <summary>
        /// Gets or sets the account id
        /// </summary>
        /// <value>
        /// The account id
        /// </value>
        public int? AccountId { get; set; }
        /// <summary>
        /// Gets or sets client which issued loan
        /// </summary>
        /// <value>
        /// Client
        /// </value>
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        /// <summary>
        /// Gets or sets loan type
        /// </summary>
        /// <value>
        /// Loan type
        /// </value>
        [ForeignKey("LoanTypeId")]
        public virtual LoanType LoanType { get; set; }

        /// <summary>
        /// Gets or sets employee which issued loan
        /// </summary>
        /// <value>
        /// Employee
        /// </value>
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// Gets or sets the account for loan standing order
        /// </summary>
        /// <value>
        /// The account
        /// </value>
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        /// <summary>
        /// Gets or sets repayment plans
        /// </summary>
        /// <value>
        /// Repayment plans collection
        /// </value>
        public virtual ICollection<RepaymentPlan> RepaymentPlans { get; set; }
    }
}
