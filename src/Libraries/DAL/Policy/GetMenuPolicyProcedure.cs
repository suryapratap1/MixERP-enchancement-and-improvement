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
    /// Prepares, validates, and executes the function "policy.get_menu_policy(_user_id integer, _office_id integer, _culture text)" on the database.
    /// </summary>
    public class GetMenuPolicyProcedure : DbAccess, IGetMenuPolicyRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "policy";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_menu_policy";
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
        /// Maps to "_user_id" argument of the function "policy.get_menu_policy".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "policy.get_menu_policy".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_culture" argument of the function "policy.get_menu_policy".
        /// </summary>
        public string Culture { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.get_menu_policy(_user_id integer, _office_id integer, _culture text)" on the database.
        /// </summary>
        public GetMenuPolicyProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.get_menu_policy(_user_id integer, _office_id integer, _culture text)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "policy.get_menu_policy".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "policy.get_menu_policy".</param>
        /// <param name="culture">Enter argument value for "_culture" parameter of the function "policy.get_menu_policy".</param>
        public GetMenuPolicyProcedure(int userId, int officeId, string culture)
        {
            this.UserId = userId;
            this.OfficeId = officeId;
            this.Culture = culture;
        }
        /// <summary>
        /// Prepares and executes the function "policy.get_menu_policy".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetMenuPolicyResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetMenuPolicyProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM policy.get_menu_policy(@UserId, @OfficeId, @Culture);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@OfficeId", "@1::integer");
            query = query.ReplaceWholeWord("@Culture", "@2::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.OfficeId);
            parameters.Add(this.Culture);

            return Factory.Get<DbGetMenuPolicyResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}