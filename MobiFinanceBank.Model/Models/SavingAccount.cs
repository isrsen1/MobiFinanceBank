using System;

namespace MobiFinanceBank.Model.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Saving account database model class.
    /// </summary>
    [Table("SavingAccount")]
    public partial class SavingAccount
    {
        /// <summary>
        /// Gets or sets saving account id
        /// </summary>
        /// <value>
        /// Saving account id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the saving account is active
        /// </summary>
        /// <value>
        /// <true>if saving account is active, otherwise <c>false</c></true>
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the saving account capital 
        /// </summary>
        /// <value>
        /// The capital
        /// </value>
        public double Capital { get; set; }

        /// <summary>
        /// Gets or sets the saving account balance
        /// </summary>
        /// <value>
        /// Saving account balance
        /// </value>
        public double Balance { get; set; }

        /// <summary>
        /// Gets or sets the fixed term depositing start date 
        /// </summary>
        /// <value>
        /// Fixed term depositing start date
        /// </value>
        public DateTime FixedTermDepositingStartDate { get; set; }

        /// <summary>
        /// Gets or sets the fixed term depositing end date
        /// </summary>
        /// <value>
        /// Fixed term depositing end date
        /// </value>
        public DateTime FixedTermDepositingEndDate { get; set; }
        
        /// <summary>
        /// Gets or sets the value indicating whether standing order is active
        /// </summary>
        /// <value>
        /// <c>true</c>if standing order is active, otherwise <c>false</c>
        /// </value>
        public bool IsStandingOrderActive { get; set; }

        /// <summary>
        /// Gets or sets the account id - used for standing order
        /// </summary>
        /// <value>
        /// Account id
        /// </value>
        public int? AccountId { get; set; }

        /// <summary>
        /// Gets or sets saving account type id
        /// </summary>
        /// <value>
        /// Saving account type id
        /// </value>
        public int SavingAccountTypeId { get; set; }
        
        /// <summary>
        /// Gets or sets client id which saving account belongs
        /// </summary>
        /// <value>
        /// Client id
        /// </value>
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets employee id who issued saving account 
        /// </summary>
        /// <value>
        /// Employee id
        /// </value>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets client which saving account belongs
        /// </summary>
        /// <value>
        /// Client 
        /// </value>
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        /// <summary>
        /// Gets or sets saving account type
        /// </summary>
        /// <value>
        /// Saving account type
        /// </value>
        [ForeignKey("SavingAccountTypeId")]
        public virtual SavingAccountType SavingAccountType { get; set; }

        /// <summary>
        /// Gets or sets employee who issued saving account
        /// </summary>
        /// <value>
        /// Employee
        /// </value>
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// Gets or sets the account for standing order
        /// </summary>
        /// <value>
        /// The account
        /// </value>
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
    }
}
