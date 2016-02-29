namespace mdbill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcontactsandprovider : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Information_ID = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        Others = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Provider",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Information_ID = c.Int(nullable: false),
                        SHORTCUT = c.String(),
                        PROVIDERNAME = c.String(),
                        LASTNAME = c.String(),
                        FIRSTNAME = c.String(),
                        ADDRESS = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Provider");
            DropTable("dbo.Contact");
        }
    }
}
