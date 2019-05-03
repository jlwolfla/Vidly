namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JoinDate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "JoinDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "JoinDate", c => c.DateTime(nullable: false));
        }
    }
}
