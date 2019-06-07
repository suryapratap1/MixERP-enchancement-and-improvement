using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Web.UI.HtmlControls;
using MixERP.Net.i18n;

namespace MixERP.Net.FrontEnd
{
    public partial class BackendMaster : MixERPMasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            using (HtmlLink stylesheet = new HtmlLink())
            {
                string path = "/bundles/master-page.css";

                if (CultureManager.IsRtl())
                {
                    path = path.Replace("css", "rtl.css");
                }


                stylesheet.Href = path;
                stylesheet.Attributes["rel"] = "stylesheet";
                stylesheet.Attributes["type"] = "text/css";
                stylesheet.Attributes["media"] = "all";
                this.Page.Header.Controls.Add(stylesheet);
            }

           CustomInclude.IncludeCustomJavascript(this.Page);
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            this.CatalogLiteral.Text = AppUsers.GetCurrentUserDB();
            this.BranchNameLiteral.Text = AppUsers.GetCurrent().View.OfficeName;
            this.SignOutLiteral.Text = Titles.SignOut;
            this.UserGreetingLiteral.Text = String.Format(CultureManager.GetCurrent(), Labels.UserGreeting,
                AppUsers.GetCurrent().View.UserName);
            this.ChangePasswordLiteral.Text = Titles.ChangePassword;
            this.ManageProfileLiteral.Text = Titles.ManageProfile;
            this.MixERPDocumentationLiteral.Text = Titles.MixERPDocumentation;
            this.NotificationLiteral.Text = Titles.Notifications;
            this.VersionLiteral.Text = GetProductVersion();
            this.FooterLiteral.Text = GetFooter();
        }

        public static string GetProductVersion()
        {
            var attribute = (AssemblyInformationalVersionAttribute)Assembly
              .GetExecutingAssembly()
              .GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), true)
              .Single();
            return attribute.InformationalVersion;
        }

        public static string GetFooter()
        {
            const string footer = @"<p>Copyright © 2013-2015. MixERP is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, version 3 of the License.</p><p class=""footer-links""><a href=""http://mixerp.org/forum/"" target=""_blank"">Support</a><a href=""http://mixerp.org/contact-us/"" target=""_blank"">Contact Us</a></p>";

            return footer;
        }
    }
}