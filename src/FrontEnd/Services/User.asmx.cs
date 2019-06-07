using System.ComponentModel;
using System.Threading;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Framework;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using Serilog;

namespace MixERP.Net.FrontEnd.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class User : WebService
    {
        [WebMethod(EnableSession = true)]
        public string Authenticate(string catalog, string username, string password, bool rememberMe, string language, int branchId)
        {
            Thread.Sleep(this.GetDelay());
            return this.Login(catalog, branchId, username, password, language, rememberMe, this.Context);
        }

        private int GetDelay()
        {
            int attempts = PageUtility.InvalidPasswordAttempts(this.Session);

            if (attempts > 3)
            {
                return attempts * 10000;
            }

            return 1000;
        }

        private string Login(string catalog, int officeId, string userName, string password, string culture,
            bool rememberMe, HttpContext context)
        {
            try
            {
                long globalLoginId = Data.Office.User.SignIn(catalog, officeId, userName, password, culture, rememberMe, context);

                Log.Information("{UserName} signed in to office : #{OfficeId} from {IP}.", userName, officeId,
                    context.Request.ServerVariables["REMOTE_ADDR"]);

                if (globalLoginId > 0)
                {
                    MixERPWebpage.SetAuthenticationTicket(HttpContext.Current.Response, globalLoginId, rememberMe);

                    AppUsers.SetCurrentLogin(globalLoginId);
                    return "OK";
                }

                this.LogInvalidSignIn();
                return Warnings.UserIdOrPasswordIncorrect;
            }
            catch (MixERPException ex)
            {
                Log.Warning("{UserName} could not sign in to office : #{OfficeId} from {IP}.", userName, officeId,
                    context.Request.ServerVariables["REMOTE_ADDR"]);

                this.LogInvalidSignIn();
                return ex.Message;
            }
        }

        private void LogInvalidSignIn()
        {
            PageUtility.InvalidPasswordAttempts(this.Session, 1);
        }
    };
} ;