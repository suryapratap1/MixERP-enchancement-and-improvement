// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class AutoVerifyRepository : IAutoVerifyRepository
    {
        public long TranId { get; set; }
        public int OfficeId { get; set; }

        public void Execute()
        {
            return;
        }
    }
}