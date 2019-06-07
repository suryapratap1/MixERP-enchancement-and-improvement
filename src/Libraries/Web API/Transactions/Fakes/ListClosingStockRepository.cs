// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class ListClosingStockRepository : IListClosingStockRepository
    {
        public int StoreId { get; set; }

        public IEnumerable<DbListClosingStockResult> Execute()
        {
            return new List<DbListClosingStockResult>();
        }
    }
}