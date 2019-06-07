// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetBalanceSheetRepository
    {

        DateTime PreviousPeriod { get; set; }
        DateTime CurrentPeriod { get; set; }
        int UserId { get; set; }
        int OfficeId { get; set; }
        int Factor { get; set; }

        /// <summary>
        /// Prepares and executes IGetBalanceSheetRepository.
        /// </summary>
        IEnumerable<DbGetBalanceSheetResult> Execute();
    }
}