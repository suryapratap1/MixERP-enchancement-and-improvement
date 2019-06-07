using System.IO;
using System.IO.Compression;

namespace MixERP.Net.WebJobs.BackupDatabase
{
    internal class BackupCompression
    {
        public BackupCompression(string backupDirectory)
        {
            this.BackupDirectory = backupDirectory;
        }

        public string BackupDirectory { get; private set; }

        public void Compress(bool removeSource)
        {
            ZipFile.CreateFromDirectory(this.BackupDirectory, this.BackupDirectory + ".zip");

            if (removeSource)
            {
                Directory.Delete(this.BackupDirectory, true);
            }
        }
    }
}