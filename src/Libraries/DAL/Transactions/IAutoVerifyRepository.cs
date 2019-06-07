// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IAutoVerifyRepository
    {

        long TranId { get; set; }
        int OfficeId { get; set; }

        /// <summary>
        /// Prepares and executes IAutoVerifyRepository.
        /// </summary>
        void Execute();
    }
}