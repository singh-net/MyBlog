using System;

namespace MyBlog.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; } 
        public string Username { get; set; }  
        public string Name { get; set; }   
        public string Email { get; set; } 
        public int Age { get; set; }   
        public string Introduction { get; set; }
        public DateTime LastActive { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Status { get; set; }
        public string PhotoUrl { get; set; }
        
    }
}