using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Models
{
    public class ContactInformation
    {   
        [Display(Name = "Điện thoại")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Di động")]
        public string Mobile { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Website")]
        public string Website { get; set; }

        [Required]
        [Display(Name = "Địa chỉ liên lac")]
        public string Address { get; set; }
        [Display(Name = "Quận/Huyện")]
        public string District { get; set; }
        [Display(Name = "Thành phố")]
        public string City { get; set; }
        [Display(Name = "Quốc gia")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Địa chỉ bản đồ")]
        public string MapAddress { get; set; }
    }
}
