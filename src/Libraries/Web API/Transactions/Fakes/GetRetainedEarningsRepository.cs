// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetRetainedEarningsRepository : IGetRetainedEarningsRepository
    {
        public DateTime DateTo { get; set; }
        public int OfficeId { get; set; }
        public int Factor { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}