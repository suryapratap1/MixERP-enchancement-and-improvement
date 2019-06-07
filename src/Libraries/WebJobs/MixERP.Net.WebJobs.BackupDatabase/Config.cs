using System.Configuration;
using System.Web.Hosting;

namespace MixERP.Net.WebJobs.BackupDatabase
{
    public static class Config
    {
        public static string GetConfigurationValue(string configFileName, string sectionName)
        {
            if (configFileName == null)
            {
                return string.Empty;
            }

            string path = HostingEnvironment.MapPath(ConfigurationManager.AppSettings[configFileName]);

            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap { ExeConfigFilename = path };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap,
                ConfigurationUserLevel.None);
            AppSettingsSection section = config.GetSection("appSettings") as AppSettingsSection;

            if (section != null)
            {
                if (section.Settings[sectionName] != null)
                {
                    return section.Settings[sectionName].Value;
                }
            }

            return string.Empty;
        }

        public static string GetDbServerParameter(string key)
        {
            return GetConfigurationValue("DbServerConfigFileLocation", key);
        }

    }
}