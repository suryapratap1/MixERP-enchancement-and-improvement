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
    /// Prepares, validates, and executes the function "core.get_account_id_by_party_code(party_code text)" on the database.
    /// </summary>
    public class GetAccountIdByPartyCodeProcedure : DbAccess, IGetAccountIdByPartyCodeRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_account_id_by_party_code";
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
        /// Maps to "party_code" argument of the function "core.get_account_id_by_party_code".
        /// </summary>
        public string PartyCode { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_id_by_party_code(party_code text)" on the database.
        /// </summary>
        public GetAccountIdByPartyCodeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_id_by_party_code(party_code text)" on the database.
        /// </summary>
        /// <param name="partyCode">Enter argument value for "party_code" parameter of the function "core.get_account_id_by_party_code".</param>
        public GetAccountIdByPartyCodeProcedure(string partyCode)
        {
            this.PartyCode = partyCode;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_account_id_by_party_code".
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
                    Log.Information("Access to the function \"GetAccountIdByPartyCodeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_account_id_by_party_code(@PartyCode);";

            query = query.ReplaceWholeWord("@PartyCode", "@0::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.PartyCode);

            return Factory.Scalar<long>(this._Catalog, query, parameters.ToArray());
        }


    }
}