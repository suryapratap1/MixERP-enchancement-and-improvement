using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MixERP.Net.Messaging.Email
{
    internal class Validator
    {
        private bool isValid;

        public Validator(string emailAddress)
        {
            this.EmailAddress = emailAddress;
        }

        public bool IsValid
        {
            get { return this.isValid; }
        }

        public string EmailAddress { get; set; }

        public void Validate()
        {
            this.isValid = false;

            if (String.IsNullOrWhiteSpace(this.EmailAddress))
            {
                return;
            }

            string emailAddress = this.EmailAddress;

            emailAddress = Regex.Replace(emailAddress, @"(@)(.+)$", this.DomainMapper);

            // Return true if address is in valid e-mail format.
            this.isValid = Regex.IsMatch(emailAddress,
                @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                RegexOptions.IgnoreCase);
        }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                this.isValid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}