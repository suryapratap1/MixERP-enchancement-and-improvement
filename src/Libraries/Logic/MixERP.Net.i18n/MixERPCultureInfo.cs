using System.Globalization;

namespace MixERP.Net.i18n
{
    public class MixERPCultureInfo : CultureInfo
    {
        /// <summary>
        /// Need contributors to implement new calendars.
        /// </summary>
        public override Calendar Calendar => new GregorianCalendar();

        public MixERPCultureInfo(string name) : base(name)
        {
        }

        public MixERPCultureInfo(string name, bool useUserOverride) : base(name, useUserOverride)
        {
        }

        public MixERPCultureInfo(int culture) : base(culture)
        {
        }

        public MixERPCultureInfo(int culture, bool useUserOverride) : base(culture, useUserOverride)
        {
        }
    }
}