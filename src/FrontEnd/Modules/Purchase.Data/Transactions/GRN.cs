using System;
using System.Collections.ObjectModel;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions.Models;

namespace MixERP.Net.Core.Modules.Purchase.Data.Transactions
{
    public static class GRN
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, DateTime valueDate, int storeId,
            string partyCode, Collection<StockDetail> details, int costCenterId, string referenceNumber,
            string statementReference, Collection<long> transactionIdCollection, Collection<Attachment> attachments)
        {
            StockMaster stockMaster = new StockMaster();

            stockMaster.PartyCode = partyCode;
            stockMaster.StoreId = storeId;
            stockMaster.IsCredit = true;

            if (!string.IsNullOrWhiteSpace(statementReference))
            {
                statementReference = statementReference.Replace("&nbsp;", " ").Trim();
            }

            long transactionMasterId = GlTransaction.Add(catalog, valueDate, "Purchase.Receipt", officeId, userId,
                loginId, costCenterId, referenceNumber, statementReference, stockMaster, details,
                transactionIdCollection, attachments);
            return transactionMasterId;
        }
    }
}