// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetWriteOffCostOfGoodsSoldRepository : IGetWriteOffCostOfGoodsSoldRepository
    {
        public long StockMasterId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public int Quantity { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}