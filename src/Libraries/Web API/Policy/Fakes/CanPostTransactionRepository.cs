// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Policy.Data;
using MixERP.Net.Entities.Policy;

namespace MixERP.Net.Api.Policy.Fakes
{
    public class CanPostTransactionRepository : ICanPostTransactionRepository
    {
        public long LoginId { get; set; }
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public string TransactionBook { get; set; }
        public DateTime ValueDate { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}