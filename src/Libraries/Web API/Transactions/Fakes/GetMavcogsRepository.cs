// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetMavcogsRepository : IGetMavcogsRepository
    {
        public int ItemId { get; set; }
        public int StoreId { get; set; }
        public decimal BaseQuantity { get; set; }
        public decimal Factor { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}