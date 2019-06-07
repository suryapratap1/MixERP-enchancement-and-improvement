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
    /// Prepares, validates, and executes the function "core.is_parent_unit(parent integer, child integer)" on the database.
    /// </summary>
    public class IsParentUnitProcedure : DbAccess, IIsParentUnitRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "is_parent_unit";
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
        /// Maps to "parent" argument of the function "core.is_parent_unit".
        /// </summary>
        public int Parent { get; set; }
        /// <summary>
        /// Maps to "child" argument of the function "core.is_parent_unit".
        /// </summary>
        public int Child { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.is_parent_unit(parent integer, child integer)" on the database.
        /// </summary>
        public IsParentUnitProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.is_parent_unit(parent integer, child integer)" on the database.
        /// </summary>
        /// <param name="parent">Enter argument value for "parent" parameter of the function "core.is_parent_unit".</param>
        /// <param name="child">Enter argument value for "child" parameter of the function "core.is_parent_unit".</param>
        public IsParentUnitProcedure(int parent, int child)
        {
            this.Parent = parent;
            this.Child = child;
        }
        /// <summary>
        /// Prepares and executes the function "core.is_parent_unit".
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
                    Log.Information("Access to the function \"IsParentUnitProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.is_parent_unit(@Parent, @Child);";

            query = query.ReplaceWholeWord("@Parent", "@0::integer");
            query = query.ReplaceWholeWord("@Child", "@1::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.Parent);
            parameters.Add(this.Child);

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }


    }
}