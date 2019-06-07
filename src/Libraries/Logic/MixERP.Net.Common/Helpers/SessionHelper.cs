using System.Web;
using System.Web.SessionState;

namespace MixERP.Net.Common.Helpers
{
    public static class SessionHelper
    {
        public static void RemoveSessionKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return;
            }

            HttpSessionState session = HttpContext.Current.Session;

            if (session != null && session[key] != null)
            {
                session.Remove(key);
            }
        }

        public static void AddSessionKey(string key, object value)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return;
            }

            HttpSessionState session = HttpContext.Current.Session;
            if (session != null)
            {
                if (session[key] == null)
                {
                    session[key] = value;
                }
                else
                {
                    session.Add(key, value);
                }
            }
        }

        public static object GetSessionKey(string key)
        {
            if (!string.IsNullOrWhiteSpace(key))
            {
                HttpSessionState session = HttpContext.Current.Session;
                if (session != null && session[key] != null)
                {
                    return session[key];
                }
            }

            return null;
        }
    }
}