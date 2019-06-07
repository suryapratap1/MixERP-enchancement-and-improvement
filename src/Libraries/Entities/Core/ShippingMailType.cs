// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("shipping_mail_type_id", autoIncrement = true)]
    [TableName("core.shipping_mail_types")]
    [ExplicitColumns]
    public sealed class ShippingMailType : PetaPocoDB.Record<ShippingMailType>, IPoco
    {
        [Column("shipping_mail_type_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.shipping_mail_types_shipping_mail_type_id_seq'::regclass)")]
        public int ShippingMailTypeId { get; set; }

        [Column("shipping_mail_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string ShippingMailTypeCode { get; set; }

        [Column("shipping_mail_type_name")]
        [ColumnDbType("varchar", 64, false, "")]
        public string ShippingMailTypeName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}