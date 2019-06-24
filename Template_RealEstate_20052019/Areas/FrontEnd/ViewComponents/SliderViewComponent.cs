using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class SliderViewComponent : BaseViewComponent
    {
        public SliderViewComponent(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var slides = _configuration.GetSection("Slider").Get<List<Slide>>();

            return View(GetViewPath(), slides);
        }
    }
}
