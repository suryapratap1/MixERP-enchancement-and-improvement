// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "transactions.get_top_selling_products_of_all_time(top integer)" on the database.
    /// </summary>
    public class GetTopSellingProductsOfAllTimeProcedure : DbAccess, IGetTopSellingProductsOfAllTimeRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_top_selling_products_of_all_time";
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
        /// Maps to "top" argument of the function "transactions.get_top_selling_products_of_all_time".
        /// </summary>
        public int Top { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_top_selling_products_of_all_time(top integer)" on the database.
        /// </summary>
        public GetTopSellingProductsOfAllTimeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_top_selling_products_of_all_time(top integer)" on the database.
        /// </summary>
        /// <param name="top">Enter argument value for "top" parameter of the function "transactions.get_top_selling_products_of_all_time".</param>
        public GetTopSellingProductsOfAllTimeProcedure(int top)
        {
            this.Top = top;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_top_selling_products_of_all_time".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetTopSellingProductsOfAllTimeResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetTopSellingProductsOfAllTimeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_top_selling_products_of_all_time(@Top);";

            query = query.ReplaceWholeWord("@Top", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.Top);

            return Factory.Get<DbGetTopSellingProductsOfAllTimeResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}