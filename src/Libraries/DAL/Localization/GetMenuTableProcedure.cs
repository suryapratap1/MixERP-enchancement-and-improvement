// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Localization;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Localization.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "localization.get_menu_table(_culture_code text)" on the database.
    /// </summary>
    public class GetMenuTableProcedure : DbAccess, IGetMenuTableRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "localization";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_menu_table";
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
        /// Maps to "_culture_code" argument of the function "localization.get_menu_table".
        /// </summary>
        public string CultureCode { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.get_menu_table(_culture_code text)" on the database.
        /// </summary>
        public GetMenuTableProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.get_menu_table(_culture_code text)" on the database.
        /// </summary>
        /// <param name="cultureCode">Enter argument value for "_culture_code" parameter of the function "localization.get_menu_table".</param>
        public GetMenuTableProcedure(string cultureCode)
        {
            this.CultureCode = cultureCode;
        }
        /// <summary>
        /// Prepares and executes the function "localization.get_menu_table".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetMenuTableResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetMenuTableProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM localization.get_menu_table(@CultureCode);";

            query = query.ReplaceWholeWord("@CultureCode", "@0::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.CultureCode);

            return Factory.Get<DbGetMenuTableResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}