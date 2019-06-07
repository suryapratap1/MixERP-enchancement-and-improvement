// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetNewTransactionCounterRepository : IGetNewTransactionCounterRepository
    {
        public DateTime PgArg0 { get; set; }

        public int Execute()
        {
            return 1;
        }
    }
}