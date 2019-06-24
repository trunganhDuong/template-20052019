using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class FooterViewComponent : BaseViewComponent
    {
        public FooterViewComponent(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(GetViewPath());
        }
    }
}
