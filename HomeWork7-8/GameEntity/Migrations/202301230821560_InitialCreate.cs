namespace GameEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.CompanyId)
                .Index(t => t.Name, unique: true, name: "IX_Game_Name");
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        StyleGameId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.StyleGames", t => t.StyleGameId, cascadeDelete: true)
                .Index(t => t.Name, unique: true, name: "IX_Game_Name")
                .Index(t => t.StyleGameId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.StyleGames",
                c => new
                    {
                        StyleGameId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.StyleGameId)
                .Index(t => t.Name, unique: true, name: "IX_Game_Name");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "StyleGameId", "dbo.StyleGames");
            DropForeignKey("dbo.Games", "CompanyId", "dbo.Companies");
            DropIndex("dbo.StyleGames", "IX_Game_Name");
            DropIndex("dbo.Games", new[] { "CompanyId" });
            DropIndex("dbo.Games", new[] { "StyleGameId" });
            DropIndex("dbo.Games", "IX_Game_Name");
            DropIndex("dbo.Companies", "IX_Game_Name");
            DropTable("dbo.StyleGames");
            DropTable("dbo.Games");
            DropTable("dbo.Companies");
        }
    }
}
