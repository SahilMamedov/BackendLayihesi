using System;

namespace BakendProject.Models
{
    public class Comment
    {
        public int Id{ get; set; }
        public string Desc{ get; set; }
        public Nullable <DateTime> CreatedAt { get; set; }
     
        public Product product { get; set; }
        public int ProductId { get; set; }
        public AppUser appUser{ get; set; }
        public string AppUserId{ get; set; }
    }
}
