using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkExtraMile.Web.Domain.Model
{
    public abstract class EntityBase
    {
        [Key]
        public int ID { get; set; }
    }
}