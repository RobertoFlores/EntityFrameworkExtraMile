namespace EntityFrameworkExtraMile.Web.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailToAuthor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Author", "Email", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Author", "Email");
        }
    }
}