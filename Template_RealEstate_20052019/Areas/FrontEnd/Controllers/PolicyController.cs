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
    public class PolicyController : BaseController
    {
        private readonly IArticleRepository _articleRepository;

        public PolicyController(IArticleRepository articleRepository, IConfiguration configuration) : base(configuration)
        {
            this._articleRepository = articleRepository;
        }

        [HttpGet("/chinh-sach-mua-nha/{slug}/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            if (id < 0)
            {
                return Redirect(Url.Action("Index", "Home", new { Area = "FrontEnd" }));
            }

            var article = _articleRepository.GetById(id);
            SetPageTitle("Chính sách");

            return View(GetRelativeViewPath("Detail.cshtml"), article);
        }
    }
}
