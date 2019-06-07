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
    /// Prepares, validates, and executes the function "core.get_periods(_date_from date, _date_to date)" on the database.
    /// </summary>
    public class GetPeriodsProcedure : DbAccess, IGetPeriodsRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_periods";
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
        /// Maps to "_date_from" argument of the function "core.get_periods".
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Maps to "_date_to" argument of the function "core.get_periods".
        /// </summary>
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_periods(_date_from date, _date_to date)" on the database.
        /// </summary>
        public GetPeriodsProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_periods(_date_from date, _date_to date)" on the database.
        /// </summary>
        /// <param name="dateFrom">Enter argument value for "_date_from" parameter of the function "core.get_periods".</param>
        /// <param name="dateTo">Enter argument value for "_date_to" parameter of the function "core.get_periods".</param>
        public GetPeriodsProcedure(DateTime dateFrom, DateTime dateTo)
        {
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_periods".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.Period> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetPeriodsProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_periods(@DateFrom, @DateTo);";

            query = query.ReplaceWholeWord("@DateFrom", "@0::date");
            query = query.ReplaceWholeWord("@DateTo", "@1::date");


            List<object> parameters = new List<object>();
            parameters.Add(this.DateFrom);
            parameters.Add(this.DateTo);

            return Factory.Get<MixERP.Net.Entities.Core.Period>(this._Catalog, query, parameters.ToArray());
        }


    }
}