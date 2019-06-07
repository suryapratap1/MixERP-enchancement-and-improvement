// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetTrialBalanceRepository
    {

        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }
        int UserId { get; set; }
        int OfficeId { get; set; }
        bool Compact { get; set; }
        decimal Factor { get; set; }
        bool ChangeSideWhenNegative { get; set; }
        bool IncludeZeroBalanceAccounts { get; set; }

        /// <summary>
        /// Prepares and executes IGetTrialBalanceRepository.
        /// </summary>
        IEnumerable<DbGetTrialBalanceResult> Execute();
    }
}