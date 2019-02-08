namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncomeRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Client", "Income", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Client", "Income", c => c.Double());
        }
    }
}
