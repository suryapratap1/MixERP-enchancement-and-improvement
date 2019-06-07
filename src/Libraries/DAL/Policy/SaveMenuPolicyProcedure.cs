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
    /// Prepares, validates, and executes the function "policy.save_menu_policy(_user_id integer, _office_id integer, _menu_ids integer[])" on the database.
    /// </summary>
    public class SaveMenuPolicyProcedure : DbAccess, ISaveMenuPolicyRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "policy";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "save_menu_policy";
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
        /// Maps to "_user_id" argument of the function "policy.save_menu_policy".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "policy.save_menu_policy".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_menu_ids" argument of the function "policy.save_menu_policy".
        /// </summary>
        public int[] MenuIds { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.save_menu_policy(_user_id integer, _office_id integer, _menu_ids integer[])" on the database.
        /// </summary>
        public SaveMenuPolicyProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "policy.save_menu_policy(_user_id integer, _office_id integer, _menu_ids integer[])" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "policy.save_menu_policy".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "policy.save_menu_policy".</param>
        /// <param name="menuIds">Enter argument value for "_menu_ids" parameter of the function "policy.save_menu_policy".</param>
        public SaveMenuPolicyProcedure(int userId, int officeId, int[] menuIds)
        {
            this.UserId = userId;
            this.OfficeId = officeId;
            this.MenuIds = menuIds;
        }
        /// <summary>
        /// Prepares and executes the function "policy.save_menu_policy".
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
                    Log.Information("Access to the function \"SaveMenuPolicyProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM policy.save_menu_policy(@UserId, @OfficeId, @MenuIds);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@OfficeId", "@1::integer");

            int menuIdsOffset = 2;
            query = query.ReplaceWholeWord("@MenuIds", "ARRAY[" + this.SqlForMenuIds(this.MenuIds, menuIdsOffset, 1) + "]");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.OfficeId);
            parameters.AddRange(this.ParamsForMenuIds(this.MenuIds));

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }

        private string SqlForMenuIds(int[] menuIds, int offset, int memberCount)
        {
            if (menuIds == null)
            {
                return "NULL::integer";
            }
            List<string> parameters = new List<string>();
            for (int i = 0; i < menuIds.Count(); i++)
            {
                List<string> args = new List<string>();
                args.Add("@" + offset);
                offset++;
                string parameter = "{0}::integer";
                parameter = string.Format(System.Globalization.CultureInfo.InvariantCulture, parameter,
                    string.Join(",", args));
                parameters.Add(parameter);
            }
            return string.Join(",", parameters);
        }

        private List<object> ParamsForMenuIds(int[] menuIds)
        {
            List<object> collection = new List<object>();

            if (menuIds != null && menuIds.Count() > 0)
            {
                foreach (int menuId in menuIds)
                {
                    collection.Add(menuId);
                }
            }
            return collection;
        }
    }
}