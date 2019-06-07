// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Office;
namespace MixERP.Net.Schemas.Office.Data
{
    public interface IGetOfficesRepository
    {

        /// <summary>
        /// Prepares and executes IGetOfficesRepository.
        /// </summary>
        IEnumerable<DbGetOfficesResult> Execute();
    }
}