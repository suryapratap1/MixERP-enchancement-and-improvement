// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Office;
namespace MixERP.Net.Schemas.Office.Data
{
    public interface ISignInRepository
    {

        int OfficeId { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Browser { get; set; }
        string IpAddress { get; set; }
        string RemoteUser { get; set; }
        string Culture { get; set; }
        string Challenge { get; set; }

        /// <summary>
        /// Prepares and executes ISignInRepository.
        /// </summary>
        IEnumerable<DbSignInResult> Execute();
    }
}