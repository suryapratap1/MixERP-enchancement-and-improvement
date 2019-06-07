// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Policy;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Policy.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "policy.is_transaction_restricted(_office_id integer)" on the database.
    /// </summary>
    public class IsTransactionRestrictedProcedure : DbAccess, IIsTransactionRestrictedRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "policy";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "is_transaction_restricted";
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
        /// Maps to "_office_id" argument of the function "policy.is_transaction_restricted".
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.is_transaction_restricted(_office_id integer)" on the database.
        /// </summary>
        public IsTransactionRestrictedProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.is_transaction_restricted(_office_id integer)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "policy.is_transaction_restricted".</param>
        public IsTransactionRestrictedProcedure(int officeId)
        {
            this.OfficeId = officeId;
        }
        /// <summary>
        /// Prepares and executes the function "policy.is_transaction_restricted".
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
                    Log.Information("Access to the function \"IsTransactionRestrictedProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM policy.is_transaction_restricted(@OfficeId);";

            query = query.ReplaceWholeWord("@OfficeId", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.OfficeId);

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }


    }
}