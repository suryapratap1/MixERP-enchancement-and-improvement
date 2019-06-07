using System.Security;

namespace MixERP.Net.Messaging.Email
{
    public sealed class SmtpCredentials : ICredentials
    {
        public string Username { get; set; }
        public SecureString Password { get; set; }
    }
}