using MixERP.Net.Common.Helpers;
using MixERP.Net.Framework;
using System.Collections.Generic;
using System.IO;
using System.Web.Hosting;
using MixERP.Net.ApplicationState.Cache;

namespace MixERP.Net.Core.Modules.BackOffice.Models
{
    public sealed class ReportDefinition
    {
        private static readonly string reportContainer =
            HostingEnvironment.MapPath(ConfigurationHelper.GetReportParameter("ReportContainer"));

        public string Title { get; set; }
        public string FileName { get; set; }
        public string MenuCode { get; set; }
        public string ParentMenuCode { get; set; }
        public string TopSection { get; set; }
        public string Body { get; set; }
        public string BottomSection { get; set; }
        public IEnumerable<Data.ReportWriter.DataSource> DataSources { get; set; }
        public IEnumerable<Data.ReportWriter.Grid> GridViews { get; set; }

        public void Save()
        {
            if (string.IsNullOrWhiteSpace(this.FileName))
            {
                throw new MixERPException("Invalid file name \"" + this.FileName + "\".");
            }

            if (string.IsNullOrWhiteSpace(reportContainer) || !Directory.Exists(reportContainer))
            {
                throw new DirectoryNotFoundException(reportContainer);
            }

            if (!this.FileName.EndsWith(".xml"))
            {
                this.FileName += ".xml";
            }

            string path = Path.Combine(reportContainer, this.FileName);


            ReportBuilder builder = new ReportBuilder(this);

            string contents = builder.Build();

            File.WriteAllText(path, contents);

            Data.ReportWriter.SaveReport(this.FileName, this.MenuCode, this.ParentMenuCode, this.Title);
        }

        public ReportDefinition Get(string fileName)
        {
            string file = Path.Combine(reportContainer, fileName);

            if (File.Exists(file))
            {
                ReportParser parser = new ReportParser(fileName);

                return parser.Definition;
            }

            return new ReportDefinition();
        }
    }
}