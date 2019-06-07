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
    /// Prepares, validates, and executes the function "core.get_account_id_by_party_id(party_id bigint)" on the database.
    /// </summary>
    public class GetAccountIdByPartyIdProcedure : DbAccess, IGetAccountIdByPartyIdRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_account_id_by_party_id";
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
        /// Maps to "party_id" argument of the function "core.get_account_id_by_party_id".
        /// </summary>
        public long PartyId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_id_by_party_id(party_id bigint)" on the database.
        /// </summary>
        public GetAccountIdByPartyIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_id_by_party_id(party_id bigint)" on the database.
        /// </summary>
        /// <param name="partyId">Enter argument value for "party_id" parameter of the function "core.get_account_id_by_party_id".</param>
        public GetAccountIdByPartyIdProcedure(long partyId)
        {
            this.PartyId = partyId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_account_id_by_party_id".
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
                    Log.Information("Access to the function \"GetAccountIdByPartyIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_account_id_by_party_id(@PartyId);";

            query = query.ReplaceWholeWord("@PartyId", "@0::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.PartyId);

            return Factory.Scalar<long>(this._Catalog, query, parameters.ToArray());
        }


    }
}