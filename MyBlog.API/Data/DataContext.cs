using Microsoft.EntityFrameworkCore;
using MyBlog.API.Models;

namespace MyBlog.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPostCategory>().HasKey(bpc => new { bpc.BlogPostId, bpc.CategoryId });

            modelBuilder.Entity<BlogPostCategory>()
            .HasOne<BlogPost>(bp => bp.BlogPost)
            .WithMany(s => s.BlogPostCategories)
            .HasForeignKey(bc => bc.BlogPostId);

            modelBuilder.Entity<BlogPostCategory>()
            .HasOne<Category>(c => c.Category)
            .WithMany(s => s.BlogPostCategories)
            .HasForeignKey(bc => bc.CategoryId);

            modelBuilder.Entity<Like>().HasKey(k => new {k.LikerId, k.LikeeId});
            modelBuilder.Entity<Like>()
                .HasOne(u => u.Likee)
                .WithMany(u => u.Likers)
                .HasForeignKey(u => u.LikeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Like>()
                .HasOne(u => u.Liker)
                .WithMany(u => u.Likees)
                .HasForeignKey(u => u.LikerId)
                .OnDelete(DeleteBehavior.Restrict);               
            

        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogPostCategory> BlogPostCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Like> Likes { get; set; }

    }
}