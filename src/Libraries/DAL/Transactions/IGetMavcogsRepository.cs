// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetMavcogsRepository
    {

        int ItemId { get; set; }
        int StoreId { get; set; }
        decimal BaseQuantity { get; set; }
        decimal Factor { get; set; }

        /// <summary>
        /// Prepares and executes IGetMavcogsRepository.
        /// </summary>
        decimal Execute();
    }
}