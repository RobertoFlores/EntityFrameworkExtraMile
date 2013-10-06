using System.Data.Entity.ModelConfiguration;
using EntityFrameworkExtraMile.Web.Domain.Model;

namespace EntityFrameworkExtraMile.Web.DataAccess
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            HasKey(cat => cat.ID);
            Property(cat => cat.Name).HasMaxLength(50).IsRequired();
        }
    }
}