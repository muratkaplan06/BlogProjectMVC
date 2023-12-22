namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubscribeMailsEnity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubscribeMails", "EmailAddress", c => c.String(nullable: false, maxLength: 500));
            DropColumn("dbo.SubscribeMails", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SubscribeMails", "Email", c => c.String());
            DropColumn("dbo.SubscribeMails", "EmailAddress");
        }
    }
}
