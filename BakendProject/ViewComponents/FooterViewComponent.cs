using BakendProject.DAL;
using BakendProject.Models;
using BakendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           List <Bio> bios = _context.Bios.ToList();
            List<Brand> dbBrands = _context.Brands.ToList();
            List<Blog> dbBlog = _context.Blogs.ToList();

            FooterVM footerVM= new FooterVM();
            footerVM.brands = dbBrands;
            footerVM.blogs = dbBlog;
            footerVM.bios = bios;
            return View(await Task.FromResult(footerVM));
        }
    }
}
