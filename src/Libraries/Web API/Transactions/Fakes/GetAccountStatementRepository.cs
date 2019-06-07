// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetAccountStatementRepository : IGetAccountStatementRepository
    {
        public DateTime ValueDateFrom { get; set; }
        public DateTime ValueDateTo { get; set; }
        public int UserId { get; set; }
        public long AccountId { get; set; }
        public int OfficeId { get; set; }

        public IEnumerable<DbGetAccountStatementResult> Execute()
        {
            return new List<DbGetAccountStatementResult>();
        }
    }
}