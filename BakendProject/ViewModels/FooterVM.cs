using BakendProject.Models;
using System.Collections.Generic;

namespace BakendProject.ViewModels
{
    public class FooterVM
    {
        public int Id{ get; set; }
        public List<Bio> bios { get; set; }
        public List<Brand> brands { get; set; }
        public List<Blog> blogs { get; set; }
    }
}
