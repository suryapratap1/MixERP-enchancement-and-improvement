// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.salesperson_selector_view")]
    [ExplicitColumns]
    public sealed class SalespersonSelectorView : PetaPocoDB.Record<SalespersonSelectorView>, IPoco
    {
        [Column("salesperson_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalespersonId { get; set; }

        [Column("salesperson_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string SalespersonCode { get; set; }

        [Column("salesperson_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string SalespersonName { get; set; }

        [Column("address")]
        [ColumnDbType("varchar", 100, true, "")]
        public string Address { get; set; }

        [Column("contact_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ContactNumber { get; set; }

        [Column("commission_rate")]
        [ColumnDbType("decimal_strict2", 0, true, "")]
        public decimal? CommissionRate { get; set; }

        [Column("account_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string AccountName { get; set; }
    }
}