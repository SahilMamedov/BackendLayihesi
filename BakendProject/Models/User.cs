using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BakendProject.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Order> Orders { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
