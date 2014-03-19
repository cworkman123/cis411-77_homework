namespace PetStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Manages", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Manages", "Description", c => c.String(maxLength: 500));
        }
    }
}
