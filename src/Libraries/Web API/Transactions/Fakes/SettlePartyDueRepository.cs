// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class SettlePartyDueRepository : ISettlePartyDueRepository
    {
        public long PartyId { get; set; }
        public int OfficeId { get; set; }

        public void Execute()
        {
            return;
        }
    }
}