// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetRecurringAmountByRecurringInvoiceIdRepository : IGetRecurringAmountByRecurringInvoiceIdRepository
    {
        public int RecurringInvoiceId { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}