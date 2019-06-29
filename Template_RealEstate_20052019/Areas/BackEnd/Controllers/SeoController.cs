using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.BackEnd.Base;
using Template_RealEstate_20052019.Models;
using Template_RealEstate_20052019.Repositories;

namespace Template_RealEstate_20052019.Areas.BackEnd.Controllers
{
    [Area("BackEnd")]
    public class SeoController : BaseController
    {
        private readonly IInformationRepository _informationRepository;

        public SeoController(IInformationRepository informationRepository)
        {
            this._informationRepository = informationRepository;
        }

        public async Task<IActionResult> Index()
        {
            var model = _informationRepository.GetSeoModel() ?? new Models.SeoModel();

            SetPageTitle("Quản lý thông tin SEO");

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(SeoModel seoModel)
        {
            if (seoModel == null)
            {
                SetFlashMessage("Có lỗi xảy ra", false);

                return RedirectToAction("Index");
            }

            if (!ModelState.IsValid)
            {
                SetPageTitle("Quản lý thông tin SEO");

                return View(seoModel);
            }

            _informationRepository.SaveSeoModel(seoModel);
            SetFlashMessage("Lưu thông tin thành công");

            return RedirectToAction("Index");
        }
    }
}
