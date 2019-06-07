using System;

namespace MixERP.Net.WebJobs.BackupDatabase
{
    public delegate void BackupComplete(object sender, EventArgs args);
    public delegate void BackupFail(BackupProgressInfo progressInfo);
    public delegate void BackupProgress(BackupProgressInfo progressInfo);

    public sealed class BackupProgressInfo
    {
        public BackupProgressInfo(string message)
        {
            this.Timestamp = DateTime.UtcNow;
            this.Message = message;
        }

        public DateTime Timestamp { get; private set; }
        public string Message { get; set; }
    }
}