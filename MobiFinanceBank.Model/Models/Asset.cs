using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    /// <summary>
    /// Asset database model class.
    /// </summary>
    [Table("Asset")]
    public partial class Asset
    {
        /// <summary>
        /// Gets or sets the asset id
        /// </summary>
        /// <value>
        /// The asset id
        /// </value>
        public int Id { get; set; }


        public int Rok { get; set; }

        /// <summary>
        /// Gets or sets the asset name
        /// </summary>
        /// <value>
        /// The asset name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the asset value
        /// </summary>
        /// <value>
        /// The asset value
        /// </value>
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets the balance sheet id
        /// </summary>
        /// <value>
        /// The balance sheet id
        /// </value>
        public int BalanceSheetId { get; set; }

        /// <summary>
        /// Gets or sets the asset category
        /// </summary>
        /// <value>
        /// The asset category
        /// </value>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the asset balance sheet
        /// </summary>
        [ForeignKey("BalanceSheetId")]
        public virtual BalanceSheet BalanceSheet { get; set; }
    }
}
