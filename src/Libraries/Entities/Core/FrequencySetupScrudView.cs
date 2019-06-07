// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.frequency_setup_scrud_view")]
    [ExplicitColumns]
    public sealed class FrequencySetupScrudView : PetaPocoDB.Record<FrequencySetupScrudView>, IPoco
    {
        [Column("frequency_setup_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? FrequencySetupId { get; set; }

        [Column("frequency_setup_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string FrequencySetupCode { get; set; }

        [Column("fiscal_year_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string FiscalYearCode { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ValueDate { get; set; }

        [Column("frequency_code")]
        [ColumnDbType("text", 0, true, "")]
        public string FrequencyCode { get; set; }
    }
}