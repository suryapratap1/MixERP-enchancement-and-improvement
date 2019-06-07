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
    /// Prepares, validates, and executes the function "transactions.are_sales_orders_already_merged(arr bigint[])" on the database.
    /// </summary>
    public class AreSalesOrdersAlreadyMergedProcedure : DbAccess, IAreSalesOrdersAlreadyMergedRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "are_sales_orders_already_merged";
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
        /// Maps to "arr" argument of the function "transactions.are_sales_orders_already_merged".
        /// </summary>
        public long[] Arr { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.are_sales_orders_already_merged(arr bigint[])" on the database.
        /// </summary>
        public AreSalesOrdersAlreadyMergedProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.are_sales_orders_already_merged(arr bigint[])" on the database.
        /// </summary>
        /// <param name="arr">Enter argument value for "arr" parameter of the function "transactions.are_sales_orders_already_merged".</param>
        public AreSalesOrdersAlreadyMergedProcedure(long[] arr)
        {
            this.Arr = arr;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.are_sales_orders_already_merged".
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
                    Log.Information("Access to the function \"AreSalesOrdersAlreadyMergedProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.are_sales_orders_already_merged(@Arr);";


            int arrOffset = 0;
            query = query.ReplaceWholeWord("@Arr", "ARRAY[" + this.SqlForArr(this.Arr, arrOffset, 1) + "]");


            List<object> parameters = new List<object>();
            parameters.AddRange(this.ParamsForArr(this.Arr));

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }

        private string SqlForArr(long[] arrs, int offset, int memberCount)
        {
            if (arrs == null)
            {
                return "NULL::bigint";
            }
            List<string> parameters = new List<string>();
            for (int i = 0; i < arrs.Count(); i++)
            {
                List<string> args = new List<string>();
                args.Add("@" + offset);
                offset++;
                string parameter = "{0}::bigint";
                parameter = string.Format(System.Globalization.CultureInfo.InvariantCulture, parameter,
                    string.Join(",", args));
                parameters.Add(parameter);
            }
            return string.Join(",", parameters);
        }

        private List<object> ParamsForArr(long[] arrs)
        {
            List<object> collection = new List<object>();

            if (arrs != null && arrs.Count() > 0)
            {
                foreach (long arr in arrs)
                {
                    collection.Add(arr);
                }
            }
            return collection;
        }
    }
}