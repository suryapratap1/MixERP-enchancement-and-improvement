using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Web.Hosting;

namespace MixERP.Net.Common.Helpers
{
    public static class ConfigurationHelper
    {
        public static string GetConfigurationValue(string configFileName, string sectionName)
        {
            if (configFileName == null)
            {
                return string.Empty;
            }

            string path = HostingEnvironment.MapPath(ConfigurationManager.AppSettings[configFileName]);

            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap {ExeConfigFilename = path};
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

        public static string GetParameter(string key)
        {
            return GetConfigurationValue("ParameterConfigFileLocation", key);
        }


        public static string GetReportParameter(string key)
        {
            return GetConfigurationValue("ReportConfigFileLocation", key);
        }

        public static string GetResourceDirectory()
        {
            return HostingEnvironment.MapPath(ConfigurationManager.AppSettings["ResourceDirectory"]);
        }

        public static string GetStockTransactionFactoryParameter(string key)
        {
            return GetConfigurationValue("StockTransactionFactoryConfigFileLocation", key);
        }

        public static string GetUpdaterParameter(string key)
        {
            return GetConfigurationValue("UpdaterConfigFileLocation", key);
        }


        public static string SetConfigurationValues(string configFileName, string sectionName, string value)
        {
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap {ExeConfigFilename = configFileName};
            var config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            AppSettingsSection section = config.GetSection("appSettings") as AppSettingsSection;

            if (section != null)
            {
                if (section.Settings[sectionName] != null)
                {
                    section.Settings[sectionName].Value = value;
                }
            }
            config.Save(ConfigurationSaveMode.Modified);

            return string.Empty;
        }

        public static void SetConfigurationValues(string configFileName,
            Collection<KeyValuePair<string, string>> sections)
        {
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap {ExeConfigFilename = configFileName};
            var config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            AppSettingsSection appsetting = config.GetSection("appSettings") as AppSettingsSection;

            if (appsetting == null)
            {
                return;
            }

            if (sections != null && sections.Count > 0)
            {
                foreach (var section in sections)
                {
                    if (section.Key != null)
                    {
                        if (appsetting.Settings[section.Key] != null)
                        {
                            appsetting.Settings[section.Key].Value = section.Value;
                        }
                    }
                }
            }

            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}