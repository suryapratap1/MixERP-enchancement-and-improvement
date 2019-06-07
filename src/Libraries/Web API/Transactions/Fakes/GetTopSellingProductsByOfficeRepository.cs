// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetTopSellingProductsByOfficeRepository : IGetTopSellingProductsByOfficeRepository
    {
        public int OfficeId { get; set; }
        public int Top { get; set; }

        public IEnumerable<DbGetTopSellingProductsByOfficeResult> Execute()
        {
            return new List<DbGetTopSellingProductsByOfficeResult>();
        }
    }
}