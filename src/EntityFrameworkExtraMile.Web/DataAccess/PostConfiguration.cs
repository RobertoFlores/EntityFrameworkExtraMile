using System.Data.Entity.ModelConfiguration;
using EntityFrameworkExtraMile.Web.Domain.Model;

namespace EntityFrameworkExtraMile.Web.DataAccess
{
    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            HasKey(post => post.ID);
            Property(post => post.Title).HasMaxLength(150).IsRequired();
            Property(post => post.Title).IsRequired();

            HasRequired(post => post.Author)
                .WithMany(author => author.Posts)
                .Map(configuration => configuration.MapKey("AuthorID"));

            HasRequired(post => post.Category)
                .WithMany(category => category.Posts)
                .Map(post => post.MapKey("PostCategoryID"));
        }
    }
}