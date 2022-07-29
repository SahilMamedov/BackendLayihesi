using System.Collections.Generic;

namespace BakendProject.Models
{
    public class BasketItem
    {
        public int Id { get; set; }


        public int ProductId { get; set; }
        public Product Product { get; set; }
       
        public string UserId { get; set; }
        public User User { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public double Sum { get; set; }
        public int Count { get; set; }
        public double Price{ get; set; }
        public string ImgUrl { get; set; }
        public double TotalPrice { get; set; }


    }
}
