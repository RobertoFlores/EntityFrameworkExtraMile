using System.Collections.Generic;

namespace EntityFrameworkExtraMile.Web.Models
{
    public class AuthorViewModel
    {
        public string Name { get; set; }
        public string TwitterHandle { get; set; }
        public IEnumerable<Post> Posts { get; set; }

        public class Post
        {
            public string Title { get; set; }
            public string Url { get; set; }
            public string Category { get; set; }
        }
    }
}