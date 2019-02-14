namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HashPasswordMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HashedPassword",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hash = c.String(),
                        Salt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employee", "OIB", c => c.Int(nullable: false));
            AddColumn("dbo.Employee", "HashPasswordId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "HashPasswordId");
            AddForeignKey("dbo.Employee", "HashPasswordId", "dbo.HashedPassword", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "HashPasswordId", "dbo.HashedPassword");
            DropIndex("dbo.Employee", new[] { "HashPasswordId" });
            DropColumn("dbo.Employee", "HashPasswordId");
            DropColumn("dbo.Employee", "OIB");
            DropTable("dbo.HashedPassword");
        }
    }
}
