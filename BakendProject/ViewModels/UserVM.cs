using BakendProject.Models;
using System.Collections.Generic;

namespace BakendProject.ViewModels
{
    public class UserVM
    {
        public int Id{ get; set; }
        public List <BasketItem> basketItems{ get; set; }
        public List<OrderItem> orderItems { get; set; }
        public AppUser appUser{ get; set; }
    }
}
