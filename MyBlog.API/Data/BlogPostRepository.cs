using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBlog.API.Models;

namespace MyBlog.API.Data
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly DataContext _context;
        public BlogPostRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async  Task<BlogPost> GetBlogPost(int id)
        {
            var blogPost = await _context.BlogPosts.Include(c => c.BlogPostCategories).FirstOrDefaultAsync(p => p.Id == id);
            return blogPost;
        }

        public async Task<IEnumerable<BlogPost>> GetBlogPosts()
        {            
            var blogPosts = await _context.BlogPosts
                    .Include(c => c.BlogPostCategories)                   
                     .ThenInclude(a => a.Category)   
                    //.ThenInclude(d => d.Name)        
                    .ToListAsync();

                    

            return blogPosts;
        }

        public async Task<bool> SaveAll()
        {
             return await _context.SaveChangesAsync() > 0;
        }
    }
}