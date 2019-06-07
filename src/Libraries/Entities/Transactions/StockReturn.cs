// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("sales_return_id", autoIncrement = true)]
    [TableName("transactions.stock_return")]
    [ExplicitColumns]
    public sealed class StockReturn : PetaPocoDB.Record<StockReturn>, IPoco
    {
        [Column("sales_return_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.stock_return_sales_return_id_seq'::regclass)")]
        public long SalesReturnId { get; set; }

        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long TransactionMasterId { get; set; }

        [Column("return_transaction_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long ReturnTransactionMasterId { get; set; }
    }
}