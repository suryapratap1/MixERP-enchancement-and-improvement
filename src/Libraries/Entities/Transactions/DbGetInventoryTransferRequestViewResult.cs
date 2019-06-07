// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_inventory_transfer_request_view")]
    [ExplicitColumns]
    public sealed class DbGetInventoryTransferRequestViewResult : PetaPocoDB.Record<DbGetInventoryTransferRequestViewResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long Id { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("office")]
        [ColumnDbType("text", 0, false, "")]
        public string Office { get; set; }

        [Column("user_name")]
        [ColumnDbType("text", 0, false, "")]
        public string UserName { get; set; }

        [Column("store")]
        [ColumnDbType("text", 0, false, "")]
        public string Store { get; set; }

        [Column("reference_number")]
        [ColumnDbType("text", 0, false, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, false, "")]
        public string StatementReference { get; set; }

        [Column("authorized")]
        [ColumnDbType("text", 0, false, "")]
        public string Authorized { get; set; }

        [Column("delivered")]
        [ColumnDbType("text", 0, false, "")]
        public string Delivered { get; set; }

        [Column("received")]
        [ColumnDbType("text", 0, false, "")]
        public string Received { get; set; }

        [Column("flag_background_color")]
        [ColumnDbType("text", 0, false, "")]
        public string FlagBackgroundColor { get; set; }

        [Column("flag_foreground_color")]
        [ColumnDbType("text", 0, false, "")]
        public string FlagForegroundColor { get; set; }
    }
}