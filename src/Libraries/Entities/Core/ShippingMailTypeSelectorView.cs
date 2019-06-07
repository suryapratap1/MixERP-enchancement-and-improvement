// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.shipping_mail_type_selector_view")]
    [ExplicitColumns]
    public sealed class ShippingMailTypeSelectorView : PetaPocoDB.Record<ShippingMailTypeSelectorView>, IPoco
    {
        [Column("shipping_mail_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ShippingMailTypeId { get; set; }

        [Column("shipping_mail_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ShippingMailTypeCode { get; set; }

        [Column("shipping_mail_type_name")]
        [ColumnDbType("varchar", 64, true, "")]
        public string ShippingMailTypeName { get; set; }
    }
}