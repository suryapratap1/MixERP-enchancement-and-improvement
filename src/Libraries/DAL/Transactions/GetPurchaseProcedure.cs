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
    /// Prepares, validates, and executes the function "transactions.get_purchase(_date_from date, _date_to date, _office_id integer)" on the database.
    /// </summary>
    public class GetPurchaseProcedure : DbAccess, IGetPurchaseRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_purchase";
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
        /// Maps to "_date_from" argument of the function "transactions.get_purchase".
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Maps to "_date_to" argument of the function "transactions.get_purchase".
        /// </summary>
        public DateTime DateTo { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.get_purchase".
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_purchase(_date_from date, _date_to date, _office_id integer)" on the database.
        /// </summary>
        public GetPurchaseProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_purchase(_date_from date, _date_to date, _office_id integer)" on the database.
        /// </summary>
        /// <param name="dateFrom">Enter argument value for "_date_from" parameter of the function "transactions.get_purchase".</param>
        /// <param name="dateTo">Enter argument value for "_date_to" parameter of the function "transactions.get_purchase".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_purchase".</param>
        public GetPurchaseProcedure(DateTime dateFrom, DateTime dateTo, int officeId)
        {
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.OfficeId = officeId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_purchase".
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
                    Log.Information("Access to the function \"GetPurchaseProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_purchase(@DateFrom, @DateTo, @OfficeId);";

            query = query.ReplaceWholeWord("@DateFrom", "@0::date");
            query = query.ReplaceWholeWord("@DateTo", "@1::date");
            query = query.ReplaceWholeWord("@OfficeId", "@2::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.DateFrom);
            parameters.Add(this.DateTo);
            parameters.Add(this.OfficeId);

            return Factory.Scalar<decimal>(this._Catalog, query, parameters.ToArray());
        }


    }
}