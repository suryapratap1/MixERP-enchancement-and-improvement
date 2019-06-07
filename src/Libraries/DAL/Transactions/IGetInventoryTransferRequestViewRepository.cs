// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetInventoryTransferRequestViewRepository
    {

        int UserId { get; set; }
        long LoginId { get; set; }
        int OfficeId { get; set; }
        DateTime From { get; set; }
        DateTime To { get; set; }
        string Office { get; set; }
        string Store { get; set; }
        string Authorized { get; set; }
        string Delivered { get; set; }
        string Received { get; set; }
        string User { get; set; }
        string ReferenceNumber { get; set; }
        string StatementReference { get; set; }

        /// <summary>
        /// Prepares and executes IGetInventoryTransferRequestViewRepository.
        /// </summary>
        IEnumerable<DbGetInventoryTransferRequestViewResult> Execute();
    }
}