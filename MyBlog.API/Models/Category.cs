using System.Collections.Generic;

namespace MyBlog.API.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Status { get; set; }  
        public int Parent { get; set; }        
        public ICollection<BlogPostCategory> BlogPostCategories { get; set; }

    }
}