using System;
using System.Data.Entity.Migrations;

namespace MobiFinanceBank.DAL.Migrations
{
    /// <summary>
    /// Employee hash migration - renaming password to hash password
    /// </summary>
    /// <seealso cref="DbMigration"/>
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
