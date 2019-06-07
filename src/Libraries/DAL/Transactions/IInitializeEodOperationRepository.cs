// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IInitializeEodOperationRepository
    {

        int UserId { get; set; }
        int OfficeId { get; set; }
        DateTime ValueDate { get; set; }

        /// <summary>
        /// Prepares and executes IInitializeEodOperationRepository.
        /// </summary>
        void Execute();
    }
}