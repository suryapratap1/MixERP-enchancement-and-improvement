// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class IsValidPartyByTransactionMasterIdRepository : IIsValidPartyByTransactionMasterIdRepository
    {
        public long TransactionMasterId { get; set; }
        public long PartyId { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}