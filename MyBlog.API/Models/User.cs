using System;
using System.Collections.Generic;

namespace MyBlog.API.Models
{
    public class User
    {
        public int Id { get; set; } 
        public string Username { get; set; }    
        public byte[] PasswordHash { get; set; }    
        public byte[] PasswordSalt { get; set; }    
        public string Name { get; set; }   
        public string Email { get; set; } 
        public DateTime DateOfBirth { get; set; }   
        public string Introduction { get; set; }
        public DateTime LastActive { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Status { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Like> Likers { get; set; }
         public ICollection<Like> Likees { get; set; }
        
    }
}