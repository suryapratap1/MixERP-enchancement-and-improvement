// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("store_id", autoIncrement = true)]
    [TableName("office.stores")]
    [ExplicitColumns]
    public sealed class Store : PetaPocoDB.Record<Store>, IPoco
    {
        [Column("store_id")]
        [ColumnDbType("int4", 0, false, "nextval('office.stores_store_id_seq'::regclass)")]
        public int StoreId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("store_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string StoreCode { get; set; }

        [Column("store_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string StoreName { get; set; }

        [Column("address")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Address { get; set; }

        [Column("store_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int StoreTypeId { get; set; }

        [Column("allow_sales")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool AllowSales { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SalesTaxId { get; set; }

        [Column("default_cash_account_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long DefaultCashAccountId { get; set; }

        [Column("default_cash_repository_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int DefaultCashRepositoryId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}