// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetIncomeTaxProvisonAmountRepository
    {

        int OfficeId { get; set; }
        decimal Profit { get; set; }
        decimal Balance { get; set; }

        /// <summary>
        /// Prepares and executes IGetIncomeTaxProvisonAmountRepository.
        /// </summary>
        decimal Execute();
    }
}