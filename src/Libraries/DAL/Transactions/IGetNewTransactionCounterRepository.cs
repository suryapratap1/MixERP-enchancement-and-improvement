// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetNewTransactionCounterRepository
    {

        DateTime PgArg0 { get; set; }

        /// <summary>
        /// Prepares and executes IGetNewTransactionCounterRepository.
        /// </summary>
        int Execute();
    }
}