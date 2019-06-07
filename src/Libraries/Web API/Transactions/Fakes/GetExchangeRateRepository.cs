// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetExchangeRateRepository : IGetExchangeRateRepository
    {
        public int OfficeId { get; set; }
        public string SourceCurrencyCode { get; set; }
        public string DestinationCurrencyCode { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}