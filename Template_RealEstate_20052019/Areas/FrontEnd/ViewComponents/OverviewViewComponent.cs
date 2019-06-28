using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class OverviewViewComponent : BaseViewComponent
    {
        private readonly IInformationRepository _informationRepository;

        public OverviewViewComponent(IInformationRepository informationRepository, IConfiguration configuration) : base(configuration)
        {
            this._informationRepository = informationRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(GetViewPath(), _informationRepository.GetProjectInformation());
        }
    }
}
