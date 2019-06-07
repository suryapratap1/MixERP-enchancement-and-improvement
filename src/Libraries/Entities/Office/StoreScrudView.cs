// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.store_scrud_view")]
    [ExplicitColumns]
    public sealed class StoreScrudView : PetaPocoDB.Record<StoreScrudView>, IPoco
    {
        [Column("store_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StoreId { get; set; }

        [Column("office")]
        [ColumnDbType("text", 0, true, "")]
        public string Office { get; set; }

        [Column("store_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string StoreCode { get; set; }

        [Column("store_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string StoreName { get; set; }

        [Column("address")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Address { get; set; }

        [Column("store_type")]
        [ColumnDbType("text", 0, true, "")]
        public string StoreType { get; set; }

        [Column("allow_sales")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? AllowSales { get; set; }

        [Column("sales_tax")]
        [ColumnDbType("text", 0, true, "")]
        public string SalesTax { get; set; }

        [Column("default_cash_account")]
        [ColumnDbType("text", 0, true, "")]
        public string DefaultCashAccount { get; set; }

        [Column("default_cash_repository")]
        [ColumnDbType("text", 0, true, "")]
        public string DefaultCashRepository { get; set; }
    }
}