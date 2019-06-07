using System.Collections.Generic;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Messaging.Email.Database
{
    internal static class MailQueue
    {
        public static void AddToQueue(string catalog, EmailQueue queue)
        {
            Factory.Insert(catalog, queue);
        }

        public static IEnumerable<EmailQueue> GetMailInQueue(string catlog)
        {
            const string sql = "SELECT * FROM core.email_queue WHERE NOT delivered AND NOT canceled;";
            return Factory.Get<EmailQueue>(catlog, sql);
        }
    }
}