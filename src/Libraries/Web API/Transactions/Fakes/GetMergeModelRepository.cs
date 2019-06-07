// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetMergeModelRepository : IGetMergeModelRepository
    {
        public long[] TranIds { get; set; }
        public string Book { get; set; }

        public IEnumerable<DbGetMergeModelResult> Execute()
        {
            return new List<DbGetMergeModelResult>();
        }
    }
}