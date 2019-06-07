using MixERP.Net.Framework;
using System.Collections.ObjectModel;

namespace MixERP.Net.ApplicationState
{
    public static class Dates
    {
        private const string appDatesKey = "ApplicationDates";

        public static Collection<FrequencyDates> GetFrequencyDates(string catalog)
        {
            object dates = CacheFactory.GetFromDefaultCacheByKey(catalog + appDatesKey);

            if (dates == null)
            {
                return new Collection<FrequencyDates>();
            }

            return dates as Collection<FrequencyDates>;
        }

        public static void SetApplicationDates(string catalog, Collection<FrequencyDates> applicationDates)
        {
            CacheFactory.AddToDefaultCache(catalog + appDatesKey, applicationDates);
        }
    }
}