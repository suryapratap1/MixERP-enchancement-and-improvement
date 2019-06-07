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
    /// Prepares, validates, and executes the function "core.get_frequency_setup_start_date_by_frequency_setup_id(_frequency_setup_id integer)" on the database.
    /// </summary>
    public class GetFrequencySetupStartDateByFrequencySetupIdProcedure : DbAccess, IGetFrequencySetupStartDateByFrequencySetupIdRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_frequency_setup_start_date_by_frequency_setup_id";
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
        /// Maps to "_frequency_setup_id" argument of the function "core.get_frequency_setup_start_date_by_frequency_setup_id".
        /// </summary>
        public int FrequencySetupId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_frequency_setup_start_date_by_frequency_setup_id(_frequency_setup_id integer)" on the database.
        /// </summary>
        public GetFrequencySetupStartDateByFrequencySetupIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_frequency_setup_start_date_by_frequency_setup_id(_frequency_setup_id integer)" on the database.
        /// </summary>
        /// <param name="frequencySetupId">Enter argument value for "_frequency_setup_id" parameter of the function "core.get_frequency_setup_start_date_by_frequency_setup_id".</param>
        public GetFrequencySetupStartDateByFrequencySetupIdProcedure(int frequencySetupId)
        {
            this.FrequencySetupId = frequencySetupId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_frequency_setup_start_date_by_frequency_setup_id".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public DateTime Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetFrequencySetupStartDateByFrequencySetupIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_frequency_setup_start_date_by_frequency_setup_id(@FrequencySetupId);";

            query = query.ReplaceWholeWord("@FrequencySetupId", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.FrequencySetupId);

            return Factory.Scalar<DateTime>(this._Catalog, query, parameters.ToArray());
        }


    }
}