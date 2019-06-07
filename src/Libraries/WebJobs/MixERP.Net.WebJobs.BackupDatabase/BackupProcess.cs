using System;
using System.Diagnostics;
using System.IO;

namespace MixERP.Net.WebJobs.BackupDatabase
{
    public sealed class BackupProcess
    {
        public BackupProcess(PostgreSQLServer server, string fileName)
        {
            this.Server = server;
            this.PgDumpPath = Path.Combine(this.Server.BinDirectory, "pg_dump.exe"); ;
            this.FileName = fileName;
        }

        public string BatchFileName { get; set; }
        public string PgDumpPath { get; set; }
        public PostgreSQLServer Server { get; set; }
        public string FileName { get; set; }
        public event BackupProgress Progress;
        public event BackupComplete BackupComplete;

        public bool Execute()
        {
            BatchFile batchFile = new BatchFile(this.FileName, this.Server, this.PgDumpPath);
            this.BatchFileName = batchFile.Create();

            using (Process process = new Process())
            {
                process.StartInfo.FileName = this.BatchFileName;

                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.ErrorDialog = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;

                process.ErrorDataReceived += this.Data_Received;
                process.OutputDataReceived += this.Data_Received;
                process.Disposed += this.Completed;

                process.Start();

                process.BeginErrorReadLine();
                process.BeginOutputReadLine();

                process.WaitForExit();


                return true;
            }
        }

        private void Data_Received(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.Data))
            {
                BackupProgress progress = this.Progress;

                if (progress != null)
                {
                    progress(new BackupProgressInfo(e.Data));
                }
            }
        }

        private void Completed(object sender, EventArgs e)
        {
            BackupComplete complete = this.BackupComplete;

            if (complete != null)
            {
                BatchFile batchFile = new BatchFile(this.BatchFileName);
                batchFile.Delete();

                complete(this, e);
            }
        }
    }
}