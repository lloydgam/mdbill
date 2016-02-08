namespace mdbill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOtherInformation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Information", "Others", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Information", "Others");
        }
    }
}
