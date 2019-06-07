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
    /// Prepares, validates, and executes the function "policy.is_elevated_user(_user_id integer)" on the database.
    /// </summary>
    public class IsElevatedUserProcedure : DbAccess, IIsElevatedUserRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "policy";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "is_elevated_user";
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
        /// Maps to "_user_id" argument of the function "policy.is_elevated_user".
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.is_elevated_user(_user_id integer)" on the database.
        /// </summary>
        public IsElevatedUserProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.is_elevated_user(_user_id integer)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "policy.is_elevated_user".</param>
        public IsElevatedUserProcedure(int userId)
        {
            this.UserId = userId;
        }
        /// <summary>
        /// Prepares and executes the function "policy.is_elevated_user".
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
                    Log.Information("Access to the function \"IsElevatedUserProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM policy.is_elevated_user(@UserId);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }


    }
}