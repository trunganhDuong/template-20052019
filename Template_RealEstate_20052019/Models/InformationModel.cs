using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Models
{
    public class InformationModel
    {
        public Location Location { get; set; }
        public ProjectInformation ProjectInformation { get; set; }
        public ContactInformation ContactInformation { get; set; }
    }
}
