namespace FinalProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Weapons", "IX_WeaponsNameUnique");
            AddColumn("dbo.Weapons", "Model", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Weapons", "Model", unique: true, name: "IX_WeaponsNameUnique");
            DropColumn("dbo.Weapons", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Weapons", "Name", c => c.String(nullable: false, maxLength: 50));
            DropIndex("dbo.Weapons", "IX_WeaponsNameUnique");
            DropColumn("dbo.Weapons", "Model");
            CreateIndex("dbo.Weapons", "Name", unique: true, name: "IX_WeaponsNameUnique");
        }
    }
}
