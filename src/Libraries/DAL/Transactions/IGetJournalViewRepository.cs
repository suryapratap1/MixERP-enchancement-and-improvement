// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetJournalViewRepository
    {

        int UserId { get; set; }
        int OfficeId { get; set; }
        DateTime From { get; set; }
        DateTime To { get; set; }
        long TranId { get; set; }
        string TranCode { get; set; }
        string Book { get; set; }
        string ReferenceNumber { get; set; }
        string StatementReference { get; set; }
        string PostedBy { get; set; }
        string Office { get; set; }
        string Status { get; set; }
        string VerifiedBy { get; set; }
        string Reason { get; set; }

        /// <summary>
        /// Prepares and executes IGetJournalViewRepository.
        /// </summary>
        IEnumerable<DbGetJournalViewResult> Execute();
    }
}