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
    /// Prepares, validates, and executes the function "transactions.get_write_off_cost_of_goods_sold(_stock_master_id bigint, _item_id integer, _unit_id integer, _quantity integer)" on the database.
    /// </summary>
    public class GetWriteOffCostOfGoodsSoldProcedure : DbAccess, IGetWriteOffCostOfGoodsSoldRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_write_off_cost_of_goods_sold";
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
        /// Maps to "_stock_master_id" argument of the function "transactions.get_write_off_cost_of_goods_sold".
        /// </summary>
        public long StockMasterId { get; set; }
        /// <summary>
        /// Maps to "_item_id" argument of the function "transactions.get_write_off_cost_of_goods_sold".
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Maps to "_unit_id" argument of the function "transactions.get_write_off_cost_of_goods_sold".
        /// </summary>
        public int UnitId { get; set; }
        /// <summary>
        /// Maps to "_quantity" argument of the function "transactions.get_write_off_cost_of_goods_sold".
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_write_off_cost_of_goods_sold(_stock_master_id bigint, _item_id integer, _unit_id integer, _quantity integer)" on the database.
        /// </summary>
        public GetWriteOffCostOfGoodsSoldProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_write_off_cost_of_goods_sold(_stock_master_id bigint, _item_id integer, _unit_id integer, _quantity integer)" on the database.
        /// </summary>
        /// <param name="stockMasterId">Enter argument value for "_stock_master_id" parameter of the function "transactions.get_write_off_cost_of_goods_sold".</param>
        /// <param name="itemId">Enter argument value for "_item_id" parameter of the function "transactions.get_write_off_cost_of_goods_sold".</param>
        /// <param name="unitId">Enter argument value for "_unit_id" parameter of the function "transactions.get_write_off_cost_of_goods_sold".</param>
        /// <param name="quantity">Enter argument value for "_quantity" parameter of the function "transactions.get_write_off_cost_of_goods_sold".</param>
        public GetWriteOffCostOfGoodsSoldProcedure(long stockMasterId, int itemId, int unitId, int quantity)
        {
            this.StockMasterId = stockMasterId;
            this.ItemId = itemId;
            this.UnitId = unitId;
            this.Quantity = quantity;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_write_off_cost_of_goods_sold".
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
                    Log.Information("Access to the function \"GetWriteOffCostOfGoodsSoldProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_write_off_cost_of_goods_sold(@StockMasterId, @ItemId, @UnitId, @Quantity);";

            query = query.ReplaceWholeWord("@StockMasterId", "@0::bigint");
            query = query.ReplaceWholeWord("@ItemId", "@1::integer");
            query = query.ReplaceWholeWord("@UnitId", "@2::integer");
            query = query.ReplaceWholeWord("@Quantity", "@3::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.StockMasterId);
            parameters.Add(this.ItemId);
            parameters.Add(this.UnitId);
            parameters.Add(this.Quantity);

            return Factory.Get<decimal>(this._Catalog, query, parameters.ToArray()).FirstOrDefault();
        }


    }
}