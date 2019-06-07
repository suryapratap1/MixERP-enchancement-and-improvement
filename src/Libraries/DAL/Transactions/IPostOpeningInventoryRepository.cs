// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IPostOpeningInventoryRepository
    {

        int OfficeId { get; set; }
        int UserId { get; set; }
        long LoginId { get; set; }
        DateTime ValueDate { get; set; }
        string ReferenceNumber { get; set; }
        string StatementReference { get; set; }
        MixERP.Net.Entities.Transactions.OpeningStockType[] Details { get; set; }

        /// <summary>
        /// Prepares and executes IPostOpeningInventoryRepository.
        /// </summary>
        long Execute();
    }
}