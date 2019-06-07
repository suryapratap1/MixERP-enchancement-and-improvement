// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class SignInRepository : ISignInRepository
    {
        public int OfficeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Browser { get; set; }
        public string IpAddress { get; set; }
        public string RemoteUser { get; set; }
        public string Culture { get; set; }
        public string Challenge { get; set; }

        public IEnumerable<DbSignInResult> Execute()
        {
            return new List<DbSignInResult>();
        }
    }
}