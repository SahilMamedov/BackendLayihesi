using BakendProject.Models;
using System.Collections.Generic;

namespace BakendProject.ViewModels
{
    public class DetailVM
    {
        public  int Id { get; set; }
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public List<Comment> comments { get; set; }
    }
}
