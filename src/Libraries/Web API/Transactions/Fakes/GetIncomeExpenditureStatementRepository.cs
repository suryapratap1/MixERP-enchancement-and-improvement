// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetIncomeExpenditureStatementRepository : IGetIncomeExpenditureStatementRepository
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public bool Compact { get; set; }

        public IEnumerable<DbGetIncomeExpenditureStatementResult> Execute()
        {
            return new List<DbGetIncomeExpenditureStatementResult>();
        }
    }
}