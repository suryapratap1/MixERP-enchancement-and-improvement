// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetItemCostPriceRepository : IGetItemCostPriceRepository
    {
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public long PartyId { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}