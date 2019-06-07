// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetValueDateRepository : IGetValueDateRepository
    {
        public int OfficeId { get; set; }

        public DateTime Execute()
        {
            return new DateTime();
        }
    }
}