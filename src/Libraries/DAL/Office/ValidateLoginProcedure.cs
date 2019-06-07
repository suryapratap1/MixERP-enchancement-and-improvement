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
    /// Prepares, validates, and executes the function "office.validate_login(user_name text, password text, challenge text)" on the database.
    /// </summary>
    public class ValidateLoginProcedure : DbAccess, IValidateLoginRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "validate_login";
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
        /// Maps to "user_name" argument of the function "office.validate_login".
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Maps to "password" argument of the function "office.validate_login".
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Maps to "challenge" argument of the function "office.validate_login".
        /// </summary>
        public string Challenge { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "office.validate_login(user_name text, password text, challenge text)" on the database.
        /// </summary>
        public ValidateLoginProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "office.validate_login(user_name text, password text, challenge text)" on the database.
        /// </summary>
        /// <param name="userName">Enter argument value for "user_name" parameter of the function "office.validate_login".</param>
        /// <param name="password">Enter argument value for "password" parameter of the function "office.validate_login".</param>
        /// <param name="challenge">Enter argument value for "challenge" parameter of the function "office.validate_login".</param>
        public ValidateLoginProcedure(string userName, string password, string challenge)
        {
            this.UserName = userName;
            this.Password = password;
            this.Challenge = challenge;
        }
        /// <summary>
        /// Prepares and executes the function "office.validate_login".
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
                    Log.Information("Access to the function \"ValidateLoginProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM office.validate_login(@UserName, @Password, @Challenge);";

            query = query.ReplaceWholeWord("@UserName", "@0::text");
            query = query.ReplaceWholeWord("@Password", "@1::text");
            query = query.ReplaceWholeWord("@Challenge", "@2::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserName);
            parameters.Add(this.Password);
            parameters.Add(this.Challenge);

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }


    }
}