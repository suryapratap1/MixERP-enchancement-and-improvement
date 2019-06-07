// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.store_view")]
    [ExplicitColumns]
    public sealed class StoreView : PetaPocoDB.Record<StoreView>, IPoco
    {
        [Column("store_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StoreId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? OfficeId { get; set; }

        [Column("store_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string StoreCode { get; set; }

        [Column("store_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string StoreName { get; set; }

        [Column("address")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Address { get; set; }

        [Column("store_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StoreTypeId { get; set; }

        [Column("allow_sales")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? AllowSales { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalesTaxId { get; set; }

        [Column("default_cash_account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? DefaultCashAccountId { get; set; }

        [Column("default_cash_repository_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? DefaultCashRepositoryId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}