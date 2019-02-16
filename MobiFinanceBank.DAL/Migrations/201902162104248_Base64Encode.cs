namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Base64Encode : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employee", "OIB", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee", "OIB", c => c.Int(nullable: false));
        }
    }
}
