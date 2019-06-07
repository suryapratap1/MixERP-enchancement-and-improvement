// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class ValidateLoginRepository : IValidateLoginRepository
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Challenge { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}