namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aboutcontenupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "AboutContent1", c => c.String());
            AlterColumn("dbo.Abouts", "AboutContent2", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "AboutContent2", c => c.String(maxLength: 500));
            AlterColumn("dbo.Abouts", "AboutContent1", c => c.String(maxLength: 500));
        }
    }
}
