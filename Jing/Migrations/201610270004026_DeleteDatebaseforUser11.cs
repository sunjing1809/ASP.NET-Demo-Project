namespace Jing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDatebaseforUser11 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday=null  where Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
