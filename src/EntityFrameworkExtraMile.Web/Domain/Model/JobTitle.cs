using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EntityFrameworkExtraMile.Web.Domain.Model
{
    public class JobTitle : EntityBase
    {
        public JobTitle()
        {
            Authors = new Collection<Author>();
        }
        
        public string Title { get; set; }
        public virtual ICollection<Author> Authors { get; set; } 
    }
}