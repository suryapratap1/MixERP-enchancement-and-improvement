// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Office;
namespace MixERP.Net.Schemas.Office.Data
{
    public interface IGetRoleIdByRoleCodeRepository
    {

        string RoleCode { get; set; }

        /// <summary>
        /// Prepares and executes IGetRoleIdByRoleCodeRepository.
        /// </summary>
        int Execute();
    }
}