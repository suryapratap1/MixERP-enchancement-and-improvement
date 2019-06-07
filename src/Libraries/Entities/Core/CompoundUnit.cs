// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("compound_unit_id", autoIncrement = true)]
    [TableName("core.compound_units")]
    [ExplicitColumns]
    public sealed class CompoundUnit : PetaPocoDB.Record<CompoundUnit>, IPoco
    {
        [Column("compound_unit_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.compound_units_compound_unit_id_seq'::regclass)")]
        public int CompoundUnitId { get; set; }

        [Column("base_unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int BaseUnitId { get; set; }

        [Column("value")]
        [ColumnDbType("int2", 0, false, "")]
        public short Value { get; set; }

        [Column("compare_unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CompareUnitId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}