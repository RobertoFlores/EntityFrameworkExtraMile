namespace EntityFrameworkExtraMile.Web.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitializeEtc : DbMigration
    {
        public override void Up()
        {
            CreateIndex("Category", "Name", true);
            CreateIndex("JobTitle", "Title", true);

            //Note: There is no native support for Stored Procedures, so we have to improvise a bit. If we need the
            //ability to Update the Stored Procedure in a future version, we will need to refactor this a bit...

            const string createFooStoredProc = @"CREATE PROCEDURE Foo AS
                                        BEGIN
                                        -- Do Foo Here.
	                                        SELECT COUNT(*) FROM Post
                                        END";

            Sql(createFooStoredProc);
        }
        
        public override void Down()
        {
            DropIndex("Category", "Name");
            DropIndex("JobTitle", "Title");

            const string dropFooStoredProc = @"DROP PROCEDURE Foo";

            Sql(dropFooStoredProc);
        }
    }
}
