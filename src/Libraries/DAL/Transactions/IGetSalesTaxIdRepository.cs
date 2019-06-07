// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetSalesTaxIdRepository
    {

        string TranBook { get; set; }
        int StoreId { get; set; }
        string PartyCode { get; set; }
        string ShippingAddressCode { get; set; }
        int PriceTypeId { get; set; }
        string ItemCode { get; set; }
        int UnitId { get; set; }
        decimal Price { get; set; }

        /// <summary>
        /// Prepares and executes IGetSalesTaxIdRepository.
        /// </summary>
        int Execute();
    }
}