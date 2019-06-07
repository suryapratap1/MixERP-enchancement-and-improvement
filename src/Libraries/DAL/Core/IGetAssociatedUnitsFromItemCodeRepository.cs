// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetAssociatedUnitsFromItemCodeRepository
    {

        string PgArg0 { get; set; }

        /// <summary>
        /// Prepares and executes IGetAssociatedUnitsFromItemCodeRepository.
        /// </summary>
        IEnumerable<DbGetAssociatedUnitsFromItemCodeResult> Execute();
    }
}