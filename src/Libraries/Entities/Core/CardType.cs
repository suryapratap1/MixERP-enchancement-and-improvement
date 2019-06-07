// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("card_type_id", autoIncrement = false)]
    [TableName("core.card_types")]
    [ExplicitColumns]
    public sealed class CardType : PetaPocoDB.Record<CardType>, IPoco
    {
        [Column("card_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CardTypeId { get; set; }

        [Column("card_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CardTypeCode { get; set; }

        [Column("card_type_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string CardTypeName { get; set; }
    }
}