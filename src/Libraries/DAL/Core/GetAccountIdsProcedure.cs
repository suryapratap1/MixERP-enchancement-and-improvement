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
    /// Prepares, validates, and executes the function "core.get_account_ids(root_account_id bigint)" on the database.
    /// </summary>
    public class GetAccountIdsProcedure : DbAccess, IGetAccountIdsRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_account_ids";
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
        /// Maps to "root_account_id" argument of the function "core.get_account_ids".
        /// </summary>
        public long RootAccountId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_ids(root_account_id bigint)" on the database.
        /// </summary>
        public GetAccountIdsProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_ids(root_account_id bigint)" on the database.
        /// </summary>
        /// <param name="rootAccountId">Enter argument value for "root_account_id" parameter of the function "core.get_account_ids".</param>
        public GetAccountIdsProcedure(long rootAccountId)
        {
            this.RootAccountId = rootAccountId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_account_ids".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<long> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetAccountIdsProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_account_ids(@RootAccountId);";

            query = query.ReplaceWholeWord("@RootAccountId", "@0::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.RootAccountId);

            return Factory.Get<long>(this._Catalog, query, parameters.ToArray());
        }


    }
}