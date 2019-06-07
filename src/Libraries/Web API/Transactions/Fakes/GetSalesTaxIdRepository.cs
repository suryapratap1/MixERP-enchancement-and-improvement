// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetSalesTaxIdRepository : IGetSalesTaxIdRepository
    {
        public string TranBook { get; set; }
        public int StoreId { get; set; }
        public string PartyCode { get; set; }
        public string ShippingAddressCode { get; set; }
        public int PriceTypeId { get; set; }
        public string ItemCode { get; set; }
        public int UnitId { get; set; }
        public decimal Price { get; set; }

        public int Execute()
        {
            return 1;
        }
    }
}