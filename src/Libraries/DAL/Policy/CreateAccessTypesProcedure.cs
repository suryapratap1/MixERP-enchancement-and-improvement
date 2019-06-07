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
    /// Prepares, validates, and executes the function "policy.create_access_types(_access_type_id integer, _access_type_name character varying)" on the database.
    /// </summary>
    public class CreateAccessTypesProcedure : DbAccess, ICreateAccessTypesRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "policy";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_access_types";
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
        /// Maps to "_access_type_id" argument of the function "policy.create_access_types".
        /// </summary>
        public int AccessTypeId { get; set; }
        /// <summary>
        /// Maps to "_access_type_name" argument of the function "policy.create_access_types".
        /// </summary>
        public string AccessTypeName { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.create_access_types(_access_type_id integer, _access_type_name character varying)" on the database.
        /// </summary>
        public CreateAccessTypesProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.create_access_types(_access_type_id integer, _access_type_name character varying)" on the database.
        /// </summary>
        /// <param name="accessTypeId">Enter argument value for "_access_type_id" parameter of the function "policy.create_access_types".</param>
        /// <param name="accessTypeName">Enter argument value for "_access_type_name" parameter of the function "policy.create_access_types".</param>
        public CreateAccessTypesProcedure(int accessTypeId, string accessTypeName)
        {
            this.AccessTypeId = accessTypeId;
            this.AccessTypeName = accessTypeName;
        }
        /// <summary>
        /// Prepares and executes the function "policy.create_access_types".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"CreateAccessTypesProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM policy.create_access_types(@AccessTypeId, @AccessTypeName);";

            query = query.ReplaceWholeWord("@AccessTypeId", "@0::integer");
            query = query.ReplaceWholeWord("@AccessTypeName", "@1::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.AccessTypeId);
            parameters.Add(this.AccessTypeName);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}