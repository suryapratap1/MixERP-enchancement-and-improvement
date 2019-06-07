// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class PerformEodOperationRepository : IPerformEodOperationRepository
    {
        public int UserId { get; set; }
        public long LoginId { get; set; }
        public int OfficeId { get; set; }
        public DateTime ValueDate { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}