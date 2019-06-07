using System;
using System.IO;
using System.Web.Hosting;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Helpers;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace MixERP.Net.FrontEnd.Application
{
    internal static class LogManager
    {
        private static string GetLogDirectory()
        {
            string path = DbConfig.GetMixERPParameter(AppUsers.GetCurrentUserDB(), "ApplicationLogDirectory");

            if (string.IsNullOrWhiteSpace(path))
            {
                return HostingEnvironment.MapPath("~/Resource/Temp");
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }

        private static string GetLogFileName()
        {
            string applicationLogDirectory = GetLogDirectory();
            string filePath = Path.Combine(applicationLogDirectory,
                DateTime.Now.Date.ToShortDateString().Replace(@"/", "-"), "log.txt");
            return filePath;
        }

        private static LoggerConfiguration GetConfiguration()
        {
            string minimumLogLevel = DbConfig.GetMixERPParameter(AppUsers.GetCurrentUserDB(), "MinimumLogLevel");

            LoggingLevelSwitch levelSwitch = new LoggingLevelSwitch();

            LogEventLevel logLevel;
            Enum.TryParse(minimumLogLevel, out logLevel);

            levelSwitch.MinimumLevel = logLevel;

            return
                new LoggerConfiguration().MinimumLevel.ControlledBy(levelSwitch)
                    .WriteTo.RollingFile(GetLogFileName());
        }

        internal static void IntializeLogger()
        {
            Log.Logger = GetConfiguration().CreateLogger();

            Log.Information("Application started.");
        }
    }
}