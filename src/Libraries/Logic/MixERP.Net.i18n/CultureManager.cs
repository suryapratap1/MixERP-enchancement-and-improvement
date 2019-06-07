using System.Globalization;

namespace MixERP.Net.i18n
{
    public static class CultureManager
    {
        public static int GetCurrencyDecimalPlaces()
        {
            CultureInfo culture = GetCurrentUICulture();
            return culture.NumberFormat.CurrencyDecimalDigits;
        }

        public static string GetCurrencySymbol()
        {
            CultureInfo culture = GetCurrentUICulture();
            return culture.NumberFormat.CurrencySymbol;
        }

        public static bool IsRtl()
        {
            CultureInfo culture = GetCurrent();

            if (culture == null)
            {
                return false;
            }

            return culture.TextInfo.IsRightToLeft;
        }


        public static CultureInfo GetCurrentUICulture()
        {
            CultureInfo culture = CultureInfo.DefaultThreadCurrentUICulture ?? CultureInfo.CurrentUICulture;
            var cultureString = culture.ToString();
            if (cultureString.Equals("fr") || cultureString.Equals("ru") || cultureString.Equals("fr-FR"))
            {
                culture.NumberFormat.CurrencyGroupSeparator = "\x0020";
                culture.NumberFormat.NumberGroupSeparator = "\x0020";
            }
            return culture;
        }

        public static CultureInfo GetCurrent()
        {
            return CultureInfo.DefaultThreadCurrentCulture ?? CultureInfo.CurrentCulture;
        }

        public static string GetDecimalSeparator()
        {
            CultureInfo culture = GetCurrentUICulture();
            return culture.NumberFormat.CurrencyDecimalSeparator;
        }

        public static int GetNumberDecimalPlaces()
        {
            CultureInfo culture = GetCurrentUICulture();
            return culture.NumberFormat.NumberDecimalDigits;
        }

        public static string GetShortDateFormat()
        {
            CultureInfo culture = GetCurrentUICulture();
            return culture.DateTimeFormat.ShortDatePattern;
        }

        public static string GetLongDateFormat()
        {
            CultureInfo culture = GetCurrentUICulture();
            return culture.DateTimeFormat.LongDatePattern;
        }

        public static string GetThousandSeparator()
        {
            CultureInfo culture = GetCurrentUICulture();
            return culture.NumberFormat.CurrencyGroupSeparator;
        }
    }
}