namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JoinDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "JoinDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "JoinDate");
        }
    }
}
