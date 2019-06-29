using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Extensions;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.FrontEnd.Controllers
{
    [Area("FrontEnd")]
    public class HomeController : BaseController
    {
        private readonly IInformationRepository _informationRepository;

        public HomeController(IConfiguration configuration, IInformationRepository informationRepository) : base(configuration)
        {
            this._informationRepository = informationRepository;
        }
        public async Task<IActionResult> Index()
        {
            var seoModel = _informationRepository.GetSeoModel();
            string metadata = seoModel.ToSeoString();
            SetMetadata(metadata);

            return View($"~/Areas/FrontEnd/Views/{TemplateName}/Home/Index.cshtml");
        }
    }
}
