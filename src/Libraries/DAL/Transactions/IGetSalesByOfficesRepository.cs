// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetSalesByOfficesRepository
    {

        int OfficeId { get; set; }
        int DivideBy { get; set; }

        /// <summary>
        /// Prepares and executes IGetSalesByOfficesRepository.
        /// </summary>
        IEnumerable<DbGetSalesByOfficesResult> Execute();
    }
}