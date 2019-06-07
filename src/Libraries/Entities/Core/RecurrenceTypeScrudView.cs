// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.recurrence_type_scrud_view")]
    [ExplicitColumns]
    public sealed class RecurrenceTypeScrudView : PetaPocoDB.Record<RecurrenceTypeScrudView>, IPoco
    {
        [Column("recurrence_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? RecurrenceTypeId { get; set; }

        [Column("recurrence_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string RecurrenceTypeCode { get; set; }

        [Column("recurrence_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string RecurrenceTypeName { get; set; }

        [Column("is_frequency")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsFrequency { get; set; }
    }
}