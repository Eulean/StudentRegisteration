namespace StudentRegisteration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class startingDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        State = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Township = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentType = c.String(nullable: false),
                        TransactionDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        SemesterNumber = c.Int(nullable: false),
                        Course = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        NRC = c.Short(nullable: false),
                        RegDate = c.DateTime(nullable: false),
                        GenderId = c.Byte(nullable: false),
                        SemesterId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        PaymentId = c.Int(nullable: false),
                        ApplicationId = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .ForeignKey("dbo.Payments", t => t.PaymentId, cascadeDelete: true)
                .ForeignKey("dbo.Semesters", t => t.SemesterId, cascadeDelete: true)
                .Index(t => t.GenderId)
                .Index(t => t.SemesterId)
                .Index(t => t.AddressId)
                .Index(t => t.PaymentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "SemesterId", "dbo.Semesters");
            DropForeignKey("dbo.Students", "PaymentId", "dbo.Payments");
            DropForeignKey("dbo.Students", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Students", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Students", new[] { "PaymentId" });
            DropIndex("dbo.Students", new[] { "AddressId" });
            DropIndex("dbo.Students", new[] { "SemesterId" });
            DropIndex("dbo.Students", new[] { "GenderId" });
            DropTable("dbo.Students");
            DropTable("dbo.Semesters");
            DropTable("dbo.Payments");
            DropTable("dbo.Genders");
            DropTable("dbo.Addresses");
        }
    }
}
