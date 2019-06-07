// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.HRM;
namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IGetEmployeeByEmployeeIdRepository
    {

        int EmployeeId { get; set; }

        /// <summary>
        /// Prepares and executes IGetEmployeeByEmployeeIdRepository.
        /// </summary>
        string Execute();
    }
}