using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Models;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public class NewsViewComponent : BaseViewComponent
    {
        private readonly IArticleRepository _articleRepository;

        public NewsViewComponent(IArticleRepository articleRepository, IConfiguration configuration) : base(configuration)
        {
            this._articleRepository = articleRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var articles = _articleRepository.GetList(new SearchRequest
            {
                PageIndex = 1,
                PageSize = 3
            });

            return View(GetViewPath(), articles?.Data);
        }
    }
}
