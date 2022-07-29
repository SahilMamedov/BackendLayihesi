using BakendProject.Models;
using System.Collections.Generic;

namespace BakendProject.ViewModels
{
    public class HeaderVM
    {
        public int Id { get; set; }
        public List<Category> categories { get; set; }
        public List<Category> subCategories { get; set; }
        public List<Bio> bios { get; set; }
        public List<BasketItem> BasketItems { get; set; }
  
    

    }
}
