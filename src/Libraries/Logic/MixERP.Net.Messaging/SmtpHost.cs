using System.Net.Mail;

namespace MixERP.Net.Messaging.Email
{
    public sealed class SmtpHost
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public bool EnableSSL { get; set; }
        public SmtpDeliveryMethod DeliveryMethod { get; set; }
        public string PickupDirectory { get; set; }
    }
}