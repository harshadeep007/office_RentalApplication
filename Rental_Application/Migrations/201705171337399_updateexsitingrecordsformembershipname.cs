namespace Rental_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateexsitingrecordsformembershipname : DbMigration
    {
        public override void Up()
        {
            Sql("Update MemberShipTypes Set MembershipName='PayAsYouGo' where id=1");
            Sql("Update MemberShipTypes Set MembershipName='Monthly' where id=2");
            Sql("Update MemberShipTypes Set MembershipName='Quarterly' where id=3");
            Sql("Update MemberShipTypes Set MembershipName='Yearly' where id=4");
        }
        
        public override void Down()
        {
        }
    }
}
