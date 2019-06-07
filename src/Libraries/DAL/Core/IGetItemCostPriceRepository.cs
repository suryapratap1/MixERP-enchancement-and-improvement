// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetItemCostPriceRepository
    {

        int ItemId { get; set; }
        int UnitId { get; set; }
        long PartyId { get; set; }

        /// <summary>
        /// Prepares and executes IGetItemCostPriceRepository.
        /// </summary>
        decimal Execute();
    }
}