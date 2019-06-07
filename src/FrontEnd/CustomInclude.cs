using System.IO;
using System.Web.Hosting;

namespace MixERP.Net.FrontEnd
{
    public static class CustomInclude
    {
        /// <summary>
        /// Includes a javascript file custom.js if found on application root directory.
        /// The custom.js file can contain your own fancy stuff like analytics, chat, etc.
        /// </summary>
        public static void IncludeCustomJavascript(System.Web.UI.Page page)
        {
            var fancyStuff = HostingEnvironment.MapPath("~/custom.js");
            if (File.Exists(fancyStuff))
            {
                page.ClientScript.RegisterClientScriptInclude(page.GetType(), "custom.js", "/custom.js");
            }
        }
    }
}