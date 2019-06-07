// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Office;
namespace MixERP.Net.Schemas.Office.Data
{
    public interface ICreateUserRepository
    {

        int RoleId { get; set; }
        int DepartmentId { get; set; }
        int OfficeId { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string FullName { get; set; }
        bool Elevated { get; set; }

        /// <summary>
        /// Prepares and executes ICreateUserRepository.
        /// </summary>
        void Execute();
    }
}