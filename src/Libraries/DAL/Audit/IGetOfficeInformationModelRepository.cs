// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Audit;
namespace MixERP.Net.Schemas.Audit.Data
{
    public interface IGetOfficeInformationModelRepository
    {

        int PgArg0 { get; set; }

        /// <summary>
        /// Prepares and executes IGetOfficeInformationModelRepository.
        /// </summary>
        IEnumerable<DbGetOfficeInformationModelResult> Execute();
    }
}