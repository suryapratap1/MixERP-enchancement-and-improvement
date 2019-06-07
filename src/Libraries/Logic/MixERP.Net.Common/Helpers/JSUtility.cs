using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Web.UI;

namespace MixERP.Net.Common.Helpers
{
    public static class JSUtility
    {
        public static void AddJSReference(Page page, string resourceName, string key, Type type)
        {
            if (page != null)
            {
                string script = "<script type='text/javascript' src='" + page.Request.Url.GetLeftPart(UriPartial.Authority) + page.ClientScript.GetWebResourceUrl(type, resourceName) + "'></script>";
                PageUtility.RegisterJavascript(key, script, page, false);
            }
        }

        public static string GetEmbeddedScript(string embeddedScriptName, Assembly assembly)
        {
            if (assembly == null)
            {
                return string.Empty;
            }

            if (string.IsNullOrWhiteSpace(embeddedScriptName))
            {
                return string.Empty;
            }

            Stream stream = assembly.GetManifestResourceStream(embeddedScriptName);

            if (stream == null)
            {
                return string.Empty;
            }

            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public static string GetVar(string name, object value, bool isString = true)
        {
            string script = "var {0}={1};";

            if (isString)
            {
                script = "var {0}='{1}';";
            }

            if (value == null)
            {
                script = string.Format(CultureInfo.InvariantCulture, script, name, string.Empty);
            }
            else
            {
                script = string.Format(CultureInfo.InvariantCulture, script, name, value.ToString().Replace("'", @"\'"));
            }

            return script;
        }
    }
}