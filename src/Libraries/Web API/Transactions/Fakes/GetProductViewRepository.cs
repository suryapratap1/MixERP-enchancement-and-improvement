// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetProductViewRepository : IGetProductViewRepository
    {
        public int UserId { get; set; }
        public string Book { get; set; }
        public int OfficeId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Office { get; set; }
        public string Party { get; set; }
        public string PriceType { get; set; }
        public string User { get; set; }
        public string ReferenceNumber { get; set; }
        public string StatementReference { get; set; }

        public IEnumerable<DbGetProductViewResult> Execute()
        {
            return new List<DbGetProductViewResult>();
        }
    }
}