// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Office;
namespace MixERP.Net.Schemas.Office.Data
{
    public interface IGetOfficeIdByOfficeCodeRepository
    {

        string OfficeCode { get; set; }

        /// <summary>
        /// Prepares and executes IGetOfficeIdByOfficeCodeRepository.
        /// </summary>
        int Execute();
    }
}