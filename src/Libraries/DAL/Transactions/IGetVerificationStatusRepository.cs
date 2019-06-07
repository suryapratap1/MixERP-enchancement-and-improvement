// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetVerificationStatusRepository
    {

        long TranId { get; set; }

        /// <summary>
        /// Prepares and executes IGetVerificationStatusRepository.
        /// </summary>
        short Execute();
    }
}