// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("non_gl_stock_master_relation_id", autoIncrement = true)]
    [TableName("transactions.non_gl_stock_master_relations")]
    [ExplicitColumns]
    public sealed class NonGlStockMasterRelation : PetaPocoDB.Record<NonGlStockMasterRelation>, IPoco
    {
        [Column("non_gl_stock_master_relation_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.non_gl_stock_master_relations_non_gl_stock_master_relation__seq'::regclass)")]
        public long NonGlStockMasterRelationId { get; set; }

        [Column("order_non_gl_stock_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long OrderNonGlStockMasterId { get; set; }

        [Column("quotation_non_gl_stock_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long QuotationNonGlStockMasterId { get; set; }
    }
}