// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetAccountStatementRepository
    {

        DateTime ValueDateFrom { get; set; }
        DateTime ValueDateTo { get; set; }
        int UserId { get; set; }
        long AccountId { get; set; }
        int OfficeId { get; set; }

        /// <summary>
        /// Prepares and executes IGetAccountStatementRepository.
        /// </summary>
        IEnumerable<DbGetAccountStatementResult> Execute();
    }
}