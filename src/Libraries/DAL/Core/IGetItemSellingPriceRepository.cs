// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetItemSellingPriceRepository
    {

        int ItemId { get; set; }
        int PartyTypeId { get; set; }
        int PriceTypeId { get; set; }
        int UnitId { get; set; }

        /// <summary>
        /// Prepares and executes IGetItemSellingPriceRepository.
        /// </summary>
        decimal Execute();
    }
}