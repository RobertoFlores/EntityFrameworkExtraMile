using System.Data.Entity.ModelConfiguration;
using EntityFrameworkExtraMile.Web.Domain.Model;

namespace EntityFrameworkExtraMile.Web.DataAccess
{
    public class JobTitleConfiguration : EntityTypeConfiguration<JobTitle>
    {
        public JobTitleConfiguration()
        {
            HasKey(title => title.ID);
            Property(title => title.Title).HasMaxLength(50).IsRequired();
        }
    }
}