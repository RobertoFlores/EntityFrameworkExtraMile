using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EntityFrameworkExtraMile.Web.Domain.Model;

namespace EntityFrameworkExtraMile.Web.DataAccess
{
    public class BlogContext : DbContext
    {
        public BlogContext()
            : base("Blog")
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}