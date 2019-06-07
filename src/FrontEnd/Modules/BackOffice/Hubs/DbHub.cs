using Microsoft.AspNet.SignalR;
using Microsoft.VisualBasic.FileIO;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;
using Serilog;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Web.Hosting;
using MixERP.Net.Common.Extensions;
using MixERP.Net.WebJobs.BackupDatabase;

namespace MixERP.Net.Core.Modules.BackOffice.Hubs
{
    [CLSCompliant(false)]
    public class DbHub : Hub
    {
        public void BackupDatabase(string fileName)
        {
            if (!this.IsValidRequest())
            {
                this.Clients.Caller.getNotification(Warnings.AccessIsDenied, Warnings.AccessIsDenied);
                return;
            }

            if (string.IsNullOrWhiteSpace(fileName))
            {
                this.Clients.Caller.backupFailed(Warnings.NoFileSpecified);
                return;
            }

            PostgreSQLServer server = new PostgreSQLServer();
            server.DatabaseName = AppUsers.GetCurrentUserDB();

            BackupAgent agent = new BackupAgent(server, fileName);

            agent.BackupFail += delegate(BackupProgressInfo info)
            {
                this.Clients.Caller.backupFailed(info.Message);                
            };

            agent.Progress += delegate(BackupProgressInfo info)
            {
                this.Clients.Caller.getNotification(info.Message);                
            };

            agent.BackupComplete += delegate
            {
                StringBuilder message = new StringBuilder();
                message.Append(Labels.DatabaseBackupSuccessful);
                message.Append("&nbsp;");
                message.Append("<a href='");
                message.Append(
                    PageUtility.ResolveUrl(Path.Combine(server.DatabaseBackupDirectory, fileName + ".zip")));
                message.Append("'");
                message.Append(" target='_blank'>");
                message.Append(Labels.ClickHereToDownload);
                message.Append("</a>");

                this.Clients.Caller.backupCompleted(message.ToString());                
            };

            try
            {
                agent.PerformBackup();
            }
            catch (Exception ex)
            {
                this.Clients.Caller.backupFailed(ex.Message);
            }


        }

        private bool IsValidRequest()
        {
            System.Threading.Thread.Sleep(2000);

            if (this.Context == null)
            {
                this.Clients.Caller.getNotification(Warnings.AccessIsDenied);
                return false;
            }

            long globalLoginId = Conversion.TryCastLong(this.Context.User.Identity.Name);

            if (globalLoginId <= 0)
            {
                this.Clients.Caller.getNotification(Warnings.AccessIsDenied);
                return false;
            }

            if (!AppUsers.GetCurrent(globalLoginId).View.IsAdmin.ToBool())
            {
                return false;
            }

            if (!AppUsers.GetCurrent(globalLoginId).View.Elevated.ToBool())
            {
                return false;
            }

            return true;
        }

    }
}