// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetTransactionMasterIdByStockMasterIdRepository
    {

        long StockMasterId { get; set; }

        /// <summary>
        /// Prepares and executes IGetTransactionMasterIdByStockMasterIdRepository.
        /// </summary>
        long Execute();
    }
}