namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
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
