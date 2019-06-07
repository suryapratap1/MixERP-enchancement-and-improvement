using System;
using System.Collections.ObjectModel;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions.Models;

namespace MixERP.Net.Core.Modules.Sales.Data.Transactions
{
    public static class DirectSales
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, DateTime valueDate, int storeId,
            bool isCredit, int paymentTermId, string partyCode, int agentId, int priceTypeId,
            Collection<StockDetail> details, int shipperId, string shippingAddressCode, decimal shippingCharge,
            int costCenterId, string referenceNumber, string statementReference, Collection<Attachment> attachments,
            bool nonTaxable, Collection<long> tranIds)
        {
            StockMaster stockMaster = new StockMaster();

            stockMaster.PartyCode = partyCode;
            stockMaster.IsCredit = isCredit;
            stockMaster.PaymentTermId = paymentTermId;
            stockMaster.PriceTypeId = priceTypeId;
            stockMaster.ShipperId = shipperId;
            stockMaster.ShippingAddressCode = shippingAddressCode;
            stockMaster.ShippingCharge = shippingCharge;
            stockMaster.SalespersonId = agentId;
            stockMaster.StoreId = storeId;

            long transactionMasterId = GlTransaction.Add(catalog, "Sales.Direct", valueDate, officeId, userId, loginId,
                costCenterId, referenceNumber, statementReference, stockMaster, details, attachments, nonTaxable, tranIds);

            return transactionMasterId;
        }
    }
}