namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contactentity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Subject", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Contacts", "Message", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Message", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "Subject", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(maxLength: 50));
        }
    }
}
