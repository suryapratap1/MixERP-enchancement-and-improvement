// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IAreSalesOrdersAlreadyMergedRepository
    {

        long[] Arr { get; set; }

        /// <summary>
        /// Prepares and executes IAreSalesOrdersAlreadyMergedRepository.
        /// </summary>
        bool Execute();
    }
}