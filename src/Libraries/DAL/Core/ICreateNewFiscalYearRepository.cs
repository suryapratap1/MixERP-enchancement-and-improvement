// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICreateNewFiscalYearRepository
    {

        int OfficeId { get; set; }
        int UserId { get; set; }
        string FiscalYearCode { get; set; }
        string FiscalYearName { get; set; }

        /// <summary>
        /// Prepares and executes ICreateNewFiscalYearRepository.
        /// </summary>
        void Execute();
    }
}