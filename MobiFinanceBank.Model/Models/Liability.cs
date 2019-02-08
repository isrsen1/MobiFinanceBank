using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    /// <summary>
    /// Liability database model class.
    /// </summary>
    [Table("Liability")]
    public partial class Liability
    {
        /// <summary>
        /// Gets or sets liability id
        /// </summary>
        /// <value>
        /// Liability id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets liability name
        /// </summary>
        /// <value>
        /// Liability name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets liability value
        /// </summary>
        /// <value>
        /// Liability value
        /// </value>
        public double LiabilityValue { get; set; }
        
        /// <summary>
        /// Gets or sets liability type
        /// </summary>
        /// <value>
        /// Liability type
        /// </value>
        public string LiabilityType { get; set; }

        /// <summary>
        /// Gets or sets liability balance sheet id 
        /// </summary>
        /// <value>
        /// Liability balance sheet id
        /// </value>
        public int BalanceSheetId { get; set; }
        
        /// <summary>
        /// Gets or sets liability category 
        /// </summary>
        /// <value>
        /// Liability category
        /// </value>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets liability balance sheet
        /// </summary>
        /// <value>
        /// Liability balance sheet 
        /// </value>
        [ForeignKey("BalanceSheetId")]
        public virtual BalanceSheet BalanceSheet { get; set; }
    }
}
