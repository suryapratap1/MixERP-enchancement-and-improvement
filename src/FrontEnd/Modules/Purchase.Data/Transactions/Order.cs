using System;
using System.Collections.ObjectModel;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions.Models;

namespace MixERP.Net.Core.Modules.Purchase.Data.Transactions
{
    public static class Order
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, string book, DateTime valueDate,
            string partyCode, int priceTypeId, Collection<StockDetail> details, string referenceNumber,
            string statementReference, Collection<long> transactionIdCollection, Collection<Attachment> attachments)
        {
            StockMaster stockMaster = new StockMaster();

            stockMaster.PartyCode = partyCode;
            stockMaster.PriceTypeId = priceTypeId;

            long nonGlStockMasterId = NonGlStockTransaction.Add(catalog, book, valueDate, officeId, userId, loginId,
                referenceNumber, statementReference, stockMaster, details, transactionIdCollection, attachments);
            return nonGlStockMasterId;
        }
    }
}