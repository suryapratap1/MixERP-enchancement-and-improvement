// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class CountItemInStockRepository : ICountItemInStockRepository
    {
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public int OfficeId { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}