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
    /// Prepares, validates, and executes the function "core.get_account_id_by_party_type_id(_party_type_id integer)" on the database.
    /// </summary>
    public class GetAccountIdByPartyTypeIdProcedure : DbAccess, IGetAccountIdByPartyTypeIdRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_account_id_by_party_type_id";
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
        /// Maps to "_party_type_id" argument of the function "core.get_account_id_by_party_type_id".
        /// </summary>
        public int PartyTypeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_id_by_party_type_id(_party_type_id integer)" on the database.
        /// </summary>
        public GetAccountIdByPartyTypeIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_id_by_party_type_id(_party_type_id integer)" on the database.
        /// </summary>
        /// <param name="partyTypeId">Enter argument value for "_party_type_id" parameter of the function "core.get_account_id_by_party_type_id".</param>
        public GetAccountIdByPartyTypeIdProcedure(int partyTypeId)
        {
            this.PartyTypeId = partyTypeId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_account_id_by_party_type_id".
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
                    Log.Information("Access to the function \"GetAccountIdByPartyTypeIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_account_id_by_party_type_id(@PartyTypeId);";

            query = query.ReplaceWholeWord("@PartyTypeId", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.PartyTypeId);

            return Factory.Scalar<int>(this._Catalog, query, parameters.ToArray());
        }


    }
}