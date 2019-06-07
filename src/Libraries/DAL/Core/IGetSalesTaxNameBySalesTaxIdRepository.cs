// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetSalesTaxNameBySalesTaxIdRepository
    {

        int SalesTaxId { get; set; }

        /// <summary>
        /// Prepares and executes IGetSalesTaxNameBySalesTaxIdRepository.
        /// </summary>
        string Execute();
    }
}