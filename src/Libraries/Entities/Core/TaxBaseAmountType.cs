// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("tax_base_amount_type_code", autoIncrement = false)]
    [TableName("core.tax_base_amount_types")]
    [ExplicitColumns]
    public sealed class TaxBaseAmountType : PetaPocoDB.Record<TaxBaseAmountType>, IPoco
    {
        [Column("tax_base_amount_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string TaxBaseAmountTypeCode { get; set; }

        [Column("tax_base_amount_type_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string TaxBaseAmountTypeName { get; set; }
    }
}