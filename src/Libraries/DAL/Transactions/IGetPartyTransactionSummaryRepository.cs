// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetPartyTransactionSummaryRepository
    {

        int OfficeId { get; set; }
        long PartyId { get; set; }

        /// <summary>
        /// Prepares and executes IGetPartyTransactionSummaryRepository.
        /// </summary>
        IEnumerable<DbGetPartyTransactionSummaryResult> Execute();
    }
}