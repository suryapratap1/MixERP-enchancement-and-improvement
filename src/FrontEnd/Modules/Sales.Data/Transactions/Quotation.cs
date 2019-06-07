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
    public static class Quotation
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, DateTime valueDate,
            string partyCode, int priceTypeId, Collection<StockDetail> details, string referenceNumber,
            string statementReference, Collection<long> transactionIdCollection, Collection<Attachment> attachments,
            bool nonTaxable, int salesPersonId, int shipperId, string shippingAddressCode, int storeId)
        {
            StockMaster stockMaster = new StockMaster();

            stockMaster.PartyCode = partyCode;
            stockMaster.PriceTypeId = priceTypeId;
            stockMaster.SalespersonId = salesPersonId;
            stockMaster.ShipperId = shipperId;
            stockMaster.ShippingAddressCode = shippingAddressCode;
            stockMaster.StoreId = storeId;

            long nonGlStockMasterId = NonGlStockTransaction.Add(catalog, "Sales.Quotation", valueDate, officeId, userId,
                loginId, referenceNumber, statementReference, stockMaster, details, transactionIdCollection, attachments,
                nonTaxable);
            return nonGlStockMasterId;
        }

        public static string AddValidation(string catalog, int validDuration, long tranId)
        {
            string validationId = Guid.NewGuid().ToString();
            const string sql =
                "INSERT INTO public.sales_quotation_validation(tran_id, catalog, validation_id, valid_till) SELECT @0::bigint, @1::text, @2::text, NOW() + INTERVAL '1 DAY' * @3;";

            Factory.NonQuery(Factory.MetaDatabase, sql, tranId, catalog, validationId, validDuration);

            return validationId;
        }

        public static SalesQuotationView GetSalesQuotationView(string catalog, long tranId)
        {
            const string sql = "SELECT * FROM transactions.sales_quotation_view WHERE tran_id = @0;";
            return Factory.Get<SalesQuotationView>(catalog, sql, tranId).FirstOrDefault();
        }
    }
}