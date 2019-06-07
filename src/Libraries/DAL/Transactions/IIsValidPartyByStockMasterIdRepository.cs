// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IIsValidPartyByStockMasterIdRepository
    {

        long StockMasterId { get; set; }
        long PartyId { get; set; }

        /// <summary>
        /// Prepares and executes IIsValidPartyByStockMasterIdRepository.
        /// </summary>
        bool Execute();
    }
}