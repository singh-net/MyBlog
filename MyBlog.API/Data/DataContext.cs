using Microsoft.EntityFrameworkCore;
using MyBlog.API.Models;

namespace MyBlog.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)  {  }
        public DbSet<BlogPost> BlogPosts { get; set; }
    
    }
}