namespace HamroSite.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_StudentReg_To_DB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentRegs",
                c => new
                    {
                        StudentRegID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Contact = c.String(),
                        ParentName = c.String(),
                        OnCreated = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.StudentRegID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentRegs");
        }
    }
}
