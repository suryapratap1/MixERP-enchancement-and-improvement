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
    /// Prepares, validates, and executes the function "transactions.has_nexus(_state_id integer)" on the database.
    /// </summary>
    public class HasNexusProcedure : DbAccess, IHasNexusRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "has_nexus";
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
        /// Maps to "_state_id" argument of the function "transactions.has_nexus".
        /// </summary>
        public int StateId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.has_nexus(_state_id integer)" on the database.
        /// </summary>
        public HasNexusProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.has_nexus(_state_id integer)" on the database.
        /// </summary>
        /// <param name="stateId">Enter argument value for "_state_id" parameter of the function "transactions.has_nexus".</param>
        public HasNexusProcedure(int stateId)
        {
            this.StateId = stateId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.has_nexus".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public bool Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"HasNexusProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.has_nexus(@StateId);";

            query = query.ReplaceWholeWord("@StateId", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.StateId);

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }


    }
}