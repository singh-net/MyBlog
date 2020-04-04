using System.Collections.Generic;
using System.Threading.Tasks;
using MyBlog.API.Helpers;
using MyBlog.API.Models;

namespace MyBlog.API.Data
{
    public interface IBlogRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<PagedList<User>> GetUsers(UserParams userParams);
        Task<User> GetUser(int id);
        Task<Photo> GetPhoto(int id);
        Task<Photo> GetMainPhotoForUser(int userId);

    }
}