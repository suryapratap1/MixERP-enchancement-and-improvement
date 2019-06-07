// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IPerformEodOperationRepository
    {

        int UserId { get; set; }
        long LoginId { get; set; }
        int OfficeId { get; set; }
        DateTime ValueDate { get; set; }

        /// <summary>
        /// Prepares and executes IPerformEodOperationRepository.
        /// </summary>
        bool Execute();
    }
}