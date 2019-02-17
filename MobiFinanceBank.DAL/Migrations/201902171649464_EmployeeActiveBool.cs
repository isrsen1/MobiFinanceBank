namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeActiveBool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "IsActive");
        }
    }
}
