namespace EntityFrameworkExtraMile.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        TwitterHandle = c.String(maxLength: 50),
                        JobTitleID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.JobTitle", t => t.JobTitleID)
                .Index(t => t.JobTitleID);
            
            CreateTable(
                "dbo.Post",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Url = c.String(),
                        AuthorID = c.Int(nullable: false),
                        PostCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Author", t => t.AuthorID, cascadeDelete: true)
                .ForeignKey("dbo.Category", t => t.PostCategoryID, cascadeDelete: true)
                .Index(t => t.AuthorID)
                .Index(t => t.PostCategoryID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.JobTitle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);


            const string initialData = @"SET IDENTITY_INSERT [dbo].[JobTitle] ON 
INSERT [dbo].[JobTitle] ([ID], [Title]) VALUES (1, N'Developer')
INSERT [dbo].[JobTitle] ([ID], [Title]) VALUES (2, N'Partner')
INSERT [dbo].[JobTitle] ([ID], [Title]) VALUES (3, N'Graphic Designer')
INSERT [dbo].[JobTitle] ([ID], [Title]) VALUES (4, N'Marketing Specialist')
INSERT [dbo].[JobTitle] ([ID], [Title]) VALUES (5, N'Project Director')
SET IDENTITY_INSERT [dbo].[JobTitle] OFF

SET IDENTITY_INSERT [dbo].[Author] ON 
INSERT [dbo].[Author] ([ID], [Name], [TwitterHandle], [JobTitleID]) VALUES (1, N'Mike Cole', N'colemike', 1)
INSERT [dbo].[Author] ([ID], [Name], [TwitterHandle], [JobTitleID]) VALUES (2, N'Chris Rouw', N'chrisrouw', 2)
INSERT [dbo].[Author] ([ID], [Name], [TwitterHandle], [JobTitleID]) VALUES (3, N'Jordan McNamara', N'jordan_mcn', 3)
INSERT [dbo].[Author] ([ID], [Name], [TwitterHandle], [JobTitleID]) VALUES (4, N'Megan Horn', N'meganhorn', 4)
INSERT [dbo].[Author] ([ID], [Name], [TwitterHandle], [JobTitleID]) VALUES (5, N'Sue Munnik', N'suemunnik', 5)
SET IDENTITY_INSERT [dbo].[Author] OFF

SET IDENTITY_INSERT [dbo].[Category] ON 
INSERT [dbo].[Category] ([ID], [Name]) VALUES (1, N'Development')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (2, N'Business')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (3, N'Design')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (4, N'Marketing')
SET IDENTITY_INSERT [dbo].[Category] OFF

SET IDENTITY_INSERT [dbo].[Post] ON 
INSERT [dbo].[Post] ([ID], [Title], [Url], [AuthorID], [PostCategoryID]) VALUES (1, N'Entity Framework Extra Mile Part 1', N'http://blog.farreachinc.com/2013/09/23/entity-framework-extra-mike-part-1/', 1, 1)
INSERT [dbo].[Post] ([ID], [Title], [Url], [AuthorID], [PostCategoryID]) VALUES (2, N'Enhanced Dream Big Grow Here Platform Launches', N'http://blog.farreachinc.com/2013/09/19/enhanced-dream-big-grow-here-platform-launches/', 2, 2)
INSERT [dbo].[Post] ([ID], [Title], [Url], [AuthorID], [PostCategoryID]) VALUES (3, N'Why You Need a Mobile Website', N'http://blog.farreachinc.com/2013/09/12/why-you-need-a-mobile-website/', 3, 3)
INSERT [dbo].[Post] ([ID], [Title], [Url], [AuthorID], [PostCategoryID]) VALUES (4, N'Who’s Where? Social Media User Demographics', N'http://blog.farreachinc.com/2013/09/05/whos-where-social-media-user-demographics/', 4, 4)
INSERT [dbo].[Post] ([ID], [Title], [Url], [AuthorID], [PostCategoryID]) VALUES (5, N'Results from Our New Brand, Website, SEO, and Social Media', N'http://blog.farreachinc.com/2013/08/29/results-brand-website-seo-social-media/', 5, 4)
INSERT [dbo].[Post] ([ID], [Title], [Url], [AuthorID], [PostCategoryID]) VALUES (6, N'MailChimp Email Marketing System Gets a Makeover', N'http://blog.farreachinc.com/2013/08/22/mailchimp-email-marketing-system-makeover/', 4, 4)
INSERT [dbo].[Post] ([ID], [Title], [Url], [AuthorID], [PostCategoryID]) VALUES (7, N'Why Your Organization Needs a Blog #Infographic', N'http://blog.farreachinc.com/2013/08/07/infographic-why-your-organization-needs-a-blog/', 4, 4)
INSERT [dbo].[Post] ([ID], [Title], [Url], [AuthorID], [PostCategoryID]) VALUES (8, N'Top 4 Strategic Reasons for Going Mobile First', N'http://blog.farreachinc.com/2013/08/01/top-4-strategic-reasons-mobile-first/', 3, 3)
INSERT [dbo].[Post] ([ID], [Title], [Url], [AuthorID], [PostCategoryID]) VALUES (9, N'What is Online Marketing?', N'http://blog.farreachinc.com/2013/07/25/what-is-online-marketing/', 4, 4)
SET IDENTITY_INSERT [dbo].[Post] OFF";

            Sql(initialData);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Post", new[] { "PostCategoryID" });
            DropIndex("dbo.Post", new[] { "AuthorID" });
            DropIndex("dbo.Author", new[] { "JobTitleID" });
            DropForeignKey("dbo.Post", "PostCategoryID", "dbo.Category");
            DropForeignKey("dbo.Post", "AuthorID", "dbo.Author");
            DropForeignKey("dbo.Author", "JobTitleID", "dbo.JobTitle");
            DropTable("dbo.JobTitle");
            DropTable("dbo.Category");
            DropTable("dbo.Post");
            DropTable("dbo.Author");
        }
    }
}
