using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Models
{
    public class SeoModel
    {
        [Required(ErrorMessage = "Bạn cần nhập tiêu đề")]
        [Display(Name = "Tiêu đề trang")]
        public string Title { get; set; }

        [Display(Name = "Các từ khóa")]
        public string Keywords { get; set; }

        [Display(Name = "Mô tả trang")]
        public string Description { get; set; }
    }
}
