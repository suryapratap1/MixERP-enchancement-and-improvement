using System;
using System.Collections.ObjectModel;
using System.Linq;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions;
using PetaPoco;
using StockDetail = MixERP.Net.Entities.Transactions.Models.StockDetail;
using StockMaster = MixERP.Net.Entities.Transactions.Models.StockMaster;

namespace MixERP.Net.Core.Modules.Sales.Data.Transactions
{
    public static class Delivery
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, DateTime valueDate, int storeId,
            string partyCode, int priceTypeId, int paymentTermId, Collection<StockDetail> details, int shipperId,
            string shippingAddressCode, decimal shippingCharge, int costCenterId, string referenceNumber, int agentId,
            string statementReference, Collection<long> tranIds, Collection<Attachment> attachments, bool nonTaxable)
        {
            StockMaster stockMaster = new StockMaster();

            stockMaster.PartyCode = partyCode;
            stockMaster.IsCredit = true; //Credit
            stockMaster.PaymentTermId = paymentTermId;

            stockMaster.PriceTypeId = priceTypeId;
            stockMaster.ShipperId = shipperId;
            stockMaster.ShippingAddressCode = shippingAddressCode;
            stockMaster.ShippingCharge = shippingCharge;
            stockMaster.SalespersonId = agentId;
            stockMaster.StoreId = storeId;

            long transactionMasterId = GlTransaction.Add(catalog, "Sales.Delivery", valueDate, officeId, userId, loginId,
                costCenterId, referenceNumber, statementReference, stockMaster, details, attachments, nonTaxable,
                tranIds);

            return transactionMasterId;
        }

        public static SalesDeliveryView GetSalesDeliveryView(string catalog, long tranId)
        {
            const string sql = "SELECT * FROM transactions.sales_delivery_view WHERE tran_id = @0;";
            return Factory.Get<SalesDeliveryView>(catalog, sql, tranId).FirstOrDefault();
        }
    }
}