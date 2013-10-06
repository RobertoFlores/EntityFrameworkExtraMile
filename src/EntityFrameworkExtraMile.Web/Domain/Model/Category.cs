using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EntityFrameworkExtraMile.Web.Domain.Model
{
    public class Category : EntityBase
    {
        public Category()
        {
            Posts = new Collection<Post>();
        }
        
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}