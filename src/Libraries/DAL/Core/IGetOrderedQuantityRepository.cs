// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetOrderedQuantityRepository
    {

        int ItemId { get; set; }
        int UnitId { get; set; }
        int OfficeId { get; set; }

        /// <summary>
        /// Prepares and executes IGetOrderedQuantityRepository.
        /// </summary>
        decimal Execute();
    }
}