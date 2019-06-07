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
    /// Prepares, validates, and executes the function "core.get_frequency_end_date(_frequency_id integer, _value_date date)" on the database.
    /// </summary>
    public class GetFrequencyEndDateProcedure : DbAccess, IGetFrequencyEndDateRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_frequency_end_date";
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
        /// Maps to "_frequency_id" argument of the function "core.get_frequency_end_date".
        /// </summary>
        public int FrequencyId { get; set; }
        /// <summary>
        /// Maps to "_value_date" argument of the function "core.get_frequency_end_date".
        /// </summary>
        public DateTime ValueDate { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_frequency_end_date(_frequency_id integer, _value_date date)" on the database.
        /// </summary>
        public GetFrequencyEndDateProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_frequency_end_date(_frequency_id integer, _value_date date)" on the database.
        /// </summary>
        /// <param name="frequencyId">Enter argument value for "_frequency_id" parameter of the function "core.get_frequency_end_date".</param>
        /// <param name="valueDate">Enter argument value for "_value_date" parameter of the function "core.get_frequency_end_date".</param>
        public GetFrequencyEndDateProcedure(int frequencyId, DateTime valueDate)
        {
            this.FrequencyId = frequencyId;
            this.ValueDate = valueDate;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_frequency_end_date".
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
                    Log.Information("Access to the function \"GetFrequencyEndDateProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_frequency_end_date(@FrequencyId, @ValueDate);";

            query = query.ReplaceWholeWord("@FrequencyId", "@0::integer");
            query = query.ReplaceWholeWord("@ValueDate", "@1::date");


            List<object> parameters = new List<object>();
            parameters.Add(this.FrequencyId);
            parameters.Add(this.ValueDate);

            return Factory.Scalar<DateTime>(this._Catalog, query, parameters.ToArray());
        }


    }
}