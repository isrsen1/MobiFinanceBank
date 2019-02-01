namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeHashMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "hashPassword", c => c.String(unicode: false));
            DropColumn("dbo.Employee", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employee", "Password", c => c.String(unicode: false));
            DropColumn("dbo.Employee", "hashPassword");
        }
    }
}
