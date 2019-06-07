// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICountPurchasesRepository
    {

        int ItemId { get; set; }
        int UnitId { get; set; }
        int StoreId { get; set; }

        /// <summary>
        /// Prepares and executes ICountPurchasesRepository.
        /// </summary>
        decimal Execute();
    }
}