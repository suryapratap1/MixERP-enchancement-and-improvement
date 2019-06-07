// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetSalesTaxRepository
    {

        string TranBook { get; set; }
        int StoreId { get; set; }
        string PartyCode { get; set; }
        string ShippingAddressCode { get; set; }
        int PriceTypeId { get; set; }
        string ItemCode { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }
        decimal Discount { get; set; }
        decimal ShippingCharge { get; set; }
        int SalesTaxId { get; set; }

        /// <summary>
        /// Prepares and executes IGetSalesTaxRepository.
        /// </summary>
        IEnumerable<DbGetSalesTaxResult> Execute();
    }
}