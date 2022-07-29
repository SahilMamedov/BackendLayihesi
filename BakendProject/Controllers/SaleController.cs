using BakendProject.DAL;
using BakendProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.Controllers
{
    public class SaleController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public SaleController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SaleStart()
        {
            double total = 0;
            if (User.Identity.IsAuthenticated)
            {

                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                List<Product> dbProducts = _context.Products.Include(p => p.ProductImages).ToList();
                List<BasketItem> basketItems = _context.BasketItems.Include(b => b.Product).Where(b => b.AppUserId == user.Id).ToList();
                OrderItem orderItem = new OrderItem();
                Order order = new Order();
                foreach (var item in basketItems)
                {
                    order.AppUser = item.AppUser;
                    order.AppUserId = item.AppUserId;
                    order.Email = item.AppUser.Email;
                    order.CreatedAt = DateTime.Now;
                    order.OrderStatus = OrderStatus.Shipped;  

                }

                foreach (var item in basketItems)
                {
                    total += item.Sum;
                }
                foreach (var item in basketItems)
                {

                    foreach (var product in dbProducts)
                    {
                        product.StockCount -= item.Count;
                    }

                    orderItem.ProductId = item.ProductId;
                    orderItem.Product = item.Product;
                    orderItem.Count = item.Count;
                    orderItem.Total = total;
                    orderItem.OrderId = order.Id;
                    orderItem.Order = order;
                    orderItem.ImageUrl = item.ImgUrl;
                
                    _context.BasketItems.Remove(item);
                }
               
                await _context.AddAsync(orderItem);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("index","sale");
        }
    }
}
