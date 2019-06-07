// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetReceiptViewRepository : IGetReceiptViewRepository
    {
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Office { get; set; }
        public string Party { get; set; }
        public string User { get; set; }
        public string ReferenceNumber { get; set; }
        public string StatementReference { get; set; }

        public IEnumerable<DbGetReceiptViewResult> Execute()
        {
            return new List<DbGetReceiptViewResult>();
        }
    }
}