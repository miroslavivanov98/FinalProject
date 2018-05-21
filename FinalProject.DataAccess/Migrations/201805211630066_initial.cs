namespace FinalProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Manafacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Address = c.String(maxLength: 20),
                        Phone = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManafacturerId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Caliber = c.String(nullable: false, maxLength: 20),
                        Weight = c.String(nullable: false, maxLength: 20),
                        BarrelLength = c.String(nullable: false, maxLength: 20),
                        Price = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manafacturers", t => t.ManafacturerId, cascadeDelete: true)
                .Index(t => t.ManafacturerId)
                .Index(t => t.Name, unique: true, name: "IX_WeaponsNameUnique");
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false, maxLength: 20),
                        StreetName = c.String(maxLength: 20),
                        WorkTime = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 20),
                        PassHash = c.String(nullable: false, maxLength: 20),
                        IsAdmin = c.String(nullable: false, maxLength: 20),
                        IsBanned = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Weapons", "ManafacturerId", "dbo.Manafacturers");
            DropIndex("dbo.Weapons", "IX_WeaponsNameUnique");
            DropIndex("dbo.Weapons", new[] { "ManafacturerId" });
            DropTable("dbo.Users");
            DropTable("dbo.Shops");
            DropTable("dbo.Weapons");
            DropTable("dbo.Manafacturers");
            DropTable("dbo.Categories");
        }
    }
}
