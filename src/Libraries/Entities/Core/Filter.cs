// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("filter_id", autoIncrement = true)]
    [TableName("core.filters")]
    [ExplicitColumns]
    public sealed class Filter : PetaPocoDB.Record<Filter>, IPoco
    {
        [Column("filter_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.filters_filter_id_seq'::regclass)")]
        public long FilterId { get; set; }

        [Column("object_name")]
        [ColumnDbType("text", 0, false, "")]
        public string ObjectName { get; set; }

        [Column("filter_name")]
        [ColumnDbType("text", 0, false, "")]
        public string FilterName { get; set; }

        [Column("is_default")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsDefault { get; set; }

        [Column("is_default_admin")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsDefaultAdmin { get; set; }

        [Column("filter_statement")]
        [ColumnDbType("varchar", 12, false, "WHERE")]
        public string FilterStatement { get; set; }

        [Column("column_name")]
        [ColumnDbType("text", 0, false, "")]
        public string ColumnName { get; set; }

        [Column("filter_condition")]
        [ColumnDbType("int4", 0, false, "")]
        public int FilterCondition { get; set; }

        [Column("filter_value")]
        [ColumnDbType("text", 0, true, "")]
        public string FilterValue { get; set; }

        [Column("filter_and_value")]
        [ColumnDbType("text", 0, true, "")]
        public string FilterAndValue { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}