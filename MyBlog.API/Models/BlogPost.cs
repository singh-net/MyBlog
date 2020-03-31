using System;

namespace MyBlog.API.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Contents { get; set; } 
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Status { get; set; }

        
    }
}