using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using EntityFrameworkExtraMile.Web.DataAccess;
using EntityFrameworkExtraMile.Web.Models;

namespace EntityFrameworkExtraMile.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PostsViewModel[] model;

            using (var context = new BlogContext())
            {
                //Uses string notation - lots of typos!
                //var posts = context.Posts
                //                   .Include("Author")
                //                   .ToArray();

                //Uses lambda notation - Intellisense and easy refactoring = love
                //Note: include System.Data.Entity to use.
                var posts = context.Posts
                                   .Include(p => p.Author.JobTitle)
                                   .ToArray();

                model = (from post in posts
                         select new PostsViewModel
                             {
                                 Title = post.Title,
                                 Url = post.Url,
                                 AuthorName = post.Author.Name,
                                 AuthorTwitterHandle = post.Author.TwitterHandle,
                                 AuthorID = post.Author.ID,
                                 JobTitle = post.Author.JobTitle.Title
                             }).ToArray();
            }

            return View(model);
        }

        public ActionResult Author(int id)
        {
            AuthorViewModel model;

            using (var context = new BlogContext())
            {
                var author = context.Authors
                                    .Include(a => a.Posts.Select(p => p.Category))
                                    .Single(a => a.ID == id);

                model = new AuthorViewModel
                    {
                        Name = author.Name,
                        TwitterHandle = author.TwitterHandle,
                        Posts = (from post in author.Posts
                                 select new AuthorViewModel.Post
                                     {
                                         Title = post.Title,
                                         Url = post.Url,
                                         Category = post.Category.Name
                                     }).ToArray()
                    };
            }

            return View(model);
        }
    }
}