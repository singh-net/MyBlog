using System.Collections.Generic;
using System.Threading.Tasks;
using MyBlog.API.Models;

namespace MyBlog.API.Data
{
    public interface IBlogPostRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<BlogPost>> GetBlogPosts();
        Task<BlogPost> GetBlogPost(int id);      
       
         
    }
}