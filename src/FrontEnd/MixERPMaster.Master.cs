using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using MixERP.Net.i18n;

namespace MixERP.Net.FrontEnd
{
    public partial class MixERPMaster : MixERPMasterPage
    {
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
        }

        public static string GetProductVersion()
        {
            var attribute = (AssemblyInformationalVersionAttribute)Assembly
              .GetExecutingAssembly()
              .GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), true)
              .Single();
            return attribute.InformationalVersion;
        }
    }
}