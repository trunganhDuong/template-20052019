using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Areas.FrontEnd.Models
{
    public class Location
    {
        [Display(Name = "Tiêu đề")]
        [Required(ErrorMessage = "Bạn cần nhập tiêu đề")]
        public string Header { get; set; }

        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Bạn cần nhập mô tả")]
        public string Description { get; set; }

        [Display(Name = "Ảnh bản đồ")]
        public string MapImage { get; set; }

        [Display(Name = "Ảnh các tiện ích xung quanh")]
        public string NearbyImage { get; set; }
    }
}
