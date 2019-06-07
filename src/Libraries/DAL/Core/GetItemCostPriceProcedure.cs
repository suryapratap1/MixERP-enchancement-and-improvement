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
    /// Prepares, validates, and executes the function "core.get_item_cost_price(item_id_ integer, unit_id_ integer, party_id_ bigint)" on the database.
    /// </summary>
    public class GetItemCostPriceProcedure : DbAccess, IGetItemCostPriceRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_item_cost_price";
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
        /// Maps to "item_id_" argument of the function "core.get_item_cost_price".
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Maps to "unit_id_" argument of the function "core.get_item_cost_price".
        /// </summary>
        public int UnitId { get; set; }
        /// <summary>
        /// Maps to "party_id_" argument of the function "core.get_item_cost_price".
        /// </summary>
        public long PartyId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_item_cost_price(item_id_ integer, unit_id_ integer, party_id_ bigint)" on the database.
        /// </summary>
        public GetItemCostPriceProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_item_cost_price(item_id_ integer, unit_id_ integer, party_id_ bigint)" on the database.
        /// </summary>
        /// <param name="itemId">Enter argument value for "item_id_" parameter of the function "core.get_item_cost_price".</param>
        /// <param name="unitId">Enter argument value for "unit_id_" parameter of the function "core.get_item_cost_price".</param>
        /// <param name="partyId">Enter argument value for "party_id_" parameter of the function "core.get_item_cost_price".</param>
        public GetItemCostPriceProcedure(int itemId, int unitId, long partyId)
        {
            this.ItemId = itemId;
            this.UnitId = unitId;
            this.PartyId = partyId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_item_cost_price".
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
                    Log.Information("Access to the function \"GetItemCostPriceProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_item_cost_price(@ItemId, @UnitId, @PartyId);";

            query = query.ReplaceWholeWord("@ItemId", "@0::integer");
            query = query.ReplaceWholeWord("@UnitId", "@1::integer");
            query = query.ReplaceWholeWord("@PartyId", "@2::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.ItemId);
            parameters.Add(this.UnitId);
            parameters.Add(this.PartyId);

            return Factory.Get<decimal>(this._Catalog, query, parameters.ToArray()).FirstOrDefault();
        }


    }
}