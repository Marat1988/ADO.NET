namespace GameEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test2301 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameModes",
                c => new
                    {
                        GameModeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.GameModeId)
                .Index(t => t.Name, unique: true, name: "IX_Game_Name");
            
            AddColumn("dbo.Games", "GameModeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Games", "GameModeId");
            AddForeignKey("dbo.Games", "GameModeId", "dbo.GameModes", "GameModeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "GameModeId", "dbo.GameModes");
            DropIndex("dbo.GameModes", "IX_Game_Name");
            DropIndex("dbo.Games", new[] { "GameModeId" });
            DropColumn("dbo.Games", "GameModeId");
            DropTable("dbo.GameModes");
        }
    }
}
