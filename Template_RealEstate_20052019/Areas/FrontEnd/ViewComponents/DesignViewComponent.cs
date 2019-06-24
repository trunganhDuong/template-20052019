using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class DesignViewComponent : BaseViewComponent
    {
        public DesignViewComponent(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<DesignDetail> details = _configuration.GetSection("Design").Get<List<DesignDetail>>();

            return View(GetViewPath(), details);
        }
    }
}
