using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Areas.FrontEnd.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IConfiguration _configuration;

        public BaseController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        protected int ItemId
        {
            get
            {
                if (HttpContext.Request.Query == null || string.IsNullOrEmpty(HttpContext.Request.Query["itemId"]))
                {
                    return 0;
                }

                return int.Parse(HttpContext.Request.Query["itemId"]);
            }
        }

        protected void SetPageTitle(string title)
        {
            ViewBag.Title = title;
        }

        protected string TemplateName
        {
            get
            {
                var result = _configuration.GetSection("TemplateName").Get<string>();

                return !string.IsNullOrEmpty(result) ? result : string.Empty;
            }
        }

        protected string GetRelativeViewPath(string viewName)
        {
            return $"~/Areas/FrontEnd/Views/{TemplateName}/{GetType().Name.Replace("Controller", "")}/{viewName}";
        }
    }
}
