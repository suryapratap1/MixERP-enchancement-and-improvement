// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.frequency_selector_view")]
    [ExplicitColumns]
    public sealed class FrequencySelectorView : PetaPocoDB.Record<FrequencySelectorView>, IPoco
    {
        [Column("frequency_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? FrequencyId { get; set; }

        [Column("frequency_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string FrequencyCode { get; set; }

        [Column("frequency_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string FrequencyName { get; set; }
    }
}