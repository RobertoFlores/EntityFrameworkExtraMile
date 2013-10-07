using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkExtraMile.Web.Domain.Model
{
    [Table("Author")]
    public class Author : EntityBase
    {
        public Author()
        {
            Posts = new Collection<Post>();
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string TwitterHandle { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public int JobTitleID { get; set; }
        [ForeignKey("JobTitleID")]
        public virtual JobTitle JobTitle { get; set; }
    }
}