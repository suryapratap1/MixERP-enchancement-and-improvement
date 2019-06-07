// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class CreatePaymentCardRepository : ICreatePaymentCardRepository
    {
        public string PaymentCardCode { get; set; }
        public string PaymentCardName { get; set; }
        public int CardTypeId { get; set; }

        public void Execute()
        {
            return;
        }
    }
}