// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class PostInventoryTransferDeliveryRepository : IPostInventoryTransferDeliveryRepository
    {
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public long LoginId { get; set; }
        public long InventoryTransferRequestId { get; set; }
        public DateTime ValueDate { get; set; }
        public string ReferenceNumber { get; set; }
        public string StatementReference { get; set; }
        public int ShipperId { get; set; }
        public int SourceStoreId { get; set; }
        public MixERP.Net.Entities.Transactions.StockAdjustmentType[] Details { get; set; }

        public long Execute()
        {
            return 1;
        }
    }
}