using MixERP.Net.Common.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Web.Hosting;
using MixERP.Net.i18n;

namespace MixERP.Net.Core.Modules.BackOffice.Models
{
    public sealed class Report
    {
        public string FileName { get; set; }
        public string CreatedOn { get; set; }
        public string LastAccessedOn { get; set; }
        public string LastWrittenOn { get; set; }

        public static IEnumerable<Report> GetReports()
        {
            Collection<Report> models = new Collection<Report>();

            string reportContainer =
                HostingEnvironment.MapPath(ConfigurationHelper.GetReportParameter("ReportContainer"));

            if (reportContainer != null)
            {
                if (Directory.Exists(reportContainer))
                {
                    DirectoryInfo directory = new DirectoryInfo(reportContainer);

                    foreach (FileInfo fileInfo in directory.GetFiles("*.xml"))
                    {
                        if (fileInfo != null)
                        {
                            Report model = new Report();

                            model.FileName = fileInfo.Name;
                            model.CreatedOn = fileInfo.CreationTime.ToString(CultureManager.GetCurrent());
                            model.LastWrittenOn = fileInfo.LastWriteTime.ToString(CultureManager.GetCurrent());
                            model.LastAccessedOn = fileInfo.LastAccessTime.ToString(CultureManager.GetCurrent());

                            models.Add(model);
                        }
                    }
                }
            }

            return models;
        }
    }
}