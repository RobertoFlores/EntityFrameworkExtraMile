using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkExtraMile.Web.Domain.Model
{
    [Table("Post")]
    public class Post : EntityBase
    {
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public string Url { get; set; }
        public int AuthorID { get; set; }
        [ForeignKey("AuthorID")] //For real? Bleh...
        public virtual Author Author { get; set; }
        public int PostCategoryID { get; set; }
        [ForeignKey("PostCategoryID")]
        public virtual Category Category { get; set; }
    }
}