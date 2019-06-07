// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetVerificationStatusRepository : IGetVerificationStatusRepository
    {
        public long TranId { get; set; }

        public short Execute()
        {
            return 1;
        }
    }
}