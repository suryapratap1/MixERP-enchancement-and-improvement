// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("transaction_type_id", autoIncrement = false)]
    [TableName("core.transaction_types")]
    [ExplicitColumns]
    public sealed class TransactionType : PetaPocoDB.Record<TransactionType>, IPoco
    {
        [Column("transaction_type_id")]
        [ColumnDbType("int2", 0, false, "")]
        public short TransactionTypeId { get; set; }

        [Column("transaction_type_code")]
        [ColumnDbType("varchar", 4, true, "")]
        public string TransactionTypeCode { get; set; }

        [Column("transaction_type_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string TransactionTypeName { get; set; }
    }
}