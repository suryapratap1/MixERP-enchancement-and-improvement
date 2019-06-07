// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class CreateUserRepository : ICreateUserRepository
    {
        public int RoleId { get; set; }
        public int DepartmentId { get; set; }
        public int OfficeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Elevated { get; set; }

        public void Execute()
        {
            return;
        }
    }
}