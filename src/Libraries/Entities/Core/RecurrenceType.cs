// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("recurrence_type_id", autoIncrement = true)]
    [TableName("core.recurrence_types")]
    [ExplicitColumns]
    public sealed class RecurrenceType : PetaPocoDB.Record<RecurrenceType>, IPoco
    {
        [Column("recurrence_type_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.recurrence_types_recurrence_type_id_seq'::regclass)")]
        public int RecurrenceTypeId { get; set; }

        [Column("recurrence_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string RecurrenceTypeCode { get; set; }

        [Column("recurrence_type_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string RecurrenceTypeName { get; set; }

        [Column("is_frequency")]
        [ColumnDbType("bool", 0, false, "")]
        public bool IsFrequency { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}