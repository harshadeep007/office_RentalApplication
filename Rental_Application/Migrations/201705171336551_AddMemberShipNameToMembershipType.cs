namespace Rental_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "MembershipName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "MembershipName");
        }
    }
}
