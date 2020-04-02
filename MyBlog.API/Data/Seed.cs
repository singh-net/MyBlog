using System;
using System.Collections.Generic;
using System.Linq;
using MyBlog.API.Models;
using Newtonsoft.Json;

namespace MyBlog.API.Data
{
    public class Seed
    {
        public static void SeedUsers(DataContext context)
        {
            // Console.Write("Method 1");
            // if (!context.Users.Any())
            // {
            //     var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
            //     var users = JsonConvert.DeserializeObject<List<User>>(userData);
            //     foreach (var user in users)
            //     {
            //         byte[] passwordHash, passwordSalt;
            //         CreatePasswordHash("password", out passwordHash, out passwordSalt);
            //         user.PasswordHash = passwordHash;
            //         user.PasswordSalt = passwordSalt;
            //         user.Username = user.Username.ToLower();
            //         context.Add(user);
            //     }
            //     context.SaveChanges();
            // }

            // Console.WriteLine("Method 2");
            // if(!context.BlogPosts.Any())
            // {
            //     Console.WriteLine("Method 2 Started");
            //     var postsData = System.IO.File.ReadAllText("Data/postsData.json");
            //     var posts = JsonConvert.DeserializeObject<List<BlogPost>>(postsData);
            //     foreach(var post in posts)
            //     {
            //         context.Add(post);
            //     }                
            //     context.SaveChanges();
            // }

            //  Console.WriteLine("Method 3");
            // if(!context.Categories.Any())
            // {
            //     Console.WriteLine("Method 3 Started");
            //     var catData = System.IO.File.ReadAllText("Data/catData.json");
            //     var cats = JsonConvert.DeserializeObject<List<Category>>(catData);
            //     foreach(var cat in cats)
            //     {
            //         context.Add(cat);
            //     }                
            //     context.SaveChanges();
            // }

            //  Console.WriteLine("Method 4");
            // if(!context.BlogPostCategories.Any())
            // {
            //     Console.WriteLine("Method 4 Started");
            //     var bpcData = System.IO.File.ReadAllText("Data/bpcData.json");
            //     var bcats = JsonConvert.DeserializeObject<List<BlogPostCategory>>(bpcData);
            //     foreach(var bcat in bcats)
            //     {
            //         context.Add(bcat);
            //     }                
            //     context.SaveChanges();
            // }




        }
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}