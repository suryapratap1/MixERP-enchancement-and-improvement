// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.HRM;
namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IGetEmployeeCodeByEmployeeIdRepository
    {

        int EmployeeId { get; set; }

        /// <summary>
        /// Prepares and executes IGetEmployeeCodeByEmployeeIdRepository.
        /// </summary>
        string Execute();
    }
}