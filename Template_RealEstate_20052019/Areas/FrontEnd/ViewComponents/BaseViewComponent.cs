using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Areas.FrontEnd.ViewComponents
{
    public abstract class BaseViewComponent : ViewComponent
    {
        protected readonly IConfiguration _configuration;

        public BaseViewComponent(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public string TemplateName
        {
            get
            {
                return StaticVariables.TemplateName;
            }
        }

        public string GetViewPath()
        {
            var folderName = GetType().Name.Replace("ViewComponent", "");
            var viewPath = $"~/Areas/FrontEnd/Views/{TemplateName}/Shared/Components/{folderName}/Default.cshtml";

            return viewPath;
        }
    }
}
