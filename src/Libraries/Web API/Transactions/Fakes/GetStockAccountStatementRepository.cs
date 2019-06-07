// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetStockAccountStatementRepository : IGetStockAccountStatementRepository
    {
        public DateTime ValueDateFrom { get; set; }
        public DateTime ValueDateTo { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public int StoreId { get; set; }

        public IEnumerable<DbGetStockAccountStatementResult> Execute()
        {
            return new List<DbGetStockAccountStatementResult>();
        }
    }
}