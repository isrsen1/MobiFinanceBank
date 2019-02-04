using System.Data.Entity.Migrations;

namespace MobiFinanceBank.DAL.Migrations
{
    /// <summary>
    /// Client company name migration
    /// </summary>
    /// <seealso cref="DbMigration"/>
    public partial class ClientCompanyName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Client", "CompanyName", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Client", "CompanyName");
        }
    }
}
