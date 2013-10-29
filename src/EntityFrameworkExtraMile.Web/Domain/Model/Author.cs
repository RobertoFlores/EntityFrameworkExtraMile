using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EntityFrameworkExtraMile.Web.Domain.Model
{
    public class Author : EntityBase
    {
        public Author()
        {
            Posts = new Collection<Post>();
        }

        public string Name { get; set; }
        public string TwitterHandle { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual JobTitle JobTitle { get; set; }
    }
}