namespace Jing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixPropertytoMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "AddedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "DateAdded");
        }
    }
}
