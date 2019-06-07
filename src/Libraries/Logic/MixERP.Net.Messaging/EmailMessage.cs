using System;

namespace MixERP.Net.Messaging.Email
{
    public sealed class EmailMessage : IMessage
    {
        public string Subject { get; set; }
        public Type Type { get; set; }
        public DateTime EventDateUTC { get; set; }
        public Status Status { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public string SentTo { get; set; }
        public string Message { get; set; }
    }
}