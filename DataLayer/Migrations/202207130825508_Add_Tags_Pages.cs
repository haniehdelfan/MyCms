namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Tags_Pages : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Pages", new[] { "GroupId" });
            AddColumn("dbo.Pages", "ShowInSlider", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pages", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pages", "Tags", c => c.String());
            CreateIndex("dbo.Pages", "GroupID");
            DropColumn("dbo.Pages", "ShowSlider");
            DropColumn("dbo.Pages", "Created");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pages", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pages", "ShowSlider", c => c.Boolean(nullable: false));
            DropIndex("dbo.Pages", new[] { "GroupID" });
            DropColumn("dbo.Pages", "Tags");
            DropColumn("dbo.Pages", "CreateDate");
            DropColumn("dbo.Pages", "ShowInSlider");
            CreateIndex("dbo.Pages", "GroupId");
        }
    }
}
