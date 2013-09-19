namespace EntityFrameworkExtraMile.Web.Domain.Model
{
    public class Post : EntityBase
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public virtual Author Author { get; set; }
    }
}