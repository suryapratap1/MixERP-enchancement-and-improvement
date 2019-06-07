using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.ApplicationState;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Entities.Core;
using MixERP.Net.Framework.Controls;
using Serilog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Common.jQueryHelper;
using MixERP.Net.FrontEnd.Models;
using MixERP.Net.i18n;
using MixERP.Net.WebControls.Common.Helpers;
using Newtonsoft.Json;

namespace MixERP.Net.FrontEnd.Base
{
    public class MixERPWebpage : MixERPWebPageBase
    {
        private string currentPage;

        /// <summary>
        ///     The pages, having no actual entry on database menu table, can have an OverridePath
        ///     which can be set to an existing page.
        /// </summary>
        public virtual string OverridePath { get; set; }

        /// <summary>
        ///     The pages which do not have actual entry on database menu table, but rather serve as placeholders are landing
        ///     pages.
        /// </summary>
        public virtual bool IsLandingPage { get; set; }

        /// <summary>
        ///     Set this to true for pages where you do not need users to be logged in.
        /// </summary>
        public bool SkipLoginCheck { get; set; }

        public static void RedirectToRootPage()
        {
            Log.Debug("Redirecting to '/' root page.");
            HttpContext.Current.Response.Redirect("~/");
        }

        public void RequestLoginPage()
        {
            FormsAuthentication.SignOut();
            Log.Information("User {UserName} was signed off.", AppUsers.GetCurrent().View.UserName);

            Log.Debug("Clearing Http Cookies.");
            foreach (string cookie in HttpContext.Current.Request.Cookies.AllKeys)
            {
                HttpContext.Current.Request.Cookies.Remove(cookie);
                Log.Verbose("Cleared cookie: {Cookie}.", cookie);
            }


            Log.Verbose("Current page is {CurrentPage}.", this.currentPage);

            Page page = HttpContext.Current.Handler as Page;

            if (page == null)
            {
                return;
            }

            string loginUrl = (page).ResolveUrl(FormsAuthentication.LoginUrl);

            this.currentPage = HttpContext.Current.Request.Url.AbsolutePath;

            if (this.currentPage != loginUrl)
            {
                FormsAuthentication.RedirectToLoginPage(this.currentPage);
                HttpContext.Current.Response.Redirect("/SignIn.aspx?ReturnUrl=" + this.currentPage);
                Log.Information("Redirected to login page.");
            }
        }

        public static void SetAuthenticationTicket(HttpResponse response, long signInId, bool rememberMe)
        {
            if (response == null)
            {
                return;
            }

            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, signInId.ToString(CultureInfo.InvariantCulture), DateTime.Now, DateTime.Now.AddMinutes(30), rememberMe, String.Empty, FormsAuthentication.FormsCookiePath);

            string encryptedCookie = FormsAuthentication.Encrypt(ticket);

            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedCookie);

            cookie.Domain = FormsAuthentication.CookieDomain;
            cookie.Path = ticket.CookiePath;

            response.Cookies.Add(cookie);
        }

        protected override void InitializeCulture()
        {
            SetCulture();
            base.InitializeCulture();
        }

        protected override void OnInit(EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (this.Request.IsAuthenticated)
                {
                    if (AppUsers.GetCurrent().View.LoginId.ToLong().Equals(0))
                    {
                        AppUsers.SetCurrentLogin();

                        if (AppUsers.GetCurrent().View.LoginId.ToLong().Equals(0))
                        {
                            this.RequestLoginPage();
                            return;
                        }
                    }
                }
                else
                {
                    if (!this.SkipLoginCheck)
                    {
                        this.RequestLoginPage();
                        return;
                    }
                }
            }

            this.CheckForceLogOffFlags();
            base.OnInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            this.VerifyAccess();
            this.RegisterJavascript();
            base.OnLoad(e);
        }

        private void VerifyAccess()
        {
            IEnumerable<Menu> menus = this.GetMenus();
            bool policyExists = false;
            this.currentPage = HttpContext.Current.Request.Url.AbsolutePath;

            if (!string.IsNullOrWhiteSpace(this.OverridePath))
            {
                this.currentPage = this.OverridePath;
            }

            if (this.IsLandingPage)
            {
                return;
            }

            foreach (Menu menu in menus)
            {
                if (!string.IsNullOrWhiteSpace(menu?.Url))
                {
                    var menuUrl = this.ResolveUrl(menu.Url).Split('?')[0];

                    if (menuUrl.ToUpperInvariant().Equals(this.currentPage.ToUpperInvariant()))
                    {
                        this.Page.Title = menu.MenuText;
                        policyExists = true;
                        break;
                    }
                }
            }

            if (!policyExists)
            {
                this.Server.Transfer("~/Site/AccessIsDenied.aspx");
            }
        }

        private IEnumerable<Menu> GetMenus()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            var view = AppUsers.GetCurrent().View;

            int userId = view.UserId.ToInt();
            int officeId = view.OfficeId.ToInt();
            string culture = view.Culture;

            return Navigation.GetMenuCollection(catalog, officeId, userId, culture);
        }

        private static void SetCulture()
        {
            var logins = AppUsers.GetCurrent();

            if (logins == null || logins.View == null)
            {
                return;
            }

            string cultureName = logins.View.Culture;

            if (string.IsNullOrWhiteSpace(cultureName))
            {
                return;
            }

            CultureInfo culture = new MixERPCultureInfo(cultureName);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }

        private void RegisterJavascript()
        {
            string script = JSUtility.GetVar("culture", CultureManager.GetCurrent().Name);
            script += JSUtility.GetVar("language", CultureManager.GetCurrent().TwoLetterISOLanguageName);

            script += JSUtility.GetVar("jqueryUIi18nPath", this.Page.ResolveUrl("~/Scripts/jquery-ui/i18n"));

            script += JSUtility.GetVar("today", string.Format(CultureManager.GetCurrent(), CultureManager.GetCurrent().DateTimeFormat.ShortDatePattern, DateTime.Now));
            script += JSUtility.GetVar("now", DateTime.Now.ToString(CultureManager.GetCurrent()));
            script += JSUtility.GetVar("date", DateTime.Now.ToString(CultureInfo.InvariantCulture));

            script += JSUtility.GetVar("reportTemplatePath", PageUtility.ResolveUrl(DbConfig.GetScrudParameter(AppUsers.GetCurrentUserDB(), "TemplatePath")));
            script += JSUtility.GetVar("reportExportTemplatePath", PageUtility.ResolveUrl(DbConfig.GetScrudParameter(AppUsers.GetCurrentUserDB(), "ExportTemplatePath")));
            script += JSUtility.GetVar("reportHeaderPath", PageUtility.ResolveUrl(DbConfig.GetScrudParameter(AppUsers.GetCurrentUserDB(), "HeaderPath")));

            script += JSUtility.GetVar("userId", AppUsers.GetCurrent().View.UserId);
            script += JSUtility.GetVar("user", AppUsers.GetCurrent().View.UserName);
            script += JSUtility.GetVar("officeCode", AppUsers.GetCurrent().View.OfficeCode);
            script += JSUtility.GetVar("office", AppUsers.GetCurrent().View.OfficeName);

            script += JSUtility.GetVar("applicationDates", JsonConvert.SerializeObject(DatePersister.GetFrequencyDates(AppUsers.GetCurrentUserDB(), AppUsers.GetCurrent().View.OfficeId.ToInt())), false);
            script += JSUtility.GetVar("metaView", JsonConvert.SerializeObject(AppUsers.GetCurrent().View), false);
            script += JSUtility.GetVar("overridePath", this.OverridePath);

            script += JSUtility.GetVar("shortDateFormat", CultureManager.GetShortDateFormat());
            script += JSUtility.GetVar("longDateFormat", CultureManager.GetLongDateFormat());

            script += JSUtility.GetVar("thousandSeparator", CultureManager.GetThousandSeparator());
            script += JSUtility.GetVar("decimalSeparator", CultureManager.GetDecimalSeparator());
            script += JSUtility.GetVar("currencyDecimalPlaces", CultureManager.GetCurrencyDecimalPlaces());
            script += JSUtility.GetVar("currencySymbol", CultureManager.GetCurrencySymbol());


            script += JSUtility.GetVar("today", DateTime.Now.ToShortDateString());

            script += JSUtility.GetVar("shortDateFormat", CultureManager.GetShortDateFormat());
            script += JSUtility.GetVar("thousandSeparator", CultureManager.GetThousandSeparator());
            script += JSUtility.GetVar("decimalSeparator", CultureManager.GetDecimalSeparator());
            script += JSUtility.GetVar("currencyDecimalPlaces", CultureManager.GetCurrencyDecimalPlaces());
            script += JSUtility.GetVar("baseCurrencyCode", AppUsers.GetCurrent().View.CurrencyCode);


            script += JSUtility.GetVar("catalog", AppUsers.GetCurrentUserDB());

            script += JSUtility.GetVar("update", this.Update());

            script += JSUtility.GetVar("firstStepsPending", this.Context.Session["FirstStepsPending"]);

            script += JSUtility.GetVar("datepickerFormat", jQueryUI.GetDatePickerFormat());
            script += JSUtility.GetVar("datepickerShowWeekNumber", jQueryUI.ShowWeekNumber());
            script += JSUtility.GetVar("datepickerWeekStartDay", jQueryUI.GetWeekStartDay());
            script += JSUtility.GetVar("datepickerNumberOfMonths", jQueryUI.GetNumberOfMonths());


            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "MixERPMasterPage", script, true);
        }

        private int Update()
        {
            if (Conversion.TryCastBoolean(this.Application["UpdateAvailable"]) &&
                AppUsers.GetCurrent().View.IsAdmin.ToBool())
            {
                return 1;
            }

            return 0;
        }


        private void CheckForceLogOffFlags()
        {
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            Collection<FrequencyDates> applicationDates = Dates.GetFrequencyDates(AppUsers.GetCurrentUserDB());

            FrequencyDates model = applicationDates?.FirstOrDefault(c => c.OfficeId.Equals(officeId));


            if (model?.ForcedLogOffTimestamp == null || model.ForcedLogOffTimestamp.Equals(DateTime.MinValue))
            {
                return;
            }

            if (model.ForcedLogOffTimestamp <= DateTime.Now &&
                model.ForcedLogOffTimestamp >= AppUsers.GetCurrent().View.LoginDateTime)
            {
                this.RequestLoginPage();
            }
        }
    }
}