// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetSalespersonReportRepository
    {

        int OfficeId { get; set; }
        int Factor { get; set; }

        /// <summary>
        /// Prepares and executes IGetSalespersonReportRepository.
        /// </summary>
        IEnumerable<DbGetSalespersonReportResult> Execute();
    }
}