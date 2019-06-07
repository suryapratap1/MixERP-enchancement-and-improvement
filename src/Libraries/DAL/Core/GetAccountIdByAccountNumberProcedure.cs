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
    /// Prepares, validates, and executes the function "core.get_account_id_by_account_number(_account_number text)" on the database.
    /// </summary>
    public class GetAccountIdByAccountNumberProcedure : DbAccess, IGetAccountIdByAccountNumberRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_account_id_by_account_number";
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
        /// Maps to "_account_number" argument of the function "core.get_account_id_by_account_number".
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_id_by_account_number(_account_number text)" on the database.
        /// </summary>
        public GetAccountIdByAccountNumberProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_id_by_account_number(_account_number text)" on the database.
        /// </summary>
        /// <param name="accountNumber">Enter argument value for "_account_number" parameter of the function "core.get_account_id_by_account_number".</param>
        public GetAccountIdByAccountNumberProcedure(string accountNumber)
        {
            this.AccountNumber = accountNumber;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_account_id_by_account_number".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public long Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetAccountIdByAccountNumberProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_account_id_by_account_number(@AccountNumber);";

            query = query.ReplaceWholeWord("@AccountNumber", "@0::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.AccountNumber);

            return Factory.Scalar<long>(this._Catalog, query, parameters.ToArray());
        }


    }
}