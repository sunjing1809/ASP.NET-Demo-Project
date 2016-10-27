namespace Jing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertiestoMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genere", c => c.String(nullable: false));
            AddColumn("dbo.Movies", "GenereId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "AddedDate");
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "GenereId");
            DropColumn("dbo.Movies", "Genere");
        }
    }
}
