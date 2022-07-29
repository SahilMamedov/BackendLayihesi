using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakendProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc{ get; set; }
        public bool IsFeatured { get; set; }
        public bool BestSeller { get; set; }
        public bool NewArrival { get; set; }
        public bool IsDeleted { get; set; }
        public bool InStock { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public double TaxPercent { get; set; }
        public int StockCount { get; set; }
        public bool SpecialProduct { get; set; }

        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
        public Nullable<DateTime> UptadetAt { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public List<TagProduct> TagProducts { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public List <Comment> comments { get; set; }
    }
}
