// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class PostSalesRepository : IPostSalesRepository
    {
        public string BookName { get; set; }
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public long LoginId { get; set; }
        public DateTime ValueDate { get; set; }
        public int CostCenterId { get; set; }
        public string ReferenceNumber { get; set; }
        public string StatementReference { get; set; }
        public bool IsCredit { get; set; }
        public int PaymentTermId { get; set; }
        public string PartyCode { get; set; }
        public int PriceTypeId { get; set; }
        public int SalespersonId { get; set; }
        public int ShipperId { get; set; }
        public string ShippingAddressCode { get; set; }
        public int StoreId { get; set; }
        public bool IsNonTaxableSales { get; set; }
        public MixERP.Net.Entities.Transactions.StockDetailType[] Details { get; set; }
        public MixERP.Net.Entities.Core.AttachmentType[] Attachments { get; set; }
        public long[] NonGlTranIds { get; set; }

        public long Execute()
        {
            return 1;
        }
    }
}