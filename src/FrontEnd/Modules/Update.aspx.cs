using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.Updater;
using MixERP.Net.Updater.Api;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Common;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using Serilog;

namespace MixERP.Net.FrontEnd.Modules
{
    public partial class Update : MixERPWebpage
    {
        protected string _downloadUrl = string.Empty;
        protected Release _release = new Release();

        protected void Page_Init(object sender, EventArgs e)
        {
            string userName = AppUsers.GetCurrent().View.UserName;
            string ipAddress = AppUsers.GetCurrent().View.IpAddress;

            bool isDevelopmentMode = DbConfig.GetMixERPParameter(AppUsers.GetCurrentUserDB(), "Mode").ToUpperInvariant().Equals("DEVELOPMENT");
            bool isLocalHost = PageUtility.IsLocalhost(this.Page);
            bool isAdmin = AppUsers.GetCurrent().View.IsAdmin.ToBool();

            //isLocalHost = false;

            bool hasAccess = false;

            if (isAdmin)
            {
                if (isDevelopmentMode && isLocalHost)
                {
                    hasAccess = true;
                }

                if (!isDevelopmentMode)
                {
                    hasAccess = true;
                }
            }

            if (!hasAccess)
            {
                Log.Information("Access to {Page} is denied to {User} from {IP}.", this,
                    userName, ipAddress);
                this.ReleasePanel.Visible = false;
                this.Page.Server.Transfer("~/Site/AccessIsDenied.aspx", false);
                return;
            }

            UpdateManager updater = new UpdateManager();

            try
            {
                Task<Release> task = Task.Run(() => updater.GetLatestReleaseAsync());
                this._release = task.Result;
            }
            catch
            {
                this.ReleasePanel.Visible = false;
                this.UpToDatePanel.Visible = true;
                return;
            }

            if (this._release == null)
            {
                this._release = new Release();
            }
            else
            {
                string keyword = Config.UpdateKeyword;

                Asset ass =
                    this._release.Assets.FirstOrDefault(a => a.Name.ToUpperInvariant().Contains(keyword.ToUpperInvariant()));

                if (ass != null)
                {
                    this._downloadUrl = ass.DownloadUrl;
                }
            }

            if (string.IsNullOrWhiteSpace(this._downloadUrl))
            {
                this.ErrorLabel.Text = "This release does not contain any update.";
            }

            this.OverridePath = "/Dashboard/Index.aspx";
        }
    }
}