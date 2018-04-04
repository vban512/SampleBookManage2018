namespace AbpMpaMvcEfInit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Customer_Entity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Namesimple = c.String(nullable: false, maxLength: 32),
                        Bh = c.String(nullable: false, maxLength: 16),
                        Address = c.String(),
                        Telephone = c.String(),
                        State = c.Byte(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
