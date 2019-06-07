// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetMergeModelRepository
    {

        long[] TranIds { get; set; }
        string Book { get; set; }

        /// <summary>
        /// Prepares and executes IGetMergeModelRepository.
        /// </summary>
        IEnumerable<DbGetMergeModelResult> Execute();
    }
}