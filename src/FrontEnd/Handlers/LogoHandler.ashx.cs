using System;
using System.IO;
using System.Web;
using System.Web.Hosting;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Helpers;

namespace MixERP.Net.FrontEnd.Handlers
{
    public class LogoHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string path = this.GetPath();

            context.Response.ContentType = MimeMapping.GetMimeMapping(path);
            context.Response.Cache.SetCacheability(HttpCacheability.Public);
            context.Response.Cache.SetExpires(DateTime.Now.AddDays(1));
            context.Response.Cache.SetMaxAge(new TimeSpan(24, 0, 0));
            context.Response.TransmitFile(path);
        }

        public bool IsReusable
        {
            get { return false; }
        }

        private string GetPath()
        {
            string logo = "/Static/images/mixerp-logo-light.png";

            string officeLogoFile = AppUsers.GetCurrent().View.LogoFile;

            if (!string.IsNullOrWhiteSpace(officeLogoFile))
            {
                string attachmentsDirectory = DbConfig.GetAttachmentParameter(AppUsers.GetCurrentUserDB(),
                    "AttachmentsDirectory");

                officeLogoFile = Path.Combine(attachmentsDirectory, officeLogoFile);

                if (File.Exists(HostingEnvironment.MapPath(officeLogoFile)))
                {
                    logo = officeLogoFile;
                }
            }

            return logo;
        }
    }
}