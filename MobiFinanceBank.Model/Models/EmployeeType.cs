using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Employee type database model class.
    /// </summary>
    [Table("EmployeeType")]
    public partial class EmployeeType
    {
        /// <summary>
        /// Initializes employee's new instance
        /// </summary>
        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
        }

        /// <summary>
        /// Gets or sets employee type id 
        /// </summary>
        /// <value>
        /// Employee type id
        /// </value>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets employee type name
        /// </summary>
        /// <value>
        /// Employee type name
        /// </value>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets employee type description
        /// </summary>
        /// <value>
        /// Employee type description
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets employee type employee collection
        /// </summary>
        /// <value>
        /// Employee type employee collection
        /// </value>
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
