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
                var posts = context.Posts.ToArray();

                model = (from post in posts
                         select new PostsViewModel
                             {
                                 Title = post.Title,
                                 Url = post.Url,
                                 AuthorName = post.Author.Name,
                                 AuthorTwitterHandle = post.Author.TwitterHandle
                             }).ToArray();
            }

            return View(model);
        }
    }
}