// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetTrialBalanceRepository : IGetTrialBalanceRepository
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public bool Compact { get; set; }
        public decimal Factor { get; set; }
        public bool ChangeSideWhenNegative { get; set; }
        public bool IncludeZeroBalanceAccounts { get; set; }

        public IEnumerable<DbGetTrialBalanceResult> Execute()
        {
            return new List<DbGetTrialBalanceResult>();
        }
    }
}