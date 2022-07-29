using BakendProject.DAL;
using BakendProject.Extentions;
using BakendProject.Models;
using BakendProject.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int page = 1, int take = 5)
        {

            List<Product> products = _context.Products.Include(p=>p.ProductImages).Include(p => p.Category).Skip((page - 1) * take).Where(p=>p.IsDeleted==false).Take(take).ToList();

            PaginationVM<Product> paginationVM = new PaginationVM<Product>(products, PageCount(take), page);


            return View(paginationVM);




        }
        private int PageCount(int take)
        {
            List<Product> products = _context.Products.ToList();
            return (int)Math.Ceiling((decimal)products.Count() / take);

        }
        public IActionResult Create()
        {

            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "Name");

            ViewBag.Brands = new SelectList(_context.Brands.ToList(), "Id", "Name");
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "Name");
            ViewBag.Brands = new SelectList(_context.Brands.ToList(), "Id", "Name");

            if (product.Photo == null)
            {
                ModelState.AddModelError("Photo", "Bosqoyma");
                return View();
            }
            if (!product.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "only Photo");
                View();

            }
            if (product.Photo.ValidSize(200))
            {
                ModelState.AddModelError("Photo", "olcu uygun deyil");
                return View();

            }

            Product newProduct = new Product

            { 
                Price = product.Price,
                Name = product.Name,
                CategoryId = product.CategoryId,
                NewArrival=true,
                BestSeller=true,
                IsFeatured=true,
                Desc=product.Desc,
                IsDeleted=false,
                InStock=true,
                DiscountPrice=product.DiscountPrice,
                TaxPercent=product.TaxPercent,
                StockCount=product.StockCount,
                SpecialProduct=false,
                BrandId=product.BrandId,
                CreatedAt=DateTime.Now



              

            };

            List<ProductImage> productImages = new List<ProductImage>();
            ProductImage newProductimages = new ProductImage
            {

                ImageUrl = product.Photo.SaveImage(_env, "images"),
                  ProductId=newProduct.Id,
                IsMain = true
            };
            productImages.Add(newProductimages);
            newProduct.ProductImages=productImages;
            await _context.Products.AddAsync(newProduct);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
        public  IActionResult Delete(int? id)
        {
            List<BasketItem> basketItems = _context.BasketItems.Include(b=>b.Product).Where(b=>b.ProductId == id).ToList();
            Product dbproduct =  _context.Products.Include(p=>p.ProductImages).FirstOrDefault(p=>p.Id==id);
            foreach (var item in dbproduct.ProductImages)
            {
                string path = Path.Combine(_env.WebRootPath, "img", item.ImageUrl);

                if (dbproduct == null)
                    Helper.Helper.DeleteImage(path);
            }

          foreach (var item in basketItems)
            {
                item.Product.IsDeleted = true;
            }
       dbproduct.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public async Task<IActionResult> Update(int? id)

        {
            if (id == null) return NotFound();
            Product product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();
          
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            List<ProductImage> productImages = new List<ProductImage>();
            if (!ModelState.IsValid)
            {
                return View();
            }
            Product products = _context.Products.Include(p=>p.ProductImages).FirstOrDefault(c => c.Id == product.Id);
            Product productName = _context.Products.FirstOrDefault(c => c.Name.ToLower() == product.Name.ToLower());
            
            if (product.Photo != null)
            {
                foreach (var item in products.ProductImages)
                {
                    item.ImageUrl = product.Photo.SaveImage(_env, "images");

                }
               

            }
            if (productName != null)
            {
                if (productName.Name != products.Name)
                {
                    ModelState.AddModelError("Name", "bu adli product var var");
                    return View();
                }
            }


            products.Name = product.Name;
            products.Price = product.Price;
            products.DiscountPrice = product.DiscountPrice;
            products.Desc=product.Desc;
            products.StockCount = product.StockCount;
            products.InStock = product.InStock;
            products.UptadetAt = product.UptadetAt;

            await _context.SaveChangesAsync();
            return RedirectToAction("index");


        }
        public async Task<IActionResult> Detail(int? id)

        {
            if (id == null) return NotFound();
            Product product = await _context.Products.Include(p => p.ProductImages).FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }
    }
}
