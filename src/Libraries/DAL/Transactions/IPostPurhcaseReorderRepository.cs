// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IPostPurhcaseReorderRepository
    {

        DateTime ValueDate { get; set; }
        long LoginId { get; set; }
        int UserId { get; set; }
        int OfficeId { get; set; }
        MixERP.Net.Entities.Transactions.PurchaseReorderType[] Details { get; set; }

        /// <summary>
        /// Prepares and executes IPostPurhcaseReorderRepository.
        /// </summary>
        bool Execute();
    }
}