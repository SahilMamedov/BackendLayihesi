using BakendProject.DAL;
using BakendProject.Models;
using BakendProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _rolemanager;

        public UserController(AppDbContext context ,UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> rolemanager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _rolemanager = rolemanager;
            _context = context;
        }
        public IActionResult Index(string search)
        {
            var users = search == null ?
                _userManager.Users.ToList() : _userManager.Users.
                Where(user => user.Name.ToLower().Contains(search.ToLower())).ToList();


            return View(users);
        }
        public async Task<IActionResult> Update(string id)

        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            var userRoles = await _userManager.GetRolesAsync(user);
            var roles = _rolemanager.Roles.ToList();
            RoleVM roleVM = new RoleVM
            {
                Name = user.Name,
                Roles = roles,
                UserRoles = userRoles,
                UserId = user.Id


            };
            return View(roleVM);

        }
        [HttpPost]
        public async Task<IActionResult> Update(List<string> roles, string id)

        {
            AppUser user = await _userManager.FindByIdAsync(id);
            var userRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, userRoles);
            await _userManager.AddToRolesAsync(user, roles);


            return RedirectToAction("index");
        }
         
        public async Task <IActionResult> Delete(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);
            var userRoles = await _userManager.GetRolesAsync(user);
            List<BasketItem> basketItems = _context.BasketItems.Where(b => b.AppUserId == user.Id).ToList();
            foreach (var item in basketItems)
            {
                _context.Remove(item);
            }
            await _userManager.DeleteAsync(user);

            return RedirectToAction("index");
        }

        public async Task <IActionResult> Detail(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);
            var userRoles = await _userManager.GetRolesAsync(user);
            List<BasketItem> basketItems = _context.BasketItems.Where(b => b.AppUserId == user.Id).ToList();
            List<OrderItem> orderItems = _context.OrderItems.Include(o => o.Order).Include(o=>o.Product).Where(o => o.Order.AppUserId == user.Id && o.OrderId == o.Order.Id).ToList();
            UserVM uservm = new UserVM()
            {
                basketItems = basketItems,
                orderItems = orderItems,
                appUser = user
            };
            return View(uservm);
        }
            

    }
}

