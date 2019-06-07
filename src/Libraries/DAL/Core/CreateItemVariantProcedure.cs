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
    /// Prepares, validates, and executes the function "core.create_item_variant(_variant_of integer, _item_id integer, _item_code character varying, _item_name character varying, _variant_ids integer[], _user_id integer)" on the database.
    /// </summary>
    public class CreateItemVariantProcedure : DbAccess, ICreateItemVariantRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_item_variant";
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
        /// Maps to "_variant_of" argument of the function "core.create_item_variant".
        /// </summary>
        public int VariantOf { get; set; }
        /// <summary>
        /// Maps to "_item_id" argument of the function "core.create_item_variant".
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Maps to "_item_code" argument of the function "core.create_item_variant".
        /// </summary>
        public string ItemCode { get; set; }
        /// <summary>
        /// Maps to "_item_name" argument of the function "core.create_item_variant".
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// Maps to "_variant_ids" argument of the function "core.create_item_variant".
        /// </summary>
        public int[] VariantIds { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "core.create_item_variant".
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_item_variant(_variant_of integer, _item_id integer, _item_code character varying, _item_name character varying, _variant_ids integer[], _user_id integer)" on the database.
        /// </summary>
        public CreateItemVariantProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_item_variant(_variant_of integer, _item_id integer, _item_code character varying, _item_name character varying, _variant_ids integer[], _user_id integer)" on the database.
        /// </summary>
        /// <param name="variantOf">Enter argument value for "_variant_of" parameter of the function "core.create_item_variant".</param>
        /// <param name="itemId">Enter argument value for "_item_id" parameter of the function "core.create_item_variant".</param>
        /// <param name="itemCode">Enter argument value for "_item_code" parameter of the function "core.create_item_variant".</param>
        /// <param name="itemName">Enter argument value for "_item_name" parameter of the function "core.create_item_variant".</param>
        /// <param name="variantIds">Enter argument value for "_variant_ids" parameter of the function "core.create_item_variant".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "core.create_item_variant".</param>
        public CreateItemVariantProcedure(int variantOf, int itemId, string itemCode, string itemName, int[] variantIds, int userId)
        {
            this.VariantOf = variantOf;
            this.ItemId = itemId;
            this.ItemCode = itemCode;
            this.ItemName = itemName;
            this.VariantIds = variantIds;
            this.UserId = userId;
        }
        /// <summary>
        /// Prepares and executes the function "core.create_item_variant".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public int Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"CreateItemVariantProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.create_item_variant(@VariantOf, @ItemId, @ItemCode, @ItemName, @VariantIds, @UserId);";

            query = query.ReplaceWholeWord("@VariantOf", "@0::integer");
            query = query.ReplaceWholeWord("@ItemId", "@1::integer");
            query = query.ReplaceWholeWord("@ItemCode", "@2::character varying");
            query = query.ReplaceWholeWord("@ItemName", "@3::character varying");

            int variantIdsOffset = 4;
            query = query.ReplaceWholeWord("@VariantIds", "ARRAY[" + this.SqlForVariantIds(this.VariantIds, variantIdsOffset, 1) + "]");

            int offset = variantIdsOffset + (this.VariantIds == null ? 0 : this.VariantIds.Count() * 1)/*The object VariantIds has 1 member(s).*/;
            query = query.ReplaceWholeWord("@UserId", "@" + offset + "::integer");

            offset++;


            List<object> parameters = new List<object>();
            parameters.Add(this.VariantOf);
            parameters.Add(this.ItemId);
            parameters.Add(this.ItemCode);
            parameters.Add(this.ItemName);
            parameters.AddRange(this.ParamsForVariantIds(this.VariantIds));
            parameters.Add(this.UserId);

            return Factory.Scalar<int>(this._Catalog, query, parameters.ToArray());
        }

        private string SqlForVariantIds(int[] variantIds, int offset, int memberCount)
        {
            if (variantIds == null)
            {
                return "NULL::integer";
            }
            List<string> parameters = new List<string>();
            for (int i = 0; i < variantIds.Count(); i++)
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

        private List<object> ParamsForVariantIds(int[] variantIds)
        {
            List<object> collection = new List<object>();

            if (variantIds != null && variantIds.Count() > 0)
            {
                foreach (int variantId in variantIds)
                {
                    collection.Add(variantId);
                }
            }
            return collection;
        }
    }
}