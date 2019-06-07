// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Core;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "core.convert_unit(from_unit integer, to_unit integer)" on the database.
    /// </summary>
    public class ConvertUnitProcedure : DbAccess, IConvertUnitRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "convert_unit";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
        public long _LoginId { get; set; }
        /// <summary>
        /// User id of application user accessing this table.
        /// </summary>
        public int _UserId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string _Catalog { get; set; }

        /// <summary>
        /// Maps to "from_unit" argument of the function "core.convert_unit".
        /// </summary>
        public int FromUnit { get; set; }
        /// <summary>
        /// Maps to "to_unit" argument of the function "core.convert_unit".
        /// </summary>
        public int ToUnit { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.convert_unit(from_unit integer, to_unit integer)" on the database.
        /// </summary>
        public ConvertUnitProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.convert_unit(from_unit integer, to_unit integer)" on the database.
        /// </summary>
        /// <param name="fromUnit">Enter argument value for "from_unit" parameter of the function "core.convert_unit".</param>
        /// <param name="toUnit">Enter argument value for "to_unit" parameter of the function "core.convert_unit".</param>
        public ConvertUnitProcedure(int fromUnit, int toUnit)
        {
            this.FromUnit = fromUnit;
            this.ToUnit = toUnit;
        }
        /// <summary>
        /// Prepares and executes the function "core.convert_unit".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public decimal Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"ConvertUnitProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.convert_unit(@FromUnit, @ToUnit);";

            query = query.ReplaceWholeWord("@FromUnit", "@0::integer");
            query = query.ReplaceWholeWord("@ToUnit", "@1::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.FromUnit);
            parameters.Add(this.ToUnit);

            return Factory.Scalar<decimal>(this._Catalog, query, parameters.ToArray());
        }


    }
}