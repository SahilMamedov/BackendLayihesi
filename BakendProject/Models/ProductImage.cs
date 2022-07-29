namespace BakendProject.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }

        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
