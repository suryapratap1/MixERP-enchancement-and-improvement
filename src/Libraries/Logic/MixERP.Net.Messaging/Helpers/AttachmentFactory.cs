using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;

namespace MixERP.Net.Messaging.Email
{
    public static class AttachmentFactory
    {
        public static List<Attachment> GetAttachments(params string[] files)
        {
            List<Attachment> attachments = new List<Attachment>();

            if (files != null)
            {
                foreach (string file in files)
                {
                    if (!string.IsNullOrWhiteSpace(file))
                    {
                        using (Attachment attachment = new Attachment(file, MediaTypeNames.Application.Octet))
                        {
                            ContentDisposition disposition = attachment.ContentDisposition;
                            disposition.CreationDate = File.GetCreationTime(file);
                            disposition.ModificationDate = File.GetLastWriteTime(file);
                            disposition.ReadDate = File.GetLastAccessTime(file);

                            disposition.FileName = Path.GetFileName(file);
                            disposition.Size = new FileInfo(file).Length;
                            disposition.DispositionType = DispositionTypeNames.Attachment;

                            attachments.Add(attachment);
                        }
                    }
                }
            }

            return attachments;
        }
    }
}