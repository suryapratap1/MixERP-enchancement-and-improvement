using System;
using System.IO;
using System.Web.Hosting;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.WebJobs.BackupDatabase
{
    public sealed class BackupAgent
    {
        public BackupAgent(PostgreSQLServer server, string fileName)
        {
            this.FileName = fileName;
            this.PostgreSQL = server;
        }

        public string FileName { get; set; }
        public PostgreSQLServer PostgreSQL { get; set; }
        public event BackupProgress Progress;
        public event BackupComplete BackupComplete;
        public event BackupFail BackupFail;

        public bool PerformBackup()
        {
            string backupDirectory = HostingEnvironment.MapPath(this.PostgreSQL.DatabaseBackupDirectory);

            if (backupDirectory == null)
            {
                this.OnOnBackupFail(new BackupProgressInfo(Warnings.BackupDirectoryNotFound));
                return false;

            }

            backupDirectory = Path.Combine(backupDirectory, this.FileName);
            string path = Path.Combine(backupDirectory, "db.backup");
            
            Directory.CreateDirectory(backupDirectory);


            BackupProcess process = new BackupProcess(this.PostgreSQL, path);

            process.Progress += delegate(BackupProgressInfo info)
            {
                BackupProgress progress = this.Progress;

                if (progress != null)
                {
                    progress(new BackupProgressInfo(info.Message));
                }
            };

            process.BackupComplete += delegate(object sender, EventArgs args)
            {
                BackupResource resourceBackup = new BackupResource(backupDirectory);
                resourceBackup.Backup();

                BackupCompression compression = new BackupCompression(backupDirectory);
                compression.Compress(true);

                BackupComplete complete = this.BackupComplete;

                if (complete != null)
                {
                    complete(this, args);
                }
            };

            bool result = process.Execute();

            if (!result)
            {
                this.OnOnBackupFail(new BackupProgressInfo(Warnings.CannotCreateABackup));
                return false;
            }

            return true;
        }

        private void OnOnBackupFail(BackupProgressInfo progressinfo)
        {
            BackupFail fail = this.BackupFail;
            if (fail != null)
            {
                fail(progressinfo);
            }
        }
    }
}