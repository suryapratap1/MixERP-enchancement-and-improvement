// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetCashRepositoryIdByStoreIdRepository
    {

        int StoreId { get; set; }

        /// <summary>
        /// Prepares and executes IGetCashRepositoryIdByStoreIdRepository.
        /// </summary>
        long Execute();
    }
}