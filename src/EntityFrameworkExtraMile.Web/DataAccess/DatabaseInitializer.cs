using System.Data.Entity;
using EntityFrameworkExtraMile.Web.Domain.Model;

namespace EntityFrameworkExtraMile.Web.DataAccess
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var mike = new Author { Name = "Mike Cole", TwitterHandle = "colemike" };
            var chris = new Author { Name = "Chris Rouw", TwitterHandle = "chrisrouw" };
            var jordan = new Author { Name = "Jordan McNamara", TwitterHandle = "jordan_mcn" };
            var megan = new Author { Name = "Megan Horn", TwitterHandle = "meganhorn" };
            var sue = new Author { Name = "Sue Munnik", TwitterHandle = "suemunnik" };

            context.Posts.Add(new Post { Author = mike, Title = "Entity Framework Extra Mile Part 1", Url = "http://blog.farreachinc.com/2013/09/23/entity-framework-extra-mike-part-1/" });
            context.Posts.Add(new Post { Author = chris, Title = "Enhanced Dream Big Grow Here Platform Launches", Url = "http://blog.farreachinc.com/2013/09/19/enhanced-dream-big-grow-here-platform-launches/" });
            context.Posts.Add(new Post { Author = jordan, Title = "Why You Need a Mobile Website", Url = "http://blog.farreachinc.com/2013/09/12/why-you-need-a-mobile-website/" });
            context.Posts.Add(new Post { Author = megan, Title = "Who’s Where? Social Media User Demographics", Url = "http://blog.farreachinc.com/2013/09/05/whos-where-social-media-user-demographics/" });
            context.Posts.Add(new Post { Author = sue, Title = "Results from Our New Brand, Website, SEO, and Social Media", Url = "http://blog.farreachinc.com/2013/08/29/results-brand-website-seo-social-media/" });
            context.Posts.Add(new Post { Author = megan, Title = "MailChimp Email Marketing System Gets a Makeover", Url = "http://blog.farreachinc.com/2013/08/22/mailchimp-email-marketing-system-makeover/" });
            context.Posts.Add(new Post { Author = megan, Title = "Why Your Organization Needs a Blog #Infographic", Url = "http://blog.farreachinc.com/2013/08/07/infographic-why-your-organization-needs-a-blog/" });
            context.Posts.Add(new Post { Author = jordan, Title = "Top 4 Strategic Reasons for Going Mobile First", Url = "http://blog.farreachinc.com/2013/08/01/top-4-strategic-reasons-mobile-first/" });
            context.Posts.Add(new Post { Author = megan, Title = "What is Online Marketing?", Url = "http://blog.farreachinc.com/2013/07/25/what-is-online-marketing/" });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}