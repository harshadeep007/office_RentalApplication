namespace Rental_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialmodel1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}
