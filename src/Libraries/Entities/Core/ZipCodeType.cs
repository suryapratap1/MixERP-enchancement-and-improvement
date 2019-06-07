// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("zip_code_type_id", autoIncrement = true)]
    [TableName("core.zip_code_types")]
    [ExplicitColumns]
    public sealed class ZipCodeType : PetaPocoDB.Record<ZipCodeType>, IPoco
    {
        [Column("zip_code_type_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.zip_code_types_zip_code_type_id_seq'::regclass)")]
        public int ZipCodeTypeId { get; set; }

        [Column("type")]
        [ColumnDbType("varchar", 12, true, "")]
        public string Type { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}