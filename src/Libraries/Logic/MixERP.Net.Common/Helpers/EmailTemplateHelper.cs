using System.Globalization;
using System.IO;
using System.Text;
using System.Web.Hosting;
using MixERP.Net.i18n;

namespace MixERP.Net.Common.Helpers
{
    public static class EmailTemplateHelper
    {
        public static string GetTemplateFileContents(string path)
        {
            string header = GetHeader();
            string footer = GetFooter();
            string template = GetLocalizedTemplateFile(path);

            return template.Replace("{Header}", header).Replace("{Footer}", footer);
        }

        public static string GetHeader()
        {
            return GetLocalizedTemplateFile("/Static/Templates/Email/EmailHeader.html");
        }

        public static string GetFooter()
        {
            return GetLocalizedTemplateFile("/Static/Templates/Email/EmailFooter.html");
        }

        private static string GetLocalizedTemplateFile(string path)
        {
            string template =
                HostingEnvironment.MapPath(path.Replace("html", "") +
                                           CultureManager.GetCurrent().TwoLetterISOLanguageName
                                               .ToLowerInvariant() + ".html");

            if (!File.Exists(template))
            {
                template = HostingEnvironment.MapPath(path);
            }

            if (!File.Exists(template) || template == null)
            {
                return string.Empty;
            }

            return File.ReadAllText(template, Encoding.UTF8);
        }
    }
}