using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkExtraMile.Web.Domain.Model
{
    [Table("JobTitle")]
    public class JobTitle : EntityBase
    {
        public JobTitle()
        {
            Authors = new Collection<Author>();
        }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        public virtual ICollection<Author> Authors { get; set; } 
    }
}