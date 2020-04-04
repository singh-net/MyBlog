using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.API.Data;

namespace MyBlog.API.Helpers
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
           var resultsContext = await next();

           var userId = int.Parse(resultsContext.HttpContext.User
           .FindFirst(ClaimTypes.NameIdentifier).Value);

           var repo = resultsContext.HttpContext.RequestServices.GetService<IBlogRepository>();

           var user = await repo.GetUser(userId);

           user.LastActive = DateTime.Now;

           await repo.SaveAll();

        }
    }
}