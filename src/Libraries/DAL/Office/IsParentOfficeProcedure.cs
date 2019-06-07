// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Office;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Office.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "office.is_parent_office(parent integer_strict, child integer_strict)" on the database.
    /// </summary>
    public class IsParentOfficeProcedure : DbAccess, IIsParentOfficeRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "is_parent_office";
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
        /// Maps to "parent" argument of the function "office.is_parent_office".
        /// </summary>
        public int Parent { get; set; }
        /// <summary>
        /// Maps to "child" argument of the function "office.is_parent_office".
        /// </summary>
        public int Child { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "office.is_parent_office(parent integer_strict, child integer_strict)" on the database.
        /// </summary>
        public IsParentOfficeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "office.is_parent_office(parent integer_strict, child integer_strict)" on the database.
        /// </summary>
        /// <param name="parent">Enter argument value for "parent" parameter of the function "office.is_parent_office".</param>
        /// <param name="child">Enter argument value for "child" parameter of the function "office.is_parent_office".</param>
        public IsParentOfficeProcedure(int parent, int child)
        {
            this.Parent = parent;
            this.Child = child;
        }
        /// <summary>
        /// Prepares and executes the function "office.is_parent_office".
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
                    Log.Information("Access to the function \"IsParentOfficeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM office.is_parent_office(@Parent, @Child);";

            query = query.ReplaceWholeWord("@Parent", "@0::integer_strict");
            query = query.ReplaceWholeWord("@Child", "@1::integer_strict");


            List<object> parameters = new List<object>();
            parameters.Add(this.Parent);
            parameters.Add(this.Child);

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }


    }
}