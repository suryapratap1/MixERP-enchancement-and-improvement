// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class CreateRoutineRepository : ICreateRoutineRepository
    {
        public string RoutineCode { get; set; }
        public string Routine { get; set; }
        public int Order { get; set; }

        public void Execute()
        {
            return;
        }
    }
}