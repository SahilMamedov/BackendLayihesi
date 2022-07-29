using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BakendProject.Models
{
    public class AppUser : IdentityUser
    { 

            public string Name { get; set; }

            public List<Order> Orders { get; set; }
            public List<BasketItem> BasketItems { get; set; }
              public List <Comment> comments{ get; set; }

    }
}
