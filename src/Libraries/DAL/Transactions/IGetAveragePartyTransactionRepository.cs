// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetAveragePartyTransactionRepository
    {

        long PartyId { get; set; }
        int OfficeId { get; set; }

        /// <summary>
        /// Prepares and executes IGetAveragePartyTransactionRepository.
        /// </summary>
        decimal Execute();
    }
}