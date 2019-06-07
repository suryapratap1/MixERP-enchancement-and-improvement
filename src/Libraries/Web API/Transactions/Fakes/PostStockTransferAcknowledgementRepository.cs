// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class PostStockTransferAcknowledgementRepository : IPostStockTransferAcknowledgementRepository
    {
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public long LoginId { get; set; }
        public long RequestId { get; set; }

        public long Execute()
        {
            return 1;
        }
    }
}