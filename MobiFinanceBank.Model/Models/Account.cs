using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Account database model class.
    /// </summary>
    [Table("Account")]
    public partial class Account
    {
        /// <summary>
        /// Gets or sets the account id
        /// </summary>
        /// <value>
        /// Account id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets IBAN
        /// </summary>
        /// <value>
        /// IBAN
        /// </value>
        public string IBAN { get; set; }

        /// <summary>
        /// Gets or sets the account card number
        /// </summary>
        /// <value>
        /// The card number
        /// </value>
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the account balance
        /// </summary>
        /// <value>
        /// Account balance
        /// </value>
        public double Balance { get; set; }

        public double? DozvoljeniMinus { get; set; }

        public int? Blocked { get; set; }

        /// <summary>
        /// Gets or sets the account client
        /// </summary>
        /// <value>
        /// Account client
        /// </value>
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the account type id
        /// </summary>
        /// <value>
        /// Account type id
        /// </value>
        public int AccountTypeId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        [ForeignKey("AccountTypeId")]
        public virtual AccountType AccountType { get; set; }
    }
}
