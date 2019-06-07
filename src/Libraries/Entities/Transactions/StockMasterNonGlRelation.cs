// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("stock_master_non_gl_relation_id", autoIncrement = true)]
    [TableName("transactions.stock_master_non_gl_relations")]
    [ExplicitColumns]
    public sealed class StockMasterNonGlRelation : PetaPocoDB.Record<StockMasterNonGlRelation>, IPoco
    {
        [Column("stock_master_non_gl_relation_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.stock_master_non_gl_relations_stock_master_non_gl_relation__seq'::regclass)")]
        public long StockMasterNonGlRelationId { get; set; }

        [Column("stock_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long StockMasterId { get; set; }

        [Column("non_gl_stock_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long NonGlStockMasterId { get; set; }
    }
}