// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetJournalViewRepository : IGetJournalViewRepository
    {
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public long TranId { get; set; }
        public string TranCode { get; set; }
        public string Book { get; set; }
        public string ReferenceNumber { get; set; }
        public string StatementReference { get; set; }
        public string PostedBy { get; set; }
        public string Office { get; set; }
        public string Status { get; set; }
        public string VerifiedBy { get; set; }
        public string Reason { get; set; }

        public IEnumerable<DbGetJournalViewResult> Execute()
        {
            return new List<DbGetJournalViewResult>();
        }
    }
}