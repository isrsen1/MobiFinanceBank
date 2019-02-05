using System;
using System.Data.Entity.Migrations;

namespace MobiFinanceBank.DAL.Migrations
{
    /// <summary>
    /// Initial migration
    /// </summary>
    /// <seealso cref="DbMigration"/>
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IBAN = c.String(unicode: false),
                        CardNumber = c.String(unicode: false),
                        Balance = c.Double(nullable: false),
                        DozvoljeniMinus = c.Double(),
                        Blocked = c.Int(),
                        ClientId = c.Int(nullable: false),
                        AccountTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountType", t => t.AccountTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.AccountTypeId);
            
            CreateTable(
                "dbo.AccountType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        OIB = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        PhoneNumber = c.String(unicode: false),
                        Income = c.Double(),
                        ClientType = c.String(unicode: false),
                        Address = c.String(unicode: false),
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BalanceSheet", t => t.BalanceSheetId, cascadeDelete: true)
                .Index(t => t.BalanceSheetId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BalanceSheet", t => t.BalanceSheetId, cascadeDelete: true)
                .Index(t => t.BalanceSheetId);
            
            CreateTable(
                "dbo.Loan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        StartDate = c.DateTime(storeType: "date"),
                        Glavnica = c.Double(nullable: false),
                        RokOtplate = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        KamatnaStopa = c.Double(nullable: false),
                        LoanName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        PhoneNumber = c.String(unicode: false),
                        UserName = c.String(unicode: false),
                        EmployeeTypeId = c.Int(nullable: false),
                        Password = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployeeType", t => t.EmployeeTypeId, cascadeDelete: true)
                .Index(t => t.EmployeeTypeId);
            
            CreateTable(
                "dbo.EmployeeType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SavingAccount",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        Glavnica = c.Double(nullable: false),
                        RokOročenja = c.Int(nullable: false),
                        KonačanIznos = c.Double(),
                        SavingAccountTypeId = c.Int(nullable: false),
                        Interest = c.Double(nullable: false),
                        ClientId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        RKS = c.Double(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SavingAccountType", t => t.SavingAccountTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.SavingAccountTypeId)
                .Index(t => t.ClientId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.SavingAccountType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        EffectiveInterestRate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RepaymentPlan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Interest = c.Double(nullable: false),
                        Anuitet = c.Double(nullable: false),
                        OtplatnaKvota = c.Double(nullable: false),
                        OstatakDuga = c.Double(nullable: false),
                        OtplaceniDio = c.Double(nullable: false),
                        LoanId = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Loan", t => t.LoanId, cascadeDelete: true)
                .Index(t => t.LoanId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SavingAccount", "ClientId", "dbo.Client");
            DropForeignKey("dbo.Loan", "ClientId", "dbo.Client");
            DropForeignKey("dbo.RepaymentPlan", "LoanId", "dbo.Loan");
            DropForeignKey("dbo.SavingAccount", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.SavingAccount", "SavingAccountTypeId", "dbo.SavingAccountType");
            DropForeignKey("dbo.Loan", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Employee", "EmployeeTypeId", "dbo.EmployeeType");
            DropForeignKey("dbo.BalanceSheet", "ClientId", "dbo.Client");
            DropForeignKey("dbo.Liability", "BalanceSheetId", "dbo.BalanceSheet");
            DropForeignKey("dbo.Asset", "BalanceSheetId", "dbo.BalanceSheet");
            DropForeignKey("dbo.Account", "ClientId", "dbo.Client");
            DropForeignKey("dbo.Account", "AccountTypeId", "dbo.AccountType");
            DropIndex("dbo.RepaymentPlan", new[] { "LoanId" });
            DropIndex("dbo.SavingAccount", new[] { "EmployeeId" });
            DropIndex("dbo.SavingAccount", new[] { "ClientId" });
            DropIndex("dbo.SavingAccount", new[] { "SavingAccountTypeId" });
            DropIndex("dbo.Employee", new[] { "EmployeeTypeId" });
            DropIndex("dbo.Loan", new[] { "ClientId" });
            DropIndex("dbo.Loan", new[] { "EmployeeId" });
            DropIndex("dbo.Liability", new[] { "BalanceSheetId" });
            DropIndex("dbo.Asset", new[] { "BalanceSheetId" });
            DropIndex("dbo.BalanceSheet", new[] { "ClientId" });
            DropIndex("dbo.Account", new[] { "AccountTypeId" });
            DropIndex("dbo.Account", new[] { "ClientId" });
            DropTable("dbo.RepaymentPlan");
            DropTable("dbo.SavingAccountType");
            DropTable("dbo.SavingAccount");
            DropTable("dbo.EmployeeType");
            DropTable("dbo.Employee");
            DropTable("dbo.Loan");
            DropTable("dbo.Liability");
            DropTable("dbo.Asset");
            DropTable("dbo.BalanceSheet");
            DropTable("dbo.Client");
            DropTable("dbo.AccountType");
            DropTable("dbo.Account");
        }
    }
}
