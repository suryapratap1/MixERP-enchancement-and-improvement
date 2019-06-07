// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IArePurchaseOrdersAlreadyMergedRepository
    {

        long[] Arr { get; set; }

        /// <summary>
        /// Prepares and executes IArePurchaseOrdersAlreadyMergedRepository.
        /// </summary>
        bool Execute();
    }
}