using Fiorella.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Areas.AdminFiorella.Controllers
{
    [Area("AdminFiorella")]
    public class CategoryController : Controller
    {
        private AppDbContext _context { get; }
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            return Json(id);
        }

        public IActionResult Update(int id)
        {
            return Json(id);
        }
        public IActionResult Delete(int id)
        {
            return Json(id);
        }

    }
}
