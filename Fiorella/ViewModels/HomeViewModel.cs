using Fiorella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public FlowerMainText FlowerMainText { get; set; }
       
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

    }
}
