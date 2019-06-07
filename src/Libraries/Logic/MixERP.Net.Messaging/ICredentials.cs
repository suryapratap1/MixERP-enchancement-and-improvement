using System.Security;

namespace MixERP.Net.Messaging.Email
{
    public interface ICredentials
    {
        string Username { get; set; }
        SecureString Password { get; set; }
    }
}