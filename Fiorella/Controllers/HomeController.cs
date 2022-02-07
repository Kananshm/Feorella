using Fiorella.DAL;
using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = await _context.Sliders.ToListAsync(),
                FlowerMainText = await _context.FlowerMainTexts.FirstOrDefaultAsync(),
                Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync(),
                Products =await _context.Products.Where(p => p.IsDeleted == false).Include(p => p.Category).ToListAsync()
            };

            return View(homeVM);
        }

        
    }
}
