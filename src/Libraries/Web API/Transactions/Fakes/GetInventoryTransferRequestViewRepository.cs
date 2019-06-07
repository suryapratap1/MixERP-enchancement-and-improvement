// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetInventoryTransferRequestViewRepository : IGetInventoryTransferRequestViewRepository
    {
        public int UserId { get; set; }
        public long LoginId { get; set; }
        public int OfficeId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Office { get; set; }
        public string Store { get; set; }
        public string Authorized { get; set; }
        public string Delivered { get; set; }
        public string Received { get; set; }
        public string User { get; set; }
        public string ReferenceNumber { get; set; }
        public string StatementReference { get; set; }

        public IEnumerable<DbGetInventoryTransferRequestViewResult> Execute()
        {
            return new List<DbGetInventoryTransferRequestViewResult>();
        }
    }
}