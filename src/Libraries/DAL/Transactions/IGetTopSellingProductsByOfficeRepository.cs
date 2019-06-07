// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetTopSellingProductsByOfficeRepository
    {

        int OfficeId { get; set; }
        int Top { get; set; }

        /// <summary>
        /// Prepares and executes IGetTopSellingProductsByOfficeRepository.
        /// </summary>
        IEnumerable<DbGetTopSellingProductsByOfficeResult> Execute();
    }
}