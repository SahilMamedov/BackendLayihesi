using BakendProject.Models;
using System.Collections.Generic;

namespace BakendProject.ViewModels
{
    public class HomeVM
    {
        public int Id{ get; set; }
        public List<Slider> sliders{ get; set; }
        public List<ModalProduct> modalProducts{ get; set; }
        public List<Product> products{ get; set; }
        public List<Category> categories{ get; set; }
    
    }
}
