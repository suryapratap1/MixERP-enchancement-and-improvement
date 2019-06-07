// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetCompoundItemDetailsRepository : IGetCompoundItemDetailsRepository
    {
        public string CompoundItemCode { get; set; }
        public string SalesTaxCode { get; set; }
        public string TranBook { get; set; }
        public int StoreId { get; set; }
        public string PartyCode { get; set; }
        public int PriceTypeId { get; set; }

        public IEnumerable<DbGetCompoundItemDetailsResult> Execute()
        {
            return new List<DbGetCompoundItemDetailsResult>();
        }
    }
}