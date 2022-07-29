using BakendProject.DAL;
using BakendProject.Models;
using BakendProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public ShopController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

       
        public IActionResult Index(int page = 1, int take = 5)
        {
           
            List<Product> products = _context.Products.Include(p => p.ProductImages).Where(p=>p.IsDeleted==false).Skip((page - 1) * take).Take(take).ToList();
            PaginationVM<Product> pagination = new PaginationVM<Product>(products, PageCount(take), page);
            ViewBag.Pagination = pagination.PageCount;
            ViewBag.CurrentPage = pagination.CurrentPage;
            return View(products);
        }
       
        public IActionResult Sort(int take)
        {
            List<Product> products = _context.Products.Include(p => p.ProductImages).Take(take).ToList();
            return PartialView("_SortPartial",products);
        }
        
        public IActionResult SortMinMax(int min)
        {
            List<Product> dBproducts = _context.Products.Include(p => p.ProductImages).ToList();
            if (min == 2)
            {
                List<Product> products = _context.Products.Include(p => p.ProductImages).OrderBy(p => p.Price).ToList();
                return PartialView("_SortPartial", products);
            }

            return PartialView("_SortPartial", dBproducts);
        }


        //public IActionResult SortTwoPage(int take)
        //{
        //    List<Product> products = _context.Products.Include(p => p.ProductImages).Take(take).ToList();
        //    return PartialView("_SortPartialTwo", products);
        //}


        //public async  Task <IActionResult> SortMinMaxPageTwo(int min)
        //{
        //    List<Product> dBproducts = await _context.Products.Include(p => p.ProductImages).ToListAsync();
        //    if (min == 2)
        //    {
        //        List<Product> products = await _context.Products.Include(p => p.ProductImages).OrderBy(p => p.Price).ToListAsync();
        //        return  PartialView("_SortPartialTwo", products);
        //    }

        //    return PartialView("_SortPartialTwo", dBproducts);
        //}



        private int PageCount(int take)
        {

            List<Product> products = _context.Products.ToList();
            return (int)Math.Ceiling((decimal)products.Count() / take);
        
        }



        public IActionResult Detail(int id)
        {

            List<Product> products = _context.Products.Include(p => p.ProductImages).Where(p=>p.IsDeleted == false).ToList();
            Product dbProduct = _context.Products.Include(p => p.ProductImages).Include(p => p.Brand).FirstOrDefault(p => p.Id == id);
            List<Comment> comments = _context.comments.Where(c=>c.ProductId == dbProduct.Id).ToList();
            DetailVM detail = new DetailVM();
            detail.Products = products;
            detail.Product = dbProduct;
            detail.comments = comments;
            ViewBag.Description = dbProduct.Desc;
            return View(detail);

        }
        //[HttpPost]
        //public async Task <IActionResult> Detail([FromForm] string comment,int id)
        //{
        //    Product product = _context.Products.FirstOrDefault(p => p.Id == id);
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            

        //        Comment com = new Comment();
        //        com.Desc = comment;
        //        com.AppUserId = user.Id;
        //        com.appUser = user;
        //        com.product = product;
        //        com.ProductId = product.Id;
        //        com.CreatedAt = DateTime.Now;
        //        await _context.comments.AddAsync(com);

        //    }

        //    List<Comment> comments = _context.comments.Where(c => c.ProductId == product.Id).ToList();

        //    return PartialView("_CommentPartial",comments);
        //}
      

        public IActionResult DetailTwo(int? id)
        {

            Product dbProduct = _context.Products.Include(p => p.ProductImages).Include(p=>p.Brand).FirstOrDefault(p => p.Id == id);
            return PartialView("_DetailPartial", dbProduct);

        }
        public IActionResult DescComment(int? id)
        {

            Product dbProduct = _context.Products.Include(p => p.ProductImages).Include(p => p.Brand).FirstOrDefault(p => p.Id == id);
          
            return PartialView("_DescCommetPartial", dbProduct);

        }
    }
}
