using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class RegistrationViewComponent : BaseViewComponent
    {
        private readonly IOptions<ContactInformation> _options;

        public RegistrationViewComponent(IOptions<ContactInformation> options, IConfiguration configuration) : base(configuration)
        {
            this._options = options;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var contactInfo = _options.Value;

            return View(GetViewPath(), contactInfo);
        }
    }
}
