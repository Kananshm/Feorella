using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models
{
    public class Slider
    {
         public int Id { get; set; }
         [Required,StringLength(255)]
         public string Image { get; set; }

    }
}
