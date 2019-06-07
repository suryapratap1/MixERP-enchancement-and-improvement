// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetTopSellingProductsOfAllTimeRepository
    {

        int Top { get; set; }

        /// <summary>
        /// Prepares and executes IGetTopSellingProductsOfAllTimeRepository.
        /// </summary>
        IEnumerable<DbGetTopSellingProductsOfAllTimeResult> Execute();
    }
}