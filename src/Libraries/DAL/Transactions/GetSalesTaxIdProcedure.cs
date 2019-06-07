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
    /// Prepares, validates, and executes the function "transactions.get_sales_tax_id(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _unit_id integer, _price money_strict)" on the database.
    /// </summary>
    public class GetSalesTaxIdProcedure : DbAccess, IGetSalesTaxIdRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_sales_tax_id";
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
        /// Maps to "_tran_book" argument of the function "transactions.get_sales_tax_id".
        /// </summary>
        public string TranBook { get; set; }
        /// <summary>
        /// Maps to "_store_id" argument of the function "transactions.get_sales_tax_id".
        /// </summary>
        public int StoreId { get; set; }
        /// <summary>
        /// Maps to "_party_code" argument of the function "transactions.get_sales_tax_id".
        /// </summary>
        public string PartyCode { get; set; }
        /// <summary>
        /// Maps to "_shipping_address_code" argument of the function "transactions.get_sales_tax_id".
        /// </summary>
        public string ShippingAddressCode { get; set; }
        /// <summary>
        /// Maps to "_price_type_id" argument of the function "transactions.get_sales_tax_id".
        /// </summary>
        public int PriceTypeId { get; set; }
        /// <summary>
        /// Maps to "_item_code" argument of the function "transactions.get_sales_tax_id".
        /// </summary>
        public string ItemCode { get; set; }
        /// <summary>
        /// Maps to "_unit_id" argument of the function "transactions.get_sales_tax_id".
        /// </summary>
        public int UnitId { get; set; }
        /// <summary>
        /// Maps to "_price" argument of the function "transactions.get_sales_tax_id".
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_sales_tax_id(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _unit_id integer, _price money_strict)" on the database.
        /// </summary>
        public GetSalesTaxIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_sales_tax_id(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _unit_id integer, _price money_strict)" on the database.
        /// </summary>
        /// <param name="tranBook">Enter argument value for "_tran_book" parameter of the function "transactions.get_sales_tax_id".</param>
        /// <param name="storeId">Enter argument value for "_store_id" parameter of the function "transactions.get_sales_tax_id".</param>
        /// <param name="partyCode">Enter argument value for "_party_code" parameter of the function "transactions.get_sales_tax_id".</param>
        /// <param name="shippingAddressCode">Enter argument value for "_shipping_address_code" parameter of the function "transactions.get_sales_tax_id".</param>
        /// <param name="priceTypeId">Enter argument value for "_price_type_id" parameter of the function "transactions.get_sales_tax_id".</param>
        /// <param name="itemCode">Enter argument value for "_item_code" parameter of the function "transactions.get_sales_tax_id".</param>
        /// <param name="unitId">Enter argument value for "_unit_id" parameter of the function "transactions.get_sales_tax_id".</param>
        /// <param name="price">Enter argument value for "_price" parameter of the function "transactions.get_sales_tax_id".</param>
        public GetSalesTaxIdProcedure(string tranBook, int storeId, string partyCode, string shippingAddressCode, int priceTypeId, string itemCode, int unitId, decimal price)
        {
            this.TranBook = tranBook;
            this.StoreId = storeId;
            this.PartyCode = partyCode;
            this.ShippingAddressCode = shippingAddressCode;
            this.PriceTypeId = priceTypeId;
            this.ItemCode = itemCode;
            this.UnitId = unitId;
            this.Price = price;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_sales_tax_id".
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
                    Log.Information("Access to the function \"GetSalesTaxIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_sales_tax_id(@TranBook, @StoreId, @PartyCode, @ShippingAddressCode, @PriceTypeId, @ItemCode, @UnitId, @Price);";

            query = query.ReplaceWholeWord("@TranBook", "@0::character varying");
            query = query.ReplaceWholeWord("@StoreId", "@1::integer");
            query = query.ReplaceWholeWord("@PartyCode", "@2::character varying");
            query = query.ReplaceWholeWord("@ShippingAddressCode", "@3::character varying");
            query = query.ReplaceWholeWord("@PriceTypeId", "@4::integer");
            query = query.ReplaceWholeWord("@ItemCode", "@5::character varying");
            query = query.ReplaceWholeWord("@UnitId", "@6::integer");
            query = query.ReplaceWholeWord("@Price", "@7::money_strict");


            List<object> parameters = new List<object>();
            parameters.Add(this.TranBook);
            parameters.Add(this.StoreId);
            parameters.Add(this.PartyCode);
            parameters.Add(this.ShippingAddressCode);
            parameters.Add(this.PriceTypeId);
            parameters.Add(this.ItemCode);
            parameters.Add(this.UnitId);
            parameters.Add(this.Price);

            return Factory.Scalar<int>(this._Catalog, query, parameters.ToArray());
        }


    }
}