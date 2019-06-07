// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IPostStockTransferAcknowledgementRepository
    {

        int OfficeId { get; set; }
        int UserId { get; set; }
        long LoginId { get; set; }
        long RequestId { get; set; }

        /// <summary>
        /// Prepares and executes IPostStockTransferAcknowledgementRepository.
        /// </summary>
        long Execute();
    }
}