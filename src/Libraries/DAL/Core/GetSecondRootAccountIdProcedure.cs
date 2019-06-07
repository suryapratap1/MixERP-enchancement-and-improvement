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
    /// Prepares, validates, and executes the function "core.get_second_root_account_id(_account_id bigint, _parent bigint)" on the database.
    /// </summary>
    public class GetSecondRootAccountIdProcedure : DbAccess, IGetSecondRootAccountIdRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_second_root_account_id";
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
        /// Maps to "_account_id" argument of the function "core.get_second_root_account_id".
        /// </summary>
        public long AccountId { get; set; }
        /// <summary>
        /// Maps to "_parent" argument of the function "core.get_second_root_account_id".
        /// </summary>
        public long Parent { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_second_root_account_id(_account_id bigint, _parent bigint)" on the database.
        /// </summary>
        public GetSecondRootAccountIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_second_root_account_id(_account_id bigint, _parent bigint)" on the database.
        /// </summary>
        /// <param name="accountId">Enter argument value for "_account_id" parameter of the function "core.get_second_root_account_id".</param>
        /// <param name="parent">Enter argument value for "_parent" parameter of the function "core.get_second_root_account_id".</param>
        public GetSecondRootAccountIdProcedure(long accountId, long parent)
        {
            this.AccountId = accountId;
            this.Parent = parent;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_second_root_account_id".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public int Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetSecondRootAccountIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_second_root_account_id(@AccountId, @Parent);";

            query = query.ReplaceWholeWord("@AccountId", "@0::bigint");
            query = query.ReplaceWholeWord("@Parent", "@1::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.AccountId);
            parameters.Add(this.Parent);

            return Factory.Scalar<int>(this._Catalog, query, parameters.ToArray());
        }


    }
}