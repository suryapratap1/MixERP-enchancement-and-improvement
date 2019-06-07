// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("identification_type_code", autoIncrement = false)]
    [TableName("core.identification_types")]
    [ExplicitColumns]
    public sealed class IdentificationType : PetaPocoDB.Record<IdentificationType>, IPoco
    {
        [Column("identification_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string IdentificationTypeCode { get; set; }

        [Column("identification_type_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string IdentificationTypeName { get; set; }

        [Column("can_expire")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool CanExpire { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}