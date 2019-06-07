// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetFieldRepository
    {

        string Hstore { get; set; }
        string ColumnName { get; set; }

        /// <summary>
        /// Prepares and executes IGetFieldRepository.
        /// </summary>
        string Execute();
    }
}