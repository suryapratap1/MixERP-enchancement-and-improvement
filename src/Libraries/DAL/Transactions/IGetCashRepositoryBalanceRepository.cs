// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetCashRepositoryBalanceRepository
    {

        int CashRepositoryId { get; set; }
        string CurrencyCode { get; set; }

        /// <summary>
        /// Prepares and executes IGetCashRepositoryBalanceRepository.
        /// </summary>
        decimal Execute();
    }
}