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
    /// Prepares, validates, and executes the function "core.get_flag_foreground_color(flag_type_id_ integer)" on the database.
    /// </summary>
    public class GetFlagForegroundColorProcedure : DbAccess, IGetFlagForegroundColorRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_flag_foreground_color";
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
        /// Maps to "flag_type_id_" argument of the function "core.get_flag_foreground_color".
        /// </summary>
        public int FlagTypeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_flag_foreground_color(flag_type_id_ integer)" on the database.
        /// </summary>
        public GetFlagForegroundColorProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_flag_foreground_color(flag_type_id_ integer)" on the database.
        /// </summary>
        /// <param name="flagTypeId">Enter argument value for "flag_type_id_" parameter of the function "core.get_flag_foreground_color".</param>
        public GetFlagForegroundColorProcedure(int flagTypeId)
        {
            this.FlagTypeId = flagTypeId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_flag_foreground_color".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public string Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetFlagForegroundColorProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_flag_foreground_color(@FlagTypeId);";

            query = query.ReplaceWholeWord("@FlagTypeId", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.FlagTypeId);

            return Factory.Scalar<string>(this._Catalog, query, parameters.ToArray());
        }


    }
}