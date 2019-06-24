using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class LocationViewComponent : BaseViewComponent
    {
        private readonly IOptions<Location> _option;

        public LocationViewComponent(IOptions<Location> option, IConfiguration configuration) : base(configuration)
        {
            this._option = option;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(GetViewPath(), _option.Value);
        }
    }
}
