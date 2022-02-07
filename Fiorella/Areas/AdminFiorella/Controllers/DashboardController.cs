using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Areas.AdminFiorella.Controllers
{
    public class DashboardController : Controller
    {
        [Area("AdminFiorella")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
