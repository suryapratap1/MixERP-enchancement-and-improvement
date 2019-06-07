// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IValidateItemsForReturnRepository
    {

        long TransactionMasterId { get; set; }
        MixERP.Net.Entities.Transactions.StockDetailType[] Details { get; set; }

        /// <summary>
        /// Prepares and executes IValidateItemsForReturnRepository.
        /// </summary>
        bool Execute();
    }
}