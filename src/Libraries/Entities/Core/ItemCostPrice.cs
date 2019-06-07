// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("item_cost_price_id", autoIncrement = true)]
    [TableName("core.item_cost_prices")]
    [ExplicitColumns]
    public sealed class ItemCostPrice : PetaPocoDB.Record<ItemCostPrice>, IPoco
    {
        [Column("item_cost_price_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.item_cost_prices_item_cost_price_id_seq'::regclass)")]
        public long ItemCostPriceId { get; set; }

        [Column("item_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ItemId { get; set; }

        [Column("entry_ts")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime EntryTs { get; set; }

        [Column("unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UnitId { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? PartyId { get; set; }

        [Column("lead_time_in_days")]
        [ColumnDbType("int4", 0, false, "0")]
        public int LeadTimeInDays { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Price { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}