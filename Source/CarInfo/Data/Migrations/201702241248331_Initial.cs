namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Make = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        RegistrationNumber = c.String(nullable: false),
                        VinNumber = c.String(),
                        YearOfProduction = c.DateTime(nullable: false),
                        TechnicalInspectionDueDate = c.DateTime(nullable: false),
                        PrimaryInsuranceDueDate = c.DateTime(nullable: false),
                        AdditionalInsuranceDueDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drivers");
            DropTable("dbo.Cars");
        }
    }
}
