namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BalanceSheetDeleted : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Asset", "BalanceSheetId", "dbo.BalanceSheet");
            DropForeignKey("dbo.Liability", "BalanceSheetId", "dbo.BalanceSheet");
            DropForeignKey("dbo.BalanceSheet", "ClientId", "dbo.Client");
            DropIndex("dbo.BalanceSheet", new[] { "ClientId" });
            DropIndex("dbo.Asset", new[] { "BalanceSheetId" });
            DropIndex("dbo.Liability", new[] { "BalanceSheetId" });
            DropTable("dbo.BalanceSheet");
            DropTable("dbo.Asset");
            DropTable("dbo.Liability");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Liability",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        LiabilityValue = c.Double(nullable: false),
                        LiabilityType = c.String(unicode: false),
                        BalanceSheetId = c.Int(nullable: false),
                        Category = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Asset",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rok = c.Int(nullable: false),
                        Name = c.String(unicode: false),
                        Value = c.Double(nullable: false),
                        BalanceSheetId = c.Int(nullable: false),
                        Category = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BalanceSheet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BalanceSheetYear = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Liability", "BalanceSheetId");
            CreateIndex("dbo.Asset", "BalanceSheetId");
            CreateIndex("dbo.BalanceSheet", "ClientId");
            AddForeignKey("dbo.BalanceSheet", "ClientId", "dbo.Client", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Liability", "BalanceSheetId", "dbo.BalanceSheet", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Asset", "BalanceSheetId", "dbo.BalanceSheet", "Id", cascadeDelete: true);
        }
    }
}
