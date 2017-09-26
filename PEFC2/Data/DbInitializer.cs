using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PEFC2.Models;
using PEFC2.Controllers;

namespace PEFC2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BlogContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Blog.
            if (context.Blogs.Any())
            {
                return;   // DB has been seeded
            }

            var blogs = new Blog[]
            {
                new Blog{Name="Blog1",Url ="blog1.blogspot.com"},
                new Blog{Name="Blog2",Url ="blog2.blogspot.com"},
                new Blog{Name="Blog3",Url ="blog3.blogspot.com"}
            
            };
            foreach (Blog s in blogs)
            {
                context.Blogs.Add(s);
            }
            context.SaveChanges();

            var posts = new Post []
            {
                new Post{BlogId=1,Title="Post1.1",Description="Post number 1.1"},
                new Post{BlogId=1,Title="Post1.2",Description="Post number 1.2"},
                new Post{BlogId=2,Title="Post2.1",Description="Post number 2.1"},
                new Post{BlogId=3,Title="Post3.1",Description="Post number 3.1"},
                new Post{BlogId=3,Title="Post3.2",Description="Post number 3.2"}
            
            };
            foreach (Post e in posts)
            {
                context.Posts.Add(e);
            }
            context.SaveChanges();
        }
    }
}