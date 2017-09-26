using PEFC2.Controllers;

namespace PEFC2.Models
{
    public enum TypePost
    {
        A, B, C, D, F
    }

    public class Post
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TypePost? TypePost { get; set; }

        public Blog Blog { get; set; }
        
    }
}