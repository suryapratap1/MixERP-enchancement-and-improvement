using System;
using System.Collections.ObjectModel;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions.Models;

namespace MixERP.Net.Core.Modules.Purchase.Data.Transactions
{
    public static class DirectPurchase
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, DateTime valueDate, int storeId,
            bool isCredit, string partyCode, Collection<StockDetail> details, int costCenterId, string referenceNumber,
            string statementReference, Collection<Attachment> attachments)
        {
            StockMaster stockMaster = new StockMaster();

            stockMaster.PartyCode = partyCode;
            stockMaster.StoreId = storeId;
            stockMaster.IsCredit = isCredit;

            if (!string.IsNullOrWhiteSpace(statementReference))
            {
                statementReference = statementReference.Replace("&nbsp;", " ").Trim();
            }

            long transactionMasterId = GlTransaction.Add(catalog, valueDate, "Purchase.Direct", officeId, userId,
                loginId, costCenterId, referenceNumber, statementReference, stockMaster, details, new Collection<long>(),
                attachments);
            return transactionMasterId;
        }
    }
}