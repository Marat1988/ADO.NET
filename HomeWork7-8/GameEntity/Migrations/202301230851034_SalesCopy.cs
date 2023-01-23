namespace GameEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalesCopy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "SalesCopy", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "SalesCopy");
        }
    }
}
