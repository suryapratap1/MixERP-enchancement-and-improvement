using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MixERP.Net.Messaging.Email
{
    public class EmailTemplateProcessor
    {
        public string Template { get; private set; }
        public List<object> Dictionary { get; private set; }

        public EmailTemplateProcessor(string template, List<object> dictionary)
        {
            this.Template = template;
            this.Dictionary = dictionary;
        }

        public string Process()
        {
            List<string> parameters = this.GetParameters(this.Template);
            string template = this.Template;

            foreach (object item in this.Dictionary)
            {
                foreach (string parameter in parameters)
                {
                    string value = GetPropertyValue(item, parameter);

                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        template = template.Replace("{" + parameter + "}", value);
                    }
                }
            }

            //Remove null parameters
            parameters = this.GetParameters(this.Template);
            foreach (string parameter in parameters)
            {
                template = template.Replace("{" + parameter + "}", string.Empty);
            }

            return template;
        }

        private List<string> GetParameters(string template)
        {
            Regex regex = new Regex(@"(?<=\{)[^}]*(?=\})", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(template);

            return matches.Cast<Match>().Select(m => m.Value.Replace("{", "}")).Distinct().ToList();
        }

        private static string GetPropertyValue(object obj, string propertyName)
        {
            if (obj == null)
            {
                return string.Empty;
            }

            var prop = obj.GetType().GetProperty(propertyName);

            if (prop == null)
            {
                return string.Empty;
            }

            var value = prop.GetValue(obj, null);

            if (value == null)
            {
                return string.Empty;
            }

            return value.ToString();
        }
    }
}