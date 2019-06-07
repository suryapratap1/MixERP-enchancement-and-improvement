// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class CountSalesRepository : ICountSalesRepository
    {
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public int StoreId { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}