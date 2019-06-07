using System;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Hosting;
using Codaxy.WkHtmlToPdf;

namespace MixERP.Net.Common.Helpers
{
    public static class ExportHelper
    {
        public static string CreatePDF(string html, string destination = "")
        {
            string id = Guid.NewGuid().ToString();

            //public directory is allowed direct access
            string source = "~/Resource/Temp/Public/" + id + ".html";

            if (string.IsNullOrWhiteSpace(destination))
            {
                destination = HostingEnvironment.MapPath("~/Resource/Temp/" + id + ".pdf");
            }


            WriteHtml(source, html);
            ToPdf(source, destination);
            RemoveFile(source);

            return destination;
        }

        public static string CreateExcel(string html, string documentName = "")
        {
            string id = Guid.NewGuid() + ".xls";

            if (!string.IsNullOrWhiteSpace(documentName))
            {
                id = documentName;
            }

            //public directory is allowed direct access
            string source = "~/Resource/Temp/Public/" + id;
            WriteHtml(source, html);
            return HostingEnvironment.MapPath(source);
        }

        public static string CreateWord(string html, string documentName = "")
        {
            string id = Guid.NewGuid() + ".doc";

            if (!string.IsNullOrWhiteSpace(documentName))
            {
                id = documentName;
            }

            //public directory is allowed direct access
            string source = "~/Resource/Temp/Public/" + id;
            WriteHtml(source, html);
            return HostingEnvironment.MapPath(source);
        }

        public static void DownloadExcel(string html)
        {
            string path = CreateExcel(html);
            try
            {
                OpenDownload(path, "application/vnd.xls", "xls");

            }
            finally
            {
                File.Delete(path);
            }
        }

        public static void DownloadWord(string html)
        {
            string path = CreateWord(html);

            try
            {
                OpenDownload(path, "application/vnd.doc", "doc");
            }
            finally
            {
                File.Delete(path);
            }
        }

        public static void DownloadPdf(string html)
        {
            string path = CreatePDF(html);

            try
            {
                OpenDownload(path, "application/pdf", "pdf");
            }
            finally
            {
                File.Delete(path);
            }
        }

        private static void OpenDownload(string path, string mimeType, string extension)
        {
            string fileName = Path.GetFileNameWithoutExtension(HttpContext.Current.Request.Url.AbsolutePath);

            HttpResponse response = HttpContext.Current.Response;


            response.Clear();
            response.ClearHeaders();
            response.ClearContent();
            response.AddHeader("Content-Disposition", "attachment; filename=" + fileName + "." + extension);
            response.ContentType = mimeType;
            response.Flush();

            using (var stream = GetFileStream(path))
            {
                response.BinaryWrite(stream.ToArray());                
            }

            response.End();
        }

        private static MemoryStream GetFileStream(string filePath)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (FileStream fs = File.OpenRead(filePath))
                {
                    fs.CopyTo(ms);
                }

                return ms;
            }
        }

        private static void WriteHtml(string path, string html)
        {
            string file = HostingEnvironment.MapPath(path);

            if (file != null)
            {
                File.WriteAllText(file, html, Encoding.UTF8);
            }
        }

        private static void RemoveFile(string path)
        {
            string file = HostingEnvironment.MapPath(path);

            if (file != null)
            {
                File.Delete(file);
            }
        }

        public static void ToPdf(string source, string destination)
        {
            PdfConvert.Environment.WkHtmlToPdfPath = HostingEnvironment.MapPath("~/plugins/wkhtmltopdf/wkhtmltopdf.exe");
            PdfConvert.Environment.Timeout = 30000;

            PdfConvert.ConvertHtmlToPdf(new PdfDocument
            {
                Url = PageUtility.ResolveAbsoluteUrl(source)
            }, new PdfOutput
            {
                OutputFilePath = destination
            });
        }
    }
}