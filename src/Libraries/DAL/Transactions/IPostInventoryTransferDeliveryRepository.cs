// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IPostInventoryTransferDeliveryRepository
    {

        int OfficeId { get; set; }
        int UserId { get; set; }
        long LoginId { get; set; }
        long InventoryTransferRequestId { get; set; }
        DateTime ValueDate { get; set; }
        string ReferenceNumber { get; set; }
        string StatementReference { get; set; }
        int ShipperId { get; set; }
        int SourceStoreId { get; set; }
        MixERP.Net.Entities.Transactions.StockAdjustmentType[] Details { get; set; }

        /// <summary>
        /// Prepares and executes IPostInventoryTransferDeliveryRepository.
        /// </summary>
        long Execute();
    }
}