using System.Configuration;
using System.IO;
using System.Web.Hosting;
using Microsoft.VisualBasic.FileIO;

namespace MixERP.Net.WebJobs.BackupDatabase
{
    public sealed class BackupResource
    {
        public BackupResource(string backupDirectory)
        {
            this.BackupDirectory = backupDirectory;
        }

        public string BackupDirectory { get; private set; }

        public void Backup()
        {
            string source = HostingEnvironment.MapPath(ConfigurationManager.AppSettings["ResourceDirectory"]);

            if (source != null)
            {
                string destination = Path.Combine(this.BackupDirectory, new DirectoryInfo(source).Name);

                FileSystem.CopyDirectory(source, destination);
            }
        }
    }
}