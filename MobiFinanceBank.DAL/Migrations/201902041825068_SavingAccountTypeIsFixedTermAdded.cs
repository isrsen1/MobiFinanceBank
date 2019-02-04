using System.Data.Entity.Migrations;

namespace MobiFinanceBank.DAL.Migrations
{
    /// <summary>
    /// Saving account type is fixed term added 
    /// </summary>
    /// <seealso cref="DbMigration"/>
    public partial class SavingAccountTypeIsFixedTermAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SavingAccountType", "IsFixedTerm", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SavingAccountType", "IsFixedTerm");
        }
    }
}
