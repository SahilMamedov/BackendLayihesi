using BakendProject.DAL;
using BakendProject.Models;
using BakendProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public HeaderViewComponent(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager; 
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Bio> dbBio = _context.Bios.ToList();

            List<Category> dbCategories = _context.Categories.Where(c => c.ParentId == null).ToList();
            List<Category> dbSubCategories = _context.Categories.OrderBy(c => c.ParentId == c.Id).ToList();
            double total = 0;
            HeaderVM headerVM = new HeaderVM();
            ViewBag.User = "";
            ViewBag.Length = "0";
          
            


            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                List<BasketItem> basketItems = _context.BasketItems.Include(b => b.Product).Where(b => b.AppUserId == user.Id).ToList();
                ViewBag.User = user.Name;
                ViewBag.Length = basketItems.Count();
                foreach (var item in basketItems)
                {
                     total += item.Sum;
                }
               
                headerVM.BasketItems = basketItems;

            }
            ViewBag.Total = total;
            headerVM.bios = dbBio;
            headerVM.categories = dbCategories;
            headerVM.subCategories = dbSubCategories;

           
           
            return View(await Task.FromResult(headerVM));
        }
    }
}
