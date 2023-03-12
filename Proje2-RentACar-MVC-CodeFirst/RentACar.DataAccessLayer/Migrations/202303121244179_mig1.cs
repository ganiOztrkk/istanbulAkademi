namespace RentACar.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        ModelYear = c.Int(nullable: false),
                        Km = c.Int(nullable: false),
                        Color = c.String(),
                        Price = c.Double(nullable: false),
                        Image1 = c.String(),
                        Image2 = c.String(),
                        Image3 = c.String(),
                        Image4 = c.String(),
                    })
                .PrimaryKey(t => t.CarID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
