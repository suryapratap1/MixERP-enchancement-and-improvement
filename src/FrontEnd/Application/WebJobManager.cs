using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using MixERP.Net.WebJobs.BackupDatabase;
using Quartz;
using Quartz.Impl;

namespace MixERP.Net.FrontEnd.Application
{
    public static class WebJobManager
    {
        public static void Register()
        {
            int minutes = Conversion.TryCastInteger(ConfigurationHelper.GetDbServerParameter("AutoBackupEveryNMinutes"));

            if (minutes <= 0)
            {
                return;
            }

            ISchedulerFactory factory = new StdSchedulerFactory();

            IScheduler scheduler = factory.GetScheduler();
            scheduler.Start();

            IJobDetail job = JobBuilder.Create<BackupJob>().WithIdentity("BackupJob", "WebJobs").Build();

            ITrigger trigger = TriggerBuilder.Create().WithIdentity("BackupJobTrigger", "WebJobs")
                .WithSimpleSchedule(x => x.WithIntervalInMinutes(minutes).RepeatForever()).Build();

            scheduler.ScheduleJob(job, trigger);
        }
    }
}