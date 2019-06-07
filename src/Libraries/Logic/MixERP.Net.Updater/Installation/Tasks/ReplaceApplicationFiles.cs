using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Framework;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.Updater.Installation.Tasks
{
    internal class ReplaceApplicationFiles : UpdateTask
    {
        public ReplaceApplicationFiles(UpdaterConfig config) : base(config)
        {
        }

        public override string Description
        {
            get { return Titles.RemovingApplication; }
        }

        private string CreateBatchFile()
        {
            var batch = new StringBuilder();
            batch.Append("@echo off");
            batch.Append(Environment.NewLine);
            batch.Append(@"set destination=""{0}""");
            batch.Append(Environment.NewLine);
            batch.Append("cd /d %destination%");
            batch.Append(Environment.NewLine);
            batch.Append(@"for /F ""delims="" %%i in ('dir /b') do (rmdir ""%%i"" /s/q || del ""%%i"" /s/q)");
            batch.Append(Environment.NewLine);
            batch.Append(@"xcopy ""{1}"" %destination% /s /e /h /y");
            batch.Append(Environment.NewLine);

            string source = this.Config.GetExtractDirectoryDestination();
            string destination = this.Config.ApplicationPath;

            string path = Path.Combine(PageUtility.MapPath(this.Config.TempPath), "update.bat");
            File.WriteAllText(path, string.Format(batch.ToString(), destination, source), Encoding.UTF8);

            return path;
        }



        public override void Run()
        {
            string path = this.Config.ApplicationPath;

            if (!Directory.Exists(path))
            {
                throw new MixERPException(Errors.CannotDetermineAppDirectoryPath);
            }

            this.OnProgress(new ProgressInfo(this.Description, string.Format(Labels.RestoringDirectory, this.Config.GetExtractDirectoryDestination())));


            string batchFile = this.CreateBatchFile();

            using (Process process = new Process())
            {
                process.StartInfo.FileName = batchFile;

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
            }
        }

        private void Data_Received(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.Data))
            {
                this.OnProgress(new ProgressInfo(this.Description, e.Data));
            }
        }

        private void Completed(object sender, EventArgs e)
        {
        }
    }
}