﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models
{
    public class FlowerMainText
    {
        public int Id { get; set; }
        [Required,StringLength(300)]
        public string Title { get; set; }
        [Required, StringLength(300)]

        public string Description { get; set; }
        public string Image { get; set; }
    }
}
