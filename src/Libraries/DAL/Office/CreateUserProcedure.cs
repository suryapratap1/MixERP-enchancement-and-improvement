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
    /// Prepares, validates, and executes the function "office.create_user(_role_id integer, _department_id integer, _office_id integer, _user_name text, _password text, _full_name text, _elevated boolean)" on the database.
    /// </summary>
    public class CreateUserProcedure : DbAccess, ICreateUserRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_user";
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
        /// Maps to "_role_id" argument of the function "office.create_user".
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Maps to "_department_id" argument of the function "office.create_user".
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "office.create_user".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_user_name" argument of the function "office.create_user".
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Maps to "_password" argument of the function "office.create_user".
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Maps to "_full_name" argument of the function "office.create_user".
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Maps to "_elevated" argument of the function "office.create_user".
        /// </summary>
        public bool Elevated { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "office.create_user(_role_id integer, _department_id integer, _office_id integer, _user_name text, _password text, _full_name text, _elevated boolean)" on the database.
        /// </summary>
        public CreateUserProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "office.create_user(_role_id integer, _department_id integer, _office_id integer, _user_name text, _password text, _full_name text, _elevated boolean)" on the database.
        /// </summary>
        /// <param name="roleId">Enter argument value for "_role_id" parameter of the function "office.create_user".</param>
        /// <param name="departmentId">Enter argument value for "_department_id" parameter of the function "office.create_user".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "office.create_user".</param>
        /// <param name="userName">Enter argument value for "_user_name" parameter of the function "office.create_user".</param>
        /// <param name="password">Enter argument value for "_password" parameter of the function "office.create_user".</param>
        /// <param name="fullName">Enter argument value for "_full_name" parameter of the function "office.create_user".</param>
        /// <param name="elevated">Enter argument value for "_elevated" parameter of the function "office.create_user".</param>
        public CreateUserProcedure(int roleId, int departmentId, int officeId, string userName, string password, string fullName, bool elevated)
        {
            this.RoleId = roleId;
            this.DepartmentId = departmentId;
            this.OfficeId = officeId;
            this.UserName = userName;
            this.Password = password;
            this.FullName = fullName;
            this.Elevated = elevated;
        }
        /// <summary>
        /// Prepares and executes the function "office.create_user".
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
                    Log.Information("Access to the function \"CreateUserProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM office.create_user(@RoleId, @DepartmentId, @OfficeId, @UserName, @Password, @FullName, @Elevated);";

            query = query.ReplaceWholeWord("@RoleId", "@0::integer");
            query = query.ReplaceWholeWord("@DepartmentId", "@1::integer");
            query = query.ReplaceWholeWord("@OfficeId", "@2::integer");
            query = query.ReplaceWholeWord("@UserName", "@3::text");
            query = query.ReplaceWholeWord("@Password", "@4::text");
            query = query.ReplaceWholeWord("@FullName", "@5::text");
            query = query.ReplaceWholeWord("@Elevated", "@6::boolean");


            List<object> parameters = new List<object>();
            parameters.Add(this.RoleId);
            parameters.Add(this.DepartmentId);
            parameters.Add(this.OfficeId);
            parameters.Add(this.UserName);
            parameters.Add(this.Password);
            parameters.Add(this.FullName);
            parameters.Add(this.Elevated);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}