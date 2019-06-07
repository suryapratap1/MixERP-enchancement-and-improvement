// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("store_type_id", autoIncrement = true)]
    [TableName("office.store_types")]
    [ExplicitColumns]
    public sealed class StoreType : PetaPocoDB.Record<StoreType>, IPoco
    {
        [Column("store_type_id")]
        [ColumnDbType("int4", 0, false, "nextval('office.store_types_store_type_id_seq'::regclass)")]
        public int StoreTypeId { get; set; }

        [Column("store_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string StoreTypeCode { get; set; }

        [Column("store_type_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string StoreTypeName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}