using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.FrontEnd.Controllers
{
    [Area("FrontEnd")]
    public class NewsController : BaseController
    {
        private readonly IArticleRepository _articleRepository;

        public NewsController(IArticleRepository articleRepository, IConfiguration configuration) : base(configuration)
        {
            this._articleRepository = articleRepository;
        }

        [HttpGet("/tin-tuc/{slug}/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            if (id < 0)
            {
                return Redirect(Url.Action("Index", "Home", new { Area = "FrontEnd" }));
            }

            var article = _articleRepository.GetById(id);
            SetPageTitle("Tin tức");

            return View(GetRelativeViewPath("Detail.cshtml"), article);
        }
    }
}
