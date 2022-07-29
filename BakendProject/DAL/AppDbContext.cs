using BakendProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BakendProject.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<BasketItem> BasketItems{ get; set; }
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages{ get; set; }
        public DbSet<Tag> Tag{ get; set; }
        public DbSet<TagProduct> TagProducts { get; set; }
        public DbSet<Bio> Bios{ get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ModalProduct> modalProducts{ get; set; }
        public DbSet<Blog>  Blogs{ get; set; }
        public DbSet<Subscribe> subscribes { get; set; }
        public DbSet<Comment> comments { get; set; }
    }
}
