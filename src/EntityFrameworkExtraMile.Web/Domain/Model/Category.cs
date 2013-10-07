using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkExtraMile.Web.Domain.Model
{
    [Table("Category")]
    public class Category : EntityBase
    {
        public Category()
        {
            Posts = new Collection<Post>();
        }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}