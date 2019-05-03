namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genre1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Genre",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Name = c.String(),
               })
               .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
        }
    }
}
