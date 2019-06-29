using System.Text;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Extensions
{
    public static class SeoExtension
    {
        public static string ToSeoString(this SeoModel model)
        {
            var result = new StringBuilder();
            if (model == null)
            {
                return result.ToString();
            }

            if (!string.IsNullOrEmpty(model.Title))
            {
                result.Append($"<title>{model.Title}</title>");
            }

            if (!string.IsNullOrEmpty(model.Keywords))
            {
                result.Append($"<meta name=\"keywords\" content=\"{model.Keywords}\">");
            }

            if (!string.IsNullOrEmpty(model.Description))
            {
                result.Append($"<meta name=\"description\" content=\"{model.Description}\">");
            }

            result.Append("<meta name=\"robots\" content=\"follow\">");
            result.Append("<meta http-equiv=\"content-type\" content=\"text/html; charset = utf-8\">");
            result.Append("<meta name=viewport content=\"width=device-width, initial-scale=1\" >");

            return result.ToString();
        }
    }
}
