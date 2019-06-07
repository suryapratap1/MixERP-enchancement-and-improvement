// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "transactions.get_exchange_rate(office_id integer, source_currency_code character varying, destination_currency_code character varying)" on the database.
    /// </summary>
    public class GetExchangeRateProcedure : DbAccess, IGetExchangeRateRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_exchange_rate";
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
        /// Maps to "office_id" argument of the function "transactions.get_exchange_rate".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "source_currency_code" argument of the function "transactions.get_exchange_rate".
        /// </summary>
        public string SourceCurrencyCode { get; set; }
        /// <summary>
        /// Maps to "destination_currency_code" argument of the function "transactions.get_exchange_rate".
        /// </summary>
        public string DestinationCurrencyCode { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_exchange_rate(office_id integer, source_currency_code character varying, destination_currency_code character varying)" on the database.
        /// </summary>
        public GetExchangeRateProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_exchange_rate(office_id integer, source_currency_code character varying, destination_currency_code character varying)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "office_id" parameter of the function "transactions.get_exchange_rate".</param>
        /// <param name="sourceCurrencyCode">Enter argument value for "source_currency_code" parameter of the function "transactions.get_exchange_rate".</param>
        /// <param name="destinationCurrencyCode">Enter argument value for "destination_currency_code" parameter of the function "transactions.get_exchange_rate".</param>
        public GetExchangeRateProcedure(int officeId, string sourceCurrencyCode, string destinationCurrencyCode)
        {
            this.OfficeId = officeId;
            this.SourceCurrencyCode = sourceCurrencyCode;
            this.DestinationCurrencyCode = destinationCurrencyCode;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_exchange_rate".
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
                    Log.Information("Access to the function \"GetExchangeRateProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_exchange_rate(@OfficeId, @SourceCurrencyCode, @DestinationCurrencyCode);";

            query = query.ReplaceWholeWord("@OfficeId", "@0::integer");
            query = query.ReplaceWholeWord("@SourceCurrencyCode", "@1::character varying");
            query = query.ReplaceWholeWord("@DestinationCurrencyCode", "@2::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.OfficeId);
            parameters.Add(this.SourceCurrencyCode);
            parameters.Add(this.DestinationCurrencyCode);

            return Factory.Get<decimal>(this._Catalog, query, parameters.ToArray()).FirstOrDefault();
        }


    }
}