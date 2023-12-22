namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogtable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "BlogTitle", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Blogs", "BlogImage", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Blogs", "BlogContent", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "BlogContent", c => c.String());
            AlterColumn("dbo.Blogs", "BlogImage", c => c.String(maxLength: 100));
            AlterColumn("dbo.Blogs", "BlogTitle", c => c.String(maxLength: 100));
        }
    }
}
