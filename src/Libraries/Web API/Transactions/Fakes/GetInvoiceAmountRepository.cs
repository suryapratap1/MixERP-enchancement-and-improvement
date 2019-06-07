// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class GetInvoiceAmountRepository : IGetInvoiceAmountRepository
    {
        public long TransactionMasterId { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}