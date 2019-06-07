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
    /// Prepares, validates, and executes the function "transactions.get_mavcogs(_item_id integer, _store_id integer, _base_quantity numeric, _factor numeric)" on the database.
    /// </summary>
    public class GetMavcogsProcedure : DbAccess, IGetMavcogsRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_mavcogs";
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
        /// Maps to "_item_id" argument of the function "transactions.get_mavcogs".
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Maps to "_store_id" argument of the function "transactions.get_mavcogs".
        /// </summary>
        public int StoreId { get; set; }
        /// <summary>
        /// Maps to "_base_quantity" argument of the function "transactions.get_mavcogs".
        /// </summary>
        public decimal BaseQuantity { get; set; }
        /// <summary>
        /// Maps to "_factor" argument of the function "transactions.get_mavcogs".
        /// </summary>
        public decimal Factor { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_mavcogs(_item_id integer, _store_id integer, _base_quantity numeric, _factor numeric)" on the database.
        /// </summary>
        public GetMavcogsProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_mavcogs(_item_id integer, _store_id integer, _base_quantity numeric, _factor numeric)" on the database.
        /// </summary>
        /// <param name="itemId">Enter argument value for "_item_id" parameter of the function "transactions.get_mavcogs".</param>
        /// <param name="storeId">Enter argument value for "_store_id" parameter of the function "transactions.get_mavcogs".</param>
        /// <param name="baseQuantity">Enter argument value for "_base_quantity" parameter of the function "transactions.get_mavcogs".</param>
        /// <param name="factor">Enter argument value for "_factor" parameter of the function "transactions.get_mavcogs".</param>
        public GetMavcogsProcedure(int itemId, int storeId, decimal baseQuantity, decimal factor)
        {
            this.ItemId = itemId;
            this.StoreId = storeId;
            this.BaseQuantity = baseQuantity;
            this.Factor = factor;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_mavcogs".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public decimal Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetMavcogsProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_mavcogs(@ItemId, @StoreId, @BaseQuantity, @Factor);";

            query = query.ReplaceWholeWord("@ItemId", "@0::integer");
            query = query.ReplaceWholeWord("@StoreId", "@1::integer");
            query = query.ReplaceWholeWord("@BaseQuantity", "@2::numeric");
            query = query.ReplaceWholeWord("@Factor", "@3::numeric");


            List<object> parameters = new List<object>();
            parameters.Add(this.ItemId);
            parameters.Add(this.StoreId);
            parameters.Add(this.BaseQuantity);
            parameters.Add(this.Factor);

            return Factory.Scalar<decimal>(this._Catalog, query, parameters.ToArray());
        }


    }
}