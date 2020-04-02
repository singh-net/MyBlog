using System;
using System.Collections.Generic;
using MyBlog.API.Models;

namespace MyBlog.API.Dtos
{
    public class BlogPostsForListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Contents { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Status { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}