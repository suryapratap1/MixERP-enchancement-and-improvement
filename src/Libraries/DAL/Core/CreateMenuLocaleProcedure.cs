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
    /// Prepares, validates, and executes the function "core.create_menu_locale(_menu_id integer, _culture text, _menu_text text)" on the database.
    /// </summary>
    public class CreateMenuLocaleProcedure : DbAccess, ICreateMenuLocaleRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_menu_locale";
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
        /// Maps to "_menu_id" argument of the function "core.create_menu_locale".
        /// </summary>
        public int MenuId { get; set; }
        /// <summary>
        /// Maps to "_culture" argument of the function "core.create_menu_locale".
        /// </summary>
        public string Culture { get; set; }
        /// <summary>
        /// Maps to "_menu_text" argument of the function "core.create_menu_locale".
        /// </summary>
        public string MenuText { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_menu_locale(_menu_id integer, _culture text, _menu_text text)" on the database.
        /// </summary>
        public CreateMenuLocaleProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_menu_locale(_menu_id integer, _culture text, _menu_text text)" on the database.
        /// </summary>
        /// <param name="menuId">Enter argument value for "_menu_id" parameter of the function "core.create_menu_locale".</param>
        /// <param name="culture">Enter argument value for "_culture" parameter of the function "core.create_menu_locale".</param>
        /// <param name="menuText">Enter argument value for "_menu_text" parameter of the function "core.create_menu_locale".</param>
        public CreateMenuLocaleProcedure(int menuId, string culture, string menuText)
        {
            this.MenuId = menuId;
            this.Culture = culture;
            this.MenuText = menuText;
        }
        /// <summary>
        /// Prepares and executes the function "core.create_menu_locale".
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
                    Log.Information("Access to the function \"CreateMenuLocaleProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.create_menu_locale(@MenuId, @Culture, @MenuText);";

            query = query.ReplaceWholeWord("@MenuId", "@0::integer");
            query = query.ReplaceWholeWord("@Culture", "@1::text");
            query = query.ReplaceWholeWord("@MenuText", "@2::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.MenuId);
            parameters.Add(this.Culture);
            parameters.Add(this.MenuText);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}