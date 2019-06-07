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
    /// Prepares, validates, and executes the function "core.recreate_menu(_menu_text text, _url text, _menu_code text, _level integer, _parent_menu_id integer)" on the database.
    /// </summary>
    public class RecreateMenuProcedure : DbAccess, IRecreateMenuRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "recreate_menu";
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
        /// Maps to "_menu_text" argument of the function "core.recreate_menu".
        /// </summary>
        public string MenuText { get; set; }
        /// <summary>
        /// Maps to "_url" argument of the function "core.recreate_menu".
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Maps to "_menu_code" argument of the function "core.recreate_menu".
        /// </summary>
        public string MenuCode { get; set; }
        /// <summary>
        /// Maps to "_level" argument of the function "core.recreate_menu".
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// Maps to "_parent_menu_id" argument of the function "core.recreate_menu".
        /// </summary>
        public int ParentMenuId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.recreate_menu(_menu_text text, _url text, _menu_code text, _level integer, _parent_menu_id integer)" on the database.
        /// </summary>
        public RecreateMenuProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.recreate_menu(_menu_text text, _url text, _menu_code text, _level integer, _parent_menu_id integer)" on the database.
        /// </summary>
        /// <param name="menuText">Enter argument value for "_menu_text" parameter of the function "core.recreate_menu".</param>
        /// <param name="url">Enter argument value for "_url" parameter of the function "core.recreate_menu".</param>
        /// <param name="menuCode">Enter argument value for "_menu_code" parameter of the function "core.recreate_menu".</param>
        /// <param name="level">Enter argument value for "_level" parameter of the function "core.recreate_menu".</param>
        /// <param name="parentMenuId">Enter argument value for "_parent_menu_id" parameter of the function "core.recreate_menu".</param>
        public RecreateMenuProcedure(string menuText, string url, string menuCode, int level, int parentMenuId)
        {
            this.MenuText = menuText;
            this.Url = url;
            this.MenuCode = menuCode;
            this.Level = level;
            this.ParentMenuId = parentMenuId;
        }
        /// <summary>
        /// Prepares and executes the function "core.recreate_menu".
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
                    Log.Information("Access to the function \"RecreateMenuProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.recreate_menu(@MenuText, @Url, @MenuCode, @Level, @ParentMenuId);";

            query = query.ReplaceWholeWord("@MenuText", "@0::text");
            query = query.ReplaceWholeWord("@Url", "@1::text");
            query = query.ReplaceWholeWord("@MenuCode", "@2::text");
            query = query.ReplaceWholeWord("@Level", "@3::integer");
            query = query.ReplaceWholeWord("@ParentMenuId", "@4::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.MenuText);
            parameters.Add(this.Url);
            parameters.Add(this.MenuCode);
            parameters.Add(this.Level);
            parameters.Add(this.ParentMenuId);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}