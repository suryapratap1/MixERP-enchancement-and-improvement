using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using MixERP.Net.Messaging.Email.Helpers;
using Serilog;

namespace MixERP.Net.Messaging.Email
{
    public sealed class Processor
    {
        public Processor(string catalog)
        {
            this.Catalog = catalog;
        }

        public string Catalog { get; set; }

        public async Task<bool> Send(string sendTo, string subject, string body, bool deleteAttachmentes,
            params string[] attachments)
        {
            Config config = new Config(this.Catalog);

            if (!config.Enabled)
            {
                return false;
            }


            EmailMessage email = new EmailMessage
            {
                FromName = config.FromName,
                FromEmail = config.FromEmail,
                Subject = subject,
                SentTo = sendTo,
                Message = body,
                Type = Type.Outward,
                EventDateUTC = DateTime.UtcNow,
                Status = Status.Unknown
            };

            SmtpHost host = new SmtpHost
            {
                Address = config.SmtpHost,
                Port = config.SmtpPort,
                EnableSSL = config.EnableSsl,
                DeliveryMethod = config.DeliveryMethod,
                PickupDirectory = config.PickupDirectory
            };

            ICredentials credentials = new SmtpCredentials
            {
                Username = config.SmtpUsername,
                Password = config.SmtpUserPassword
            };

            return await this.Send(email, host, credentials, deleteAttachmentes, attachments);
        }

        public async Task<bool> Send(EmailMessage email, SmtpHost host, ICredentials credentials,
            bool deleteAttachmentes, params string[] attachments)
        {
            if (string.IsNullOrWhiteSpace(email.SentTo))
            {
                throw new ArgumentNullException(email.SentTo);
            }

            if (string.IsNullOrWhiteSpace(email.Message))
            {
                throw new ArgumentNullException(email.Message);
            }

            string[] addresses = email.SentTo.Split(',');
            foreach (string address in addresses)
            {
                Validator validator = new Validator(address);
                validator.Validate();

                if (!validator.IsValid)
                {
                    return false;
                }
            }

            addresses = addresses.Distinct().ToArray();
            email.SentTo = string.Join(",", addresses);
            email.Status = Status.Executing;

            MailAddress sender = new MailAddress(email.FromEmail, email.FromName);

            using (MailMessage mail = new MailMessage(email.FromEmail, email.SentTo))
            {
                if (attachments != null)
                {
                    foreach (string file in attachments)
                    {
                        if (!string.IsNullOrWhiteSpace(file))
                        {
                            if (File.Exists(file))
                            {
                                Attachment attachment = new Attachment(file, MediaTypeNames.Application.Octet);

                                ContentDisposition disposition = attachment.ContentDisposition;
                                disposition.CreationDate = File.GetCreationTime(file);
                                disposition.ModificationDate = File.GetLastWriteTime(file);
                                disposition.ReadDate = File.GetLastAccessTime(file);

                                disposition.FileName = Path.GetFileName(file);
                                disposition.Size = new FileInfo(file).Length;
                                disposition.DispositionType = DispositionTypeNames.Attachment;

                                mail.Attachments.Add(attachment);
                            }
                        }
                    }
                }


                mail.From = sender;
                using (SmtpClient smtp = new SmtpClient(host.Address, host.Port))
                {
                    smtp.DeliveryMethod = host.DeliveryMethod;
                    smtp.PickupDirectoryLocation = host.PickupDirectory;

                    smtp.EnableSsl = host.EnableSSL;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(credentials.Username, credentials.Password);
                    try
                    {
                        mail.Subject = email.Subject;
                        mail.Body = email.Message;
                        mail.IsBodyHtml = true;
                        mail.SubjectEncoding = Encoding.UTF8;
                        email.Status = Status.Completed;

                        await smtp.SendMailAsync(mail);
                        return true;
                    }
                    catch (SmtpException ex)
                    {
                        email.Status = Status.Failed;
                        Log.Warning(@"Could not send email to {To}. {Ex}. ", email.SentTo, ex);
                    }
                    finally
                    {
                        foreach (IDisposable item in mail.Attachments)
                        {
                            if (item != null)
                            {
                                item.Dispose();
                            }
                        }

                        if (deleteAttachmentes)
                        {
                            this.DeleteFiles(attachments);
                        }
                    }
                }
            }

            return false;
        }

        private void DeleteFiles(params string[] files)
        {
            foreach (string file in files)
            {
                if (!string.IsNullOrWhiteSpace(file))
                {
                    if (File.Exists(file))
                    {
                        File.Delete(file);
                    }
                }
            }
        }
    }
}