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
    /// Prepares, validates, and executes the function "policy.change_password(_admin_user_id integer, _user_name text, _new_password text)" on the database.
    /// </summary>
    public class ChangePasswordProcedure : DbAccess, IChangePasswordRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "policy";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "change_password";
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
        /// Maps to "_admin_user_id" argument of the function "policy.change_password".
        /// </summary>
        public int AdminUserId { get; set; }
        /// <summary>
        /// Maps to "_user_name" argument of the function "policy.change_password".
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Maps to "_new_password" argument of the function "policy.change_password".
        /// </summary>
        public string NewPassword { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.change_password(_admin_user_id integer, _user_name text, _new_password text)" on the database.
        /// </summary>
        public ChangePasswordProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.change_password(_admin_user_id integer, _user_name text, _new_password text)" on the database.
        /// </summary>
        /// <param name="adminUserId">Enter argument value for "_admin_user_id" parameter of the function "policy.change_password".</param>
        /// <param name="userName">Enter argument value for "_user_name" parameter of the function "policy.change_password".</param>
        /// <param name="newPassword">Enter argument value for "_new_password" parameter of the function "policy.change_password".</param>
        public ChangePasswordProcedure(int adminUserId, string userName, string newPassword)
        {
            this.AdminUserId = adminUserId;
            this.UserName = userName;
            this.NewPassword = newPassword;
        }
        /// <summary>
        /// Prepares and executes the function "policy.change_password".
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
                    Log.Information("Access to the function \"ChangePasswordProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM policy.change_password(@AdminUserId, @UserName, @NewPassword);";

            query = query.ReplaceWholeWord("@AdminUserId", "@0::integer");
            query = query.ReplaceWholeWord("@UserName", "@1::text");
            query = query.ReplaceWholeWord("@NewPassword", "@2::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.AdminUserId);
            parameters.Add(this.UserName);
            parameters.Add(this.NewPassword);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}