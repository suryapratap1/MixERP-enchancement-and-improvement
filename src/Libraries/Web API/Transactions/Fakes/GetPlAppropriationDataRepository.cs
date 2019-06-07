// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetPlAppropriationDataRepository : IGetPlAppropriationDataRepository
    {
        public int OfficeId { get; set; }

        public IEnumerable<DbGetPlAppropriationDataResult> Execute()
        {
            return new List<DbGetPlAppropriationDataResult>();
        }
    }
}