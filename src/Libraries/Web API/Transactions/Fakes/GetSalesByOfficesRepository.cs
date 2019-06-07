// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetSalesByOfficesRepository : IGetSalesByOfficesRepository
    {
        public int OfficeId { get; set; }
        public int DivideBy { get; set; }

        public IEnumerable<DbGetSalesByOfficesResult> Execute()
        {
            return new List<DbGetSalesByOfficesResult>();
        }
    }
}