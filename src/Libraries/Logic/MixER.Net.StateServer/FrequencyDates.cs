using System;

namespace MixERP.Net.ApplicationState
{
    public class FrequencyDates : ICloneable
    {
        public DateTime FiscalHalfEndDate { get; set; }
        public DateTime FiscalHalfStartDate { get; set; }
        public DateTime FiscalYearEndDate { get; set; }
        public DateTime FiscalYearStartDate { get; set; }
        public DateTime? ForcedLogOffTimestamp { get; set; }
        public DateTime MonthEndDate { get; set; }
        public DateTime MonthStartDate { get; set; }
        public bool NewDayStarted { get; set; }
        public int OfficeId { get; set; }
        public DateTime QuarterEndDate { get; set; }
        public DateTime QuarterStartDate { get; set; }
        public DateTime Today { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}