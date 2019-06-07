// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetBalanceSheetRepository : IGetBalanceSheetRepository
    {
        public DateTime PreviousPeriod { get; set; }
        public DateTime CurrentPeriod { get; set; }
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public int Factor { get; set; }

        public IEnumerable<DbGetBalanceSheetResult> Execute()
        {
            return new List<DbGetBalanceSheetResult>();
        }
    }
}