using System;

namespace MixERP.Net.Common.Helpers
{
    public static class DateHelper
    {
        public static DateTime GetMonthStartDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime GetMonthEndDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }
    }
}