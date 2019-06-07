// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetExchangeRateRepository
    {

        int OfficeId { get; set; }
        string SourceCurrencyCode { get; set; }
        string DestinationCurrencyCode { get; set; }

        /// <summary>
        /// Prepares and executes IGetExchangeRateRepository.
        /// </summary>
        decimal Execute();
    }
}