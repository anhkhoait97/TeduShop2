namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.PostTags", "TagID");
            AddForeignKey("dbo.PostTags", "TagID", "dbo.Tags", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostTags", "TagID", "dbo.Tags");
            DropIndex("dbo.PostTags", new[] { "TagID" });
        }
    }
}
