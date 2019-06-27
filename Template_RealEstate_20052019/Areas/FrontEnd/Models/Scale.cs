﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Areas.FrontEnd.Models
{
    public class Scale
    {
        [Display(Name = "Mô tả quy mô")]
        public string Description { get; set; }

        public List<Building> ListBuilding { get; set; }
    }
}
