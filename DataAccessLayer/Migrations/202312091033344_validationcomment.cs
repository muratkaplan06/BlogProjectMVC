namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationcomment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "UserName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Comments", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Comments", "CommentText", c => c.String(nullable: false, maxLength: 400));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "CommentText", c => c.String(maxLength: 300));
            AlterColumn("dbo.Comments", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Comments", "UserName", c => c.String(maxLength: 50));
        }
    }
}
