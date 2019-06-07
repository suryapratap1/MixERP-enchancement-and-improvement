// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetAccountIdsRepository : IGetAccountIdsRepository
    {
        public long RootAccountId { get; set; }

        public IEnumerable<long> Execute()
        {
            return new List<long>();
        }
    }
}