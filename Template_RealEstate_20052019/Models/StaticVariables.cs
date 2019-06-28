using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Models
{
    public static class StaticVariables
    {
        public static IConfiguration Configuration { get; set; }

        public static string TemplateName
        {
            get
            {
                var templateName = Configuration.GetSection("TemplateName").Get<string>();

                return string.IsNullOrEmpty(templateName) ? "20052019" : templateName;
            }
        }

        public static InformationModel InformationModel { get; set; }
    }
}
