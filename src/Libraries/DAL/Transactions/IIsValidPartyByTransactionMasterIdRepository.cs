// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IIsValidPartyByTransactionMasterIdRepository
    {

        long TransactionMasterId { get; set; }
        long PartyId { get; set; }

        /// <summary>
        /// Prepares and executes IIsValidPartyByTransactionMasterIdRepository.
        /// </summary>
        bool Execute();
    }
}