namespace Rental_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingRemarkstoCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Remarks", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Remarks");
        }
    }
}
