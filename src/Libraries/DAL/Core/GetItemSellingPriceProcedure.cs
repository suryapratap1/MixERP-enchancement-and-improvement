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
    /// Prepares, validates, and executes the function "core.get_item_selling_price(item_id_ integer, party_type_id_ integer, price_type_id_ integer, unit_id_ integer)" on the database.
    /// </summary>
    public class GetItemSellingPriceProcedure : DbAccess, IGetItemSellingPriceRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_item_selling_price";
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
        /// Maps to "item_id_" argument of the function "core.get_item_selling_price".
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Maps to "party_type_id_" argument of the function "core.get_item_selling_price".
        /// </summary>
        public int PartyTypeId { get; set; }
        /// <summary>
        /// Maps to "price_type_id_" argument of the function "core.get_item_selling_price".
        /// </summary>
        public int PriceTypeId { get; set; }
        /// <summary>
        /// Maps to "unit_id_" argument of the function "core.get_item_selling_price".
        /// </summary>
        public int UnitId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_item_selling_price(item_id_ integer, party_type_id_ integer, price_type_id_ integer, unit_id_ integer)" on the database.
        /// </summary>
        public GetItemSellingPriceProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_item_selling_price(item_id_ integer, party_type_id_ integer, price_type_id_ integer, unit_id_ integer)" on the database.
        /// </summary>
        /// <param name="itemId">Enter argument value for "item_id_" parameter of the function "core.get_item_selling_price".</param>
        /// <param name="partyTypeId">Enter argument value for "party_type_id_" parameter of the function "core.get_item_selling_price".</param>
        /// <param name="priceTypeId">Enter argument value for "price_type_id_" parameter of the function "core.get_item_selling_price".</param>
        /// <param name="unitId">Enter argument value for "unit_id_" parameter of the function "core.get_item_selling_price".</param>
        public GetItemSellingPriceProcedure(int itemId, int partyTypeId, int priceTypeId, int unitId)
        {
            this.ItemId = itemId;
            this.PartyTypeId = partyTypeId;
            this.PriceTypeId = priceTypeId;
            this.UnitId = unitId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_item_selling_price".
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
                    Log.Information("Access to the function \"GetItemSellingPriceProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_item_selling_price(@ItemId, @PartyTypeId, @PriceTypeId, @UnitId);";

            query = query.ReplaceWholeWord("@ItemId", "@0::integer");
            query = query.ReplaceWholeWord("@PartyTypeId", "@1::integer");
            query = query.ReplaceWholeWord("@PriceTypeId", "@2::integer");
            query = query.ReplaceWholeWord("@UnitId", "@3::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.ItemId);
            parameters.Add(this.PartyTypeId);
            parameters.Add(this.PriceTypeId);
            parameters.Add(this.UnitId);

            return Factory.Get<decimal>(this._Catalog, query, parameters.ToArray()).FirstOrDefault();
        }


    }
}