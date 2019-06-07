// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetStockMasterIdByTransactionMasterIdRepository : IGetStockMasterIdByTransactionMasterIdRepository
    {
        public long StockMasterId { get; set; }

        public long Execute()
        {
            return 1;
        }
    }
}