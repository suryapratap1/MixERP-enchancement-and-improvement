namespace MixERP.Net.WebJobs.BackupDatabase
{
    public sealed class PostgreSQLServer
    {
        public PostgreSQLServer()
        {
            this.BinDirectory = Config.GetDbServerParameter("PostgreSQLBinDirectory");
            this.DatabaseBackupDirectory = Config.GetDbServerParameter("DatabaseBackupDirectory");
            this.DatabaseName = Config.GetDbServerParameter("Database");
            this.HostName = Config.GetDbServerParameter("Server");
            this.PortNumber = int.Parse(Config.GetDbServerParameter("Port"));
            this.UserId = Config.GetDbServerParameter("UserId");
            this.Password = Config.GetDbServerParameter("Password");
            this.Validate();
        }

        public string BinDirectory { get; set; }
        public string DatabaseBackupDirectory { get; set; }
        public string DatabaseName { get; set; }
        public string HostName { get; set; }
        public bool IsValid { get; private set; }
        public string Password { get; set; }
        public int PortNumber { get; set; }
        public string UserId { get; set; }

        public void Validate()
        {
            this.IsValid = true;

            if (string.IsNullOrWhiteSpace(this.HostName))
            {
                this.IsValid = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(this.DatabaseName))
            {
                this.IsValid = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(this.UserId))
            {
                this.IsValid = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(this.Password))
            {
                this.IsValid = false;
                return;
            }

            if (this.PortNumber <= 0)
            {
                this.IsValid = false;
            }
        }
    }
}