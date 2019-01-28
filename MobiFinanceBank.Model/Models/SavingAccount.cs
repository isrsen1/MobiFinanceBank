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
        /// Gets or sets saving account status
        /// </summary>
        /// <value>
        /// Saving account status
        /// </value>
        public int Status { get; set; }

        public double Glavnica { get; set; }

        public int RokOročenja { get; set; }

        public double? KonačanIznos { get; set; }

        /// <summary>
        /// Gets or sets saving account type id
        /// </summary>
        /// <value>
        /// Saving account type id
        /// </value>
        public int SavingAccountTypeId { get; set; }

        /// <summary>
        /// Gets or sets saving account interest
        /// </summary>
        /// <value>
        /// Saving account interest
        /// </value>
        public double Interest { get; set; }

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

        public double? RKS { get; set; }

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
        [ForeignKey("Zaposlenikid")]
        public virtual Employee Employee { get; set; }
    }
}
