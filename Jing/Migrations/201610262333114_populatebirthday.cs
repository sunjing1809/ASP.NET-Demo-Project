namespace Jing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatebirthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday=''  where Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
