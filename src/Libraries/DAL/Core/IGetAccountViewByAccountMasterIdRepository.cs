// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetAccountViewByAccountMasterIdRepository
    {

        int AccountMasterId { get; set; }
        int RowNumber { get; set; }

        /// <summary>
        /// Prepares and executes IGetAccountViewByAccountMasterIdRepository.
        /// </summary>
        IEnumerable<DbGetAccountViewByAccountMasterIdResult> Execute();
    }
}