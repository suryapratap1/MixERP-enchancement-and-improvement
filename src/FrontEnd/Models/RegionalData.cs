using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web.Hosting;

namespace MixERP.Net.FrontEnd.Models
{
    [Serializable]
    public class RegionalData
    {
        public RegionalData(string culture, string fileName, string filePath)
        {
            this.Culture = culture;
            this.FileName = fileName;
            this.FilePath = filePath;

            CultureInfo info = new CultureInfo(culture);

            this.Name = this.FileName + "-" + info.EnglishName;
        }

        public static List<RegionalData> GetRegionalDataList()
        {
            List<RegionalData> sampleCompanies = new List<RegionalData>();

            string baseDirectory = HostingEnvironment.MapPath("/Installation/regional");
            if (string.IsNullOrWhiteSpace(baseDirectory))
            {
                return sampleCompanies;
            }

            string[] directories = Directory.GetDirectories(baseDirectory);

            foreach (string directory in directories)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directory);

                if (CultureInfo.GetCultures(CultureTypes.SpecificCultures).Any(culture => culture.Name == directoryInfo.Name))
                {
                    FileInfo[] files = directoryInfo.GetFiles("*.sql");

                    foreach (var file in files)
                    {
                        string culture = directoryInfo.Name;
                        string fileName = Path.GetFileNameWithoutExtension(file.Name);
                        string filePath = file.FullName.Replace(baseDirectory, "").Replace("\\", "/").Replace(".sql", "");

                        RegionalData sample = new RegionalData(culture, fileName, filePath);
                        sampleCompanies.Add(sample);
                    }
                }
            }

            return sampleCompanies;
        }

        public string Culture { get; private set; }
        public string FileName { get; private set;}
        public string FilePath { get; private set; }
        public string Name { get; private set; }
    }
}