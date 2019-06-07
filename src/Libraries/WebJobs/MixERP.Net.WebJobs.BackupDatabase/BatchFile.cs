using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;

namespace MixERP.Net.WebJobs.BackupDatabase
{
    internal class BatchFile
    {
        public BatchFile(string fileName)
        {
            this.FileName = fileName;
        }

        public BatchFile(string fileName, PostgreSQLServer server, string pgDumpPath)
        {
            this.FileName = fileName;
            this.Server = server;
            this.PgDumpPath = pgDumpPath;
        }

        public PostgreSQLServer Server { get; private set; }
        public string PgDumpPath { get; private set; }
        public string FileName { get; private set; }

        public string Create()
        {
            Collection<string> commands = new Collection<string>();
            commands.Add("@echo off");
            commands.Add("SET PGPASSWORD=" + this.Server.Password);
            string command =
                @"""{0}"" --host ""{1}"" --port {2} --username ""{3}"" --format custom --blobs --verbose --file ""{4}"" ""{5}""";
            command = string.Format(CultureInfo.InvariantCulture, command, this.PgDumpPath, this.Server.HostName,
                this.Server.PortNumber, this.Server.UserId, this.FileName, this.Server.DatabaseName);
            commands.Add(command);
            commands.Add("exit");

            string file = this.FileName + ".bat";

            File.WriteAllText(file, string.Join(Environment.NewLine, commands));

            return file;
        }

        public void Delete()
        {
            if (File.Exists(this.FileName))
            {
                File.Delete(this.FileName);
            }
        }
    }
}