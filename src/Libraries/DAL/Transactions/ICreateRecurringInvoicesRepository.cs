// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface ICreateRecurringInvoicesRepository
    {

        long PgArg0 { get; set; }

        /// <summary>
        /// Prepares and executes ICreateRecurringInvoicesRepository.
        /// </summary>
        void Execute();
    }
}