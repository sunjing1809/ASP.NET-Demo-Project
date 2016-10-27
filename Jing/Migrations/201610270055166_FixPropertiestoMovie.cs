namespace Jing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixPropertiestoMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Movies", "Genere");
            DropColumn("dbo.Movies", "GenereId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenereId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Genere", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Movies", "GenreId");
            DropColumn("dbo.Movies", "Genre");
        }
    }
}
