using System.Data.Entity.ModelConfiguration;
using EntityFrameworkExtraMile.Web.Domain.Model;

namespace EntityFrameworkExtraMile.Web.DataAccess
{
    public class AuthorConfiguration : EntityTypeConfiguration<Author>
    {
        public AuthorConfiguration()
        {
            HasKey(author => author.ID);
            Property(author => author.Name).HasMaxLength(50).IsRequired();
            Property(author => author.TwitterHandle).HasMaxLength(50);

            HasOptional(author => author.JobTitle)
                .WithMany(title => title.Authors)
                .Map(author => author.MapKey("JobTitleID"));
        }
    }
}