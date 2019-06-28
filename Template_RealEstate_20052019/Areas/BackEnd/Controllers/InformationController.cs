using Microsoft.AspNetCore.Http;
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
    [Area("Backend")]
    public class InformationController : BaseController
    {
        private const string indexViewPath = "~/Areas/BackEnd/Views/Information/Index.cshtml";
        private readonly IInformationRepository _informationRepository;

        public InformationController(IInformationRepository informationRepository)
        {
            this._informationRepository = informationRepository;
        }

        public async Task<IActionResult> Index()
        {
            var model = new InformationModel
            {
                Location = _informationRepository.GetLocation(),
                ContactInformation = _informationRepository.GetContactInformation(),
                ProjectInformation = _informationRepository.GetProjectInformation()
            };

            SetPageTitle("Quản lý thông tin website");

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ProjectInformation(InformationModel model, IFormFile file)
        {
            if (model?.ProjectInformation == null)
            {
                SetFlashMessage("Có lỗi xảy ra", false);

                return RedirectToAction("Index");
            }

            if (!ModelState.IsValid)
            {
                model = new InformationModel
                {
                    Location = _informationRepository.GetLocation() ?? new FrontEnd.Models.Location(),
                    ContactInformation = _informationRepository.GetContactInformation() ?? new Models.ContactInformation(),
                    ProjectInformation = model.ProjectInformation ?? new FrontEnd.Models.ProjectInformation()
                };
                SetPageTitle("Quản lý thông tin website");

                return View(indexViewPath, model);
            }

            if (file != null)
            {
                var fileName = await UploadFile(file);
                model.ProjectInformation.Image = fileName;
            }

            _informationRepository.SaveProjectInformation(model.ProjectInformation);

            SetFlashMessage("Cập nhật thông tin thành công");

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Location(InformationModel model, IFormFile mapImage, IFormFile nearbyImage)
        {
            if (model?.Location == null)
            {
                SetFlashMessage("Có lỗi xảy ra", false);

                return RedirectToAction("Index");
            }

            if (!ModelState.IsValid)
            {
                model = new InformationModel
                {
                    Location = model.Location,
                    ContactInformation = _informationRepository.GetContactInformation() ?? new Models.ContactInformation(),
                    ProjectInformation = _informationRepository.GetProjectInformation() ?? new FrontEnd.Models.ProjectInformation()
                };
                SetPageTitle("Quản lý thông tin website");

                return View(indexViewPath, model);
            }

            if (mapImage != null)
            {
                var fileName = await UploadFile(mapImage);
                model.Location.MapImage = fileName;
            }

            if (nearbyImage != null)
            {
                var fileName = await UploadFile(nearbyImage);
                model.Location.NearbyImage = fileName;
            }

            _informationRepository.SaveLocation(model.Location);

            SetFlashMessage("Cập nhật thông tin thành công");

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> ContactInformation(InformationModel model)
        {
            if (model?.ContactInformation == null)
            {
                SetFlashMessage("Có lỗi xảy ra", false);

                return RedirectToAction("Index");
            }

            if (!ModelState.IsValid)
            {
                model = new InformationModel
                {
                    Location = _informationRepository.GetLocation() ?? new FrontEnd.Models.Location(),
                    ContactInformation = model.ContactInformation,
                    ProjectInformation = _informationRepository.GetProjectInformation() ?? new FrontEnd.Models.ProjectInformation()
                };
                SetPageTitle("Quản lý thông tin website");

                return View(indexViewPath, model);
            }

            _informationRepository.SaveContactInformation(model.ContactInformation);

            SetFlashMessage("Cập nhật thông tin thành công");

            return RedirectToAction("Index");
        }
    }
}
