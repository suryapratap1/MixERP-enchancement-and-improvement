// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class IsValidPartyByStockMasterIdRepository : IIsValidPartyByStockMasterIdRepository
    {
        public long StockMasterId { get; set; }
        public long PartyId { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}