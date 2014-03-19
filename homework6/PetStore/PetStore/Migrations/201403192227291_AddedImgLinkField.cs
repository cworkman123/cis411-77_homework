namespace PetStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImgLinkField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Manages", "ImgLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Manages", "ImgLink");
        }
    }
}
