// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAppendIfNotNullRepository
    {

        string Source { get; set; }
        string ToAppend { get; set; }

        /// <summary>
        /// Prepares and executes IAppendIfNotNullRepository.
        /// </summary>
        string Execute();
    }
}