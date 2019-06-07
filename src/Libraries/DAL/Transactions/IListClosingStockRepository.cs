// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IListClosingStockRepository
    {

        int StoreId { get; set; }

        /// <summary>
        /// Prepares and executes IListClosingStockRepository.
        /// </summary>
        IEnumerable<DbListClosingStockResult> Execute();
    }
}