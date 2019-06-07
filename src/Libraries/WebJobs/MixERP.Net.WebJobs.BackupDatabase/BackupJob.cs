using System;
using System.Threading;
using Quartz;
using Serilog;

namespace MixERP.Net.WebJobs.BackupDatabase
{
    public class BackupJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            ThreadPool.QueueUserWorkItem(callback =>
            {
                PostgreSQLServer server = new PostgreSQLServer();
                string fileName = DateTime.Now.Ticks.ToString();

                BackupAgent agent = new BackupAgent(server, fileName);

                try
                {
                    agent.PerformBackup();
                }
                catch (Exception ex)
                {
                    Log.Error("Exception occurred executing the backup job. {Exception}.", ex);
                }
            });

        }
    }
}