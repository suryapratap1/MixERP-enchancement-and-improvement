// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("tax_rate_type_code", autoIncrement = false)]
    [TableName("core.tax_rate_types")]
    [ExplicitColumns]
    public sealed class TaxRateType : PetaPocoDB.Record<TaxRateType>, IPoco
    {
        [Column("tax_rate_type_code")]
        [ColumnDbType("varchar", 4, false, "")]
        public string TaxRateTypeCode { get; set; }

        [Column("tax_rate_type_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string TaxRateTypeName { get; set; }
    }
}