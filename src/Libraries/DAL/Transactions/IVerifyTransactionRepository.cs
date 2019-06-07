// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IVerifyTransactionRepository
    {

        long TransactionMasterId { get; set; }
        int OfficeId { get; set; }
        int UserId { get; set; }
        long LoginId { get; set; }
        short VerificationStatusId { get; set; }
        string Reason { get; set; }

        /// <summary>
        /// Prepares and executes IVerifyTransactionRepository.
        /// </summary>
        long Execute();
    }
}