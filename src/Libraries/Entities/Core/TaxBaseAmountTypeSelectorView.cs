// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.tax_base_amount_type_selector_view")]
    [ExplicitColumns]
    public sealed class TaxBaseAmountTypeSelectorView : PetaPocoDB.Record<TaxBaseAmountTypeSelectorView>, IPoco
    {
        [Column("tax_base_amount_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string TaxBaseAmountTypeCode { get; set; }

        [Column("tax_base_amount_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string TaxBaseAmountTypeName { get; set; }
    }
}