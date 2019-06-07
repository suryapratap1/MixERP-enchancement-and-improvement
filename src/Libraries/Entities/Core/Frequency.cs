// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("frequency_id", autoIncrement = true)]
    [TableName("core.frequencies")]
    [ExplicitColumns]
    public sealed class Frequency : PetaPocoDB.Record<Frequency>, IPoco
    {
        [Column("frequency_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.frequencies_frequency_id_seq'::regclass)")]
        public int FrequencyId { get; set; }

        [Column("frequency_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string FrequencyCode { get; set; }

        [Column("frequency_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string FrequencyName { get; set; }
    }
}