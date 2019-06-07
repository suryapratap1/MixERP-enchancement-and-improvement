using System;
using System.Web;
using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Updater.Api;
using Serilog;

namespace MixERP.Net.FrontEnd.Application
{
    internal static class UpdateManager
    {
        internal static async void CheckForUpdates(HttpApplicationState application)
        {
            bool autoSuggestUpdate =
                Conversion.TryCastBoolean(ConfigurationHelper.GetUpdaterParameter("AutoSuggestUpdate"));

            if (autoSuggestUpdate)
            {
                try
                {
                    Updater.UpdateManager updater = new Updater.UpdateManager();
                    Release release = await updater.GetLatestReleaseAsync();

                    if (release != null)
                    {
                        application["UpdateAvailable"] = true;
                    }
                }
                catch (Exception ex)
                {
                    Log.Error("Exception occurred. {Exception}.", ex);
                }
            }
        }
    }
}