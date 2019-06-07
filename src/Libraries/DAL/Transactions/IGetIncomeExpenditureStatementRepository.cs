// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetIncomeExpenditureStatementRepository
    {

        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }
        int UserId { get; set; }
        int OfficeId { get; set; }
        bool Compact { get; set; }

        /// <summary>
        /// Prepares and executes IGetIncomeExpenditureStatementRepository.
        /// </summary>
        IEnumerable<DbGetIncomeExpenditureStatementResult> Execute();
    }
}