using System.Linq;
using System.Web;
using MixERP.Net.Entities.Office;
using MixERP.Net.Framework;
using Npgsql;
using PetaPoco;

namespace MixERP.Net.FrontEnd.Data.Office
{
    public static class User
    {
        public static bool ChangePassword(string catalog, string userName, string currentPassword, string newPassword)
        {
            try
            {
                return Factory.Scalar<bool>(catalog,
                    "SELECT * FROM policy.change_password(@0::text, @1::text, @2::text);",
                    userName, currentPassword, newPassword);
            }
            catch (NpgsqlException ex)
            {
                throw new MixERPException(ex.Message, ex);
            }
        }

        public static GlobalLogin GetGloblalLogin(long globalLoginId)
        {
            const string sql = "SELECT * FROM public.global_logins WHERE global_login_id=@0;";
            GlobalLogin login = Factory.Get<GlobalLogin>(Factory.MetaDatabase, sql, globalLoginId).FirstOrDefault();

            if (login != null)
            {
                string catalog = login.Catalog;

                SignInView view =
                    Factory.Get<SignInView>(catalog, "SELECT * FROM office.sign_in_view WHERE login_id=@0;",
                        login.LoginId).FirstOrDefault();

                if (view != null)
                {
                    login.View = view;
                    return login;
                }
            }

            return null;
        }

        public static long SignIn(string catalog, int officeId, string userName, string password, string culture, bool remember, HttpContext context)
        {
            if (context != null)
            {
                string remoteAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                string remoteUser = HttpContext.Current.Request.ServerVariables["REMOTE_USER"];

                DbSignInResult result = SignIn(catalog, officeId, userName, password, context.Request.UserAgent, remoteAddress, remoteUser, culture);

                if (result.LoginId == 0)
                {
                    throw new MixERPException(result.Message);
                }


                long globalLoginId = GetGlobalLogin(catalog, result.LoginId);

                return globalLoginId;
            }

            return 0;
        }

        private static long GetGlobalLogin(string catalog, long loginId)
        {
            const string sql =
                "INSERT INTO public.global_logins(catalog, login_id) SELECT @0::text, @1::bigint RETURNING global_login_id;";

            return Factory.Scalar<long>(Factory.MetaDatabase, sql, catalog, loginId);
        }

        private static DbSignInResult SignIn(string catalog, int officeId, string userName, string password, string browser, string remoteAddress, string remoteUser, string culture)
        {
            const string sql = "SELECT * FROM office.sign_in(@0::public.integer_strict, @1::text, @2::text, @3::text, @4::text, @5::text, @6::text);";
            return Factory.Get<DbSignInResult>(catalog, sql, officeId, userName, password, browser, remoteAddress, remoteUser, culture).FirstOrDefault();
        }
    }
}