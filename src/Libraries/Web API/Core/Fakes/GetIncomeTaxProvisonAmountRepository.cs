// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetIncomeTaxProvisonAmountRepository : IGetIncomeTaxProvisonAmountRepository
    {
        public int OfficeId { get; set; }
        public decimal Profit { get; set; }
        public decimal Balance { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}