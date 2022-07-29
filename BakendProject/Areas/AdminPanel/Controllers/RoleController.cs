using BakendProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class RoleController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _rolemanager;

        public RoleController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> rolemanager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _rolemanager = rolemanager;
        }
        public IActionResult Index()
        {
            return View(_rolemanager.Roles.ToList());
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(string role)
        {
            var result = await _rolemanager.CreateAsync(new IdentityRole { Name = role });
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _rolemanager.FindByIdAsync(id);
            await _rolemanager.DeleteAsync(result);
            return RedirectToAction("Index");

        }
    }
}
