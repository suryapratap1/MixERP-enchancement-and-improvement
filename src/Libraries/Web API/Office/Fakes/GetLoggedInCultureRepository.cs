// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class GetLoggedInCultureRepository : IGetLoggedInCultureRepository
    {
        public int UserId { get; set; }

        public string Execute()
        {
            return "FizzBuzz";
        }
    }
}