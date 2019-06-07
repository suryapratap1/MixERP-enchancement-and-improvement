// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetCompoundItemDetailsRepository
    {

        string CompoundItemCode { get; set; }
        string SalesTaxCode { get; set; }
        string TranBook { get; set; }
        int StoreId { get; set; }
        string PartyCode { get; set; }
        int PriceTypeId { get; set; }

        /// <summary>
        /// Prepares and executes IGetCompoundItemDetailsRepository.
        /// </summary>
        IEnumerable<DbGetCompoundItemDetailsResult> Execute();
    }
}