// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("price_type_id", autoIncrement = true)]
    [TableName("core.price_types")]
    [ExplicitColumns]
    public sealed class PriceType : PetaPocoDB.Record<PriceType>, IPoco
    {
        [Column("price_type_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.price_types_price_type_id_seq'::regclass)")]
        public int PriceTypeId { get; set; }

        [Column("price_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string PriceTypeCode { get; set; }

        [Column("price_type_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string PriceTypeName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}