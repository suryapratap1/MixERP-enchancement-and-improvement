// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.tax_rate_type_selector_view")]
    [ExplicitColumns]
    public sealed class TaxRateTypeSelectorView : PetaPocoDB.Record<TaxRateTypeSelectorView>, IPoco
    {
        [Column("tax_rate_type_code")]
        [ColumnDbType("varchar", 4, true, "")]
        public string TaxRateTypeCode { get; set; }

        [Column("tax_rate_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string TaxRateTypeName { get; set; }
    }
}