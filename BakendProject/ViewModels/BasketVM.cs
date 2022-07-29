using BakendProject.Models;

namespace BakendProject.ViewModels
{
    public class BasketVM
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
       
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int Sum{ get; set; }
        public int Count { get; set; }
        public int TotalPrice { get; set; }
    }
}
