namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Client", "ClientTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Client", "ClientTypeId");
            AddForeignKey("dbo.Client", "ClientTypeId", "dbo.ClientType", "Id", cascadeDelete: true);
            DropColumn("dbo.Client", "ClientType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Client", "ClientType", c => c.String(unicode: false));
            DropForeignKey("dbo.Client", "ClientTypeId", "dbo.ClientType");
            DropIndex("dbo.Client", new[] { "ClientTypeId" });
            DropColumn("dbo.Client", "ClientTypeId");
            DropTable("dbo.ClientType");
        }
    }
}
