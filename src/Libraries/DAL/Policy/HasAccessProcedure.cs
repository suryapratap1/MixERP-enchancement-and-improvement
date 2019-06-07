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
    /// Prepares, validates, and executes the function "policy.has_access(_user_id integer, _entity text, _access_type_id integer)" on the database.
    /// </summary>
    public class HasAccessProcedure : DbAccess, IHasAccessRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "policy";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "has_access";
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
        /// Maps to "_user_id" argument of the function "policy.has_access".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_entity" argument of the function "policy.has_access".
        /// </summary>
        public string Entity { get; set; }
        /// <summary>
        /// Maps to "_access_type_id" argument of the function "policy.has_access".
        /// </summary>
        public int AccessTypeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.has_access(_user_id integer, _entity text, _access_type_id integer)" on the database.
        /// </summary>
        public HasAccessProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.has_access(_user_id integer, _entity text, _access_type_id integer)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "policy.has_access".</param>
        /// <param name="entity">Enter argument value for "_entity" parameter of the function "policy.has_access".</param>
        /// <param name="accessTypeId">Enter argument value for "_access_type_id" parameter of the function "policy.has_access".</param>
        public HasAccessProcedure(int userId, string entity, int accessTypeId)
        {
            this.UserId = userId;
            this.Entity = entity;
            this.AccessTypeId = accessTypeId;
        }
        /// <summary>
        /// Prepares and executes the function "policy.has_access".
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
                    Log.Information("Access to the function \"HasAccessProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM policy.has_access(@UserId, @Entity, @AccessTypeId);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@Entity", "@1::text");
            query = query.ReplaceWholeWord("@AccessTypeId", "@2::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.Entity);
            parameters.Add(this.AccessTypeId);

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }


    }
}