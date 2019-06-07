// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetRetainedEarningsStatementRepository
    {

        DateTime DateTo { get; set; }
        int OfficeId { get; set; }
        int Factor { get; set; }

        /// <summary>
        /// Prepares and executes IGetRetainedEarningsStatementRepository.
        /// </summary>
        IEnumerable<DbGetRetainedEarningsStatementResult> Execute();
    }
}