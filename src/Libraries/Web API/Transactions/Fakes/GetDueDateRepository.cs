// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetDueDateRepository : IGetDueDateRepository
    {
        public DateTime ValueDate { get; set; }
        public int PaymentTermId { get; set; }

        public DateTime Execute()
        {
            return new DateTime();
        }
    }
}