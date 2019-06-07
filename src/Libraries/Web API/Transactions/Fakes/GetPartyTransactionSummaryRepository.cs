// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetPartyTransactionSummaryRepository : IGetPartyTransactionSummaryRepository
    {
        public int OfficeId { get; set; }
        public long PartyId { get; set; }

        public IEnumerable<DbGetPartyTransactionSummaryResult> Execute()
        {
            return new List<DbGetPartyTransactionSummaryResult>();
        }
    }
}