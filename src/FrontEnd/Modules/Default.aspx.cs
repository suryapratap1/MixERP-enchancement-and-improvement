using MixERP.Net.FrontEnd.Base;
using System;
using System.IO;

namespace MixERP.Net.FrontEnd.Modules
{
    public partial class Default : MixERPWebpage
    {
        private MixERPUserControl plugin;

        protected override void OnInit(EventArgs e)
        {
            if (this.plugin != null)
            {
                this.DefaultContentPlaceholder.Controls.Add(this.plugin);

                this.plugin.Initialize();
                this.ValidateRequestMode = plugin.ValidDateRequest;

                if (!string.IsNullOrWhiteSpace(this.plugin.OverridePath))
                {
                    this.OverridePath = this.plugin.OverridePath;
                }

                this.IsLandingPage = this.plugin.IsLandingPage;
            }

            base.OnInit(e);
        }

        protected override void OnPreInit(EventArgs e)
        {
            this.InitializeControl();

            if (this.plugin != null)
            {
                if (!string.IsNullOrWhiteSpace(this.plugin.MasterPageId))
                {
                    this.MasterPageFile = "~/" + this.plugin.MasterPageId;
                }

                if (this.plugin.RemoveTheme)
                {
                    this.Page.Theme = null;
                }
            }

            base.OnPreInit(e);
        }


        private void InitializeControl()
        {
            if (this.plugin == null)
            {
                if (this.RouteData.Values["path"] != null)
                {
                    string path = @"~/Modules/" + this.RouteData.Values["path"].ToString().Replace(".mix", "") + ".ascx";

                    if (File.Exists(this.Server.MapPath(path)))
                    {
                        this.plugin = this.Page.LoadControl(path) as MixERPUserControl;
                    }
                }
            }
        }
    }
}