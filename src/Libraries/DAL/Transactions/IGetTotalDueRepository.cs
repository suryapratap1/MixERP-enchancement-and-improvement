// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetTotalDueRepository
    {

        int OfficeId { get; set; }
        long PartyId { get; set; }

        /// <summary>
        /// Prepares and executes IGetTotalDueRepository.
        /// </summary>
        decimal Execute();
    }
}