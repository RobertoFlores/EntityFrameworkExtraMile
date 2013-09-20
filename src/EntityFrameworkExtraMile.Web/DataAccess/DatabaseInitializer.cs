using System.Data.Entity;
using EntityFrameworkExtraMile.Web.Domain.Model;

namespace EntityFrameworkExtraMile.Web.DataAccess
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var develper = new JobTitle { Title = "Developer" };
            var partner = new JobTitle { Title = "Partner" };
            var designer = new JobTitle { Title = "Graphic Designer" };
            var marketingSpecialist = new JobTitle { Title = "Marketing Specialist" };
            var projectDirector = new JobTitle { Title = "Project Director" };

            var mike = new Author { Name = "Mike Cole", TwitterHandle = "colemike", JobTitle = develper};
            var chris = new Author { Name = "Chris Rouw", TwitterHandle = "chrisrouw", JobTitle = partner };
            var jordan = new Author { Name = "Jordan McNamara", TwitterHandle = "jordan_mcn", JobTitle = designer };
            var megan = new Author { Name = "Megan Horn", TwitterHandle = "meganhorn", JobTitle = marketingSpecialist };
            var sue = new Author { Name = "Sue Munnik", TwitterHandle = "suemunnik", JobTitle = projectDirector };

            var development = new Category { Name = "Development" };
            var business = new Category { Name = "Business" };
            var design = new Category { Name = "Design" };
            var marketing = new Category { Name = "Marketing" };

            context.Posts.Add(new Post { Author = mike, Title = "Entity Framework Extra Mile Part 1", Url = "http://blog.farreachinc.com/2013/09/23/entity-framework-extra-mike-part-1/", Category = development });
            context.Posts.Add(new Post { Author = chris, Title = "Enhanced Dream Big Grow Here Platform Launches", Url = "http://blog.farreachinc.com/2013/09/19/enhanced-dream-big-grow-here-platform-launches/", Category = business });
            context.Posts.Add(new Post { Author = jordan, Title = "Why You Need a Mobile Website", Url = "http://blog.farreachinc.com/2013/09/12/why-you-need-a-mobile-website/", Category = design });
            context.Posts.Add(new Post { Author = megan, Title = "Who’s Where? Social Media User Demographics", Url = "http://blog.farreachinc.com/2013/09/05/whos-where-social-media-user-demographics/", Category = marketing });
            context.Posts.Add(new Post { Author = sue, Title = "Results from Our New Brand, Website, SEO, and Social Media", Url = "http://blog.farreachinc.com/2013/08/29/results-brand-website-seo-social-media/", Category = marketing });
            context.Posts.Add(new Post { Author = megan, Title = "MailChimp Email Marketing System Gets a Makeover", Url = "http://blog.farreachinc.com/2013/08/22/mailchimp-email-marketing-system-makeover/", Category = marketing });
            context.Posts.Add(new Post { Author = megan, Title = "Why Your Organization Needs a Blog #Infographic", Url = "http://blog.farreachinc.com/2013/08/07/infographic-why-your-organization-needs-a-blog/", Category = marketing });
            context.Posts.Add(new Post { Author = jordan, Title = "Top 4 Strategic Reasons for Going Mobile First", Url = "http://blog.farreachinc.com/2013/08/01/top-4-strategic-reasons-mobile-first/", Category = design });
            context.Posts.Add(new Post { Author = megan, Title = "What is Online Marketing?", Url = "http://blog.farreachinc.com/2013/07/25/what-is-online-marketing/", Category = marketing });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}