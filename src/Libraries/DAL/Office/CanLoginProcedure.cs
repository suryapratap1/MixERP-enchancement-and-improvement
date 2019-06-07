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
    /// Prepares, validates, and executes the function "office.can_login(user_id integer_strict, office_id integer_strict)" on the database.
    /// </summary>
    public class CanLoginProcedure : DbAccess, ICanLoginRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "can_login";
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
        /// Maps to "user_id" argument of the function "office.can_login".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "office_id" argument of the function "office.can_login".
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "office.can_login(user_id integer_strict, office_id integer_strict)" on the database.
        /// </summary>
        public CanLoginProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "office.can_login(user_id integer_strict, office_id integer_strict)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "user_id" parameter of the function "office.can_login".</param>
        /// <param name="officeId">Enter argument value for "office_id" parameter of the function "office.can_login".</param>
        public CanLoginProcedure(int userId, int officeId)
        {
            this.UserId = userId;
            this.OfficeId = officeId;
        }
        /// <summary>
        /// Prepares and executes the function "office.can_login".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbCanLoginResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"CanLoginProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM office.can_login(@UserId, @OfficeId);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer_strict");
            query = query.ReplaceWholeWord("@OfficeId", "@1::integer_strict");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.OfficeId);

            return Factory.Get<DbCanLoginResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}