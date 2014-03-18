namespace PetStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Manages", "Name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Manages", "Description", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Manages", "Description", c => c.String());
            AlterColumn("dbo.Manages", "Name", c => c.String());
        }
    }
}
