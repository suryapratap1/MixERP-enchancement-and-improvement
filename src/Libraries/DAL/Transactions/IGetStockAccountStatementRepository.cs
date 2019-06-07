// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetStockAccountStatementRepository
    {

        DateTime ValueDateFrom { get; set; }
        DateTime ValueDateTo { get; set; }
        int UserId { get; set; }
        int ItemId { get; set; }
        int StoreId { get; set; }

        /// <summary>
        /// Prepares and executes IGetStockAccountStatementRepository.
        /// </summary>
        IEnumerable<DbGetStockAccountStatementResult> Execute();
    }
}