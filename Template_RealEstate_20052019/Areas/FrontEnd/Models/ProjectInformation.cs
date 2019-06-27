using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Areas.FrontEnd.Models
{
    public class ProjectInformation
    {
        [Required(ErrorMessage ="Bạn cần nhập tên dự án")]
        [Display(Name = "Tên dự án")]
        public string ProjectName { get; set; }

        [Display(Name = "Mô tả dự án")]
        public string ProjectDescription { get; set; }

        [Display(Name = "Slogan dự án")]
        public string ProjectSlogan { get; set; }

        [Display(Name = "Nhà phân phối")]
        public string Supplier { get; set; }

        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Bạn cần nhập địa chỉ dự án")]
        public string Address { get; set; }

        [Display(Name = "Chủ đầu tư")]
        public string InvestorName { get; set; }

        [Display(Name = "Diện tích (m2)")]
        [Required(ErrorMessage = "Bạn cần nhập diện tích dự án")]
        public string Area { get; set; }

        [Display(Name = "Diện tích sàn (m2)")]
        public string FloorArea { get; set; }

        [Display(Name = "Diện tích xây dựng (m2)")]
        public string ConstructionArea { get; set; }

        public string Slogan { get; set; }

        public Scale Scale { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string Image { get; set; }
    }
}
