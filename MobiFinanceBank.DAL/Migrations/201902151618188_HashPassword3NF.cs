namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HashPassword3NF : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employee", "HashPasswordId", "dbo.HashedPassword");
            DropIndex("dbo.Employee", new[] { "HashPasswordId" });
            AddColumn("dbo.Employee", "PasswordSalt", c => c.String());
            AddColumn("dbo.Employee", "PasswordHash", c => c.String());
            DropColumn("dbo.Employee", "HashPasswordId");
            DropColumn("dbo.Employee", "hashPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employee", "hashPassword", c => c.String(unicode: false));
            AddColumn("dbo.Employee", "HashPasswordId", c => c.Int(nullable: false));
            DropColumn("dbo.Employee", "PasswordHash");
            DropColumn("dbo.Employee", "PasswordSalt");
            CreateIndex("dbo.Employee", "HashPasswordId");
            AddForeignKey("dbo.Employee", "HashPasswordId", "dbo.HashedPassword", "Id", cascadeDelete: true);
        }
    }
}
