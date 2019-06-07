// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IIsNormallyDebitRepository
    {

        long AccountId { get; set; }

        /// <summary>
        /// Prepares and executes IIsNormallyDebitRepository.
        /// </summary>
        bool Execute();
    }
}