// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetCostOfGoodsSoldRepository
    {

        int ItemId { get; set; }
        int UnitId { get; set; }
        int StoreId { get; set; }
        int Quantity { get; set; }

        /// <summary>
        /// Prepares and executes IGetCostOfGoodsSoldRepository.
        /// </summary>
        decimal Execute();
    }
}