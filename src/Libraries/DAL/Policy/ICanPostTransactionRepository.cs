// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Policy;
namespace MixERP.Net.Schemas.Policy.Data
{
    public interface ICanPostTransactionRepository
    {

        long LoginId { get; set; }
        int UserId { get; set; }
        int OfficeId { get; set; }
        string TransactionBook { get; set; }
        DateTime ValueDate { get; set; }

        /// <summary>
        /// Prepares and executes ICanPostTransactionRepository.
        /// </summary>
        bool Execute();
    }
}