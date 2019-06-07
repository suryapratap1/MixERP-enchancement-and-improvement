// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Core.Modules.HRM.Data;
using MixERP.Net.Entities.HRM;

namespace MixERP.Net.Api.HRM.Fakes
{
    public class GetEmployeeByEmployeeIdRepository : IGetEmployeeByEmployeeIdRepository
    {
        public int EmployeeId { get; set; }

        public string Execute()
        {
            return "FizzBuzz";
        }
    }
}