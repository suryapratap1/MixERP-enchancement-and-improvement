// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("frequency_setup_id", autoIncrement = true)]
    [TableName("core.frequency_setups")]
    [ExplicitColumns]
    public sealed class FrequencySetup : PetaPocoDB.Record<FrequencySetup>, IPoco
    {
        [Column("frequency_setup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.frequency_setups_frequency_setup_id_seq'::regclass)")]
        public int FrequencySetupId { get; set; }

        [Column("fiscal_year_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string FiscalYearCode { get; set; }

        [Column("frequency_setup_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string FrequencySetupCode { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("frequency_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int FrequencyId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}