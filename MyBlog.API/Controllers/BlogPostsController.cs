using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlog.API.Data;
using MyBlog.API.Dtos;

namespace MyBlog.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostsController : ControllerBase
    {
        private readonly IBlogPostRepository _repo;
        private readonly IMapper _mapper;
        public BlogPostsController(IBlogPostRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;

        }


        [HttpGet]
        public async Task<IActionResult> GetBlogPosts()
        {
            var blogPosts = await _repo.GetBlogPosts();
            //var postsToReturn = _mapper.Map<BlogPostsForListDto>(blogPosts);
            var postsToReturn =  blogPosts
                                 .Select(post => new {
                        Id = post.Id,
                        Title = post.Title,
                        Contents = post.Contents,
                        DateCreated = post.DateCreated,
                        DateModified = post.DateModified,
                        Excerpt = post.Excerpt,
                        Status = post.Status,
                        
                        Categories = post.BlogPostCategories
                                    .Select(cats => new {
                                        Id = cats.Category.Id,
                                        Name = cats.Category.Name

                                    })
                    })
                    .ToList();

            return Ok(postsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogPost(int id)
        {
            var blogPost = await _repo.GetBlogPost(id);
            return Ok(blogPost);
        }
    }
}