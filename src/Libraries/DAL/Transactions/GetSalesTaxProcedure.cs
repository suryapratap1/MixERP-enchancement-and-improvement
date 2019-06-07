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
    /// Prepares, validates, and executes the function "transactions.get_sales_tax(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _price money_strict2, _quantity integer_strict2, _discount money_strict2, _shipping_charge money_strict2, _sales_tax_id integer)" on the database.
    /// </summary>
    public class GetSalesTaxProcedure : DbAccess, IGetSalesTaxRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_sales_tax";
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
        /// Maps to "_tran_book" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public string TranBook { get; set; }
        /// <summary>
        /// Maps to "_store_id" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public int StoreId { get; set; }
        /// <summary>
        /// Maps to "_party_code" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public string PartyCode { get; set; }
        /// <summary>
        /// Maps to "_shipping_address_code" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public string ShippingAddressCode { get; set; }
        /// <summary>
        /// Maps to "_price_type_id" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public int PriceTypeId { get; set; }
        /// <summary>
        /// Maps to "_item_code" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public string ItemCode { get; set; }
        /// <summary>
        /// Maps to "_price" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Maps to "_quantity" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Maps to "_discount" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public decimal Discount { get; set; }
        /// <summary>
        /// Maps to "_shipping_charge" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public decimal ShippingCharge { get; set; }
        /// <summary>
        /// Maps to "_sales_tax_id" argument of the function "transactions.get_sales_tax".
        /// </summary>
        public int SalesTaxId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_sales_tax(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _price money_strict2, _quantity integer_strict2, _discount money_strict2, _shipping_charge money_strict2, _sales_tax_id integer)" on the database.
        /// </summary>
        public GetSalesTaxProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_sales_tax(_tran_book character varying, _store_id integer, _party_code character varying, _shipping_address_code character varying, _price_type_id integer, _item_code character varying, _price money_strict2, _quantity integer_strict2, _discount money_strict2, _shipping_charge money_strict2, _sales_tax_id integer)" on the database.
        /// </summary>
        /// <param name="tranBook">Enter argument value for "_tran_book" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="storeId">Enter argument value for "_store_id" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="partyCode">Enter argument value for "_party_code" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="shippingAddressCode">Enter argument value for "_shipping_address_code" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="priceTypeId">Enter argument value for "_price_type_id" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="itemCode">Enter argument value for "_item_code" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="price">Enter argument value for "_price" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="quantity">Enter argument value for "_quantity" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="discount">Enter argument value for "_discount" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="shippingCharge">Enter argument value for "_shipping_charge" parameter of the function "transactions.get_sales_tax".</param>
        /// <param name="salesTaxId">Enter argument value for "_sales_tax_id" parameter of the function "transactions.get_sales_tax".</param>
        public GetSalesTaxProcedure(string tranBook, int storeId, string partyCode, string shippingAddressCode, int priceTypeId, string itemCode, decimal price, int quantity, decimal discount, decimal shippingCharge, int salesTaxId)
        {
            this.TranBook = tranBook;
            this.StoreId = storeId;
            this.PartyCode = partyCode;
            this.ShippingAddressCode = shippingAddressCode;
            this.PriceTypeId = priceTypeId;
            this.ItemCode = itemCode;
            this.Price = price;
            this.Quantity = quantity;
            this.Discount = discount;
            this.ShippingCharge = shippingCharge;
            this.SalesTaxId = salesTaxId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_sales_tax".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetSalesTaxResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetSalesTaxProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_sales_tax(@TranBook, @StoreId, @PartyCode, @ShippingAddressCode, @PriceTypeId, @ItemCode, @Price, @Quantity, @Discount, @ShippingCharge, @SalesTaxId);";

            query = query.ReplaceWholeWord("@TranBook", "@0::character varying");
            query = query.ReplaceWholeWord("@StoreId", "@1::integer");
            query = query.ReplaceWholeWord("@PartyCode", "@2::character varying");
            query = query.ReplaceWholeWord("@ShippingAddressCode", "@3::character varying");
            query = query.ReplaceWholeWord("@PriceTypeId", "@4::integer");
            query = query.ReplaceWholeWord("@ItemCode", "@5::character varying");
            query = query.ReplaceWholeWord("@Price", "@6::money_strict2");
            query = query.ReplaceWholeWord("@Quantity", "@7::integer_strict2");
            query = query.ReplaceWholeWord("@Discount", "@8::money_strict2");
            query = query.ReplaceWholeWord("@ShippingCharge", "@9::money_strict2");
            query = query.ReplaceWholeWord("@SalesTaxId", "@10::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.TranBook);
            parameters.Add(this.StoreId);
            parameters.Add(this.PartyCode);
            parameters.Add(this.ShippingAddressCode);
            parameters.Add(this.PriceTypeId);
            parameters.Add(this.ItemCode);
            parameters.Add(this.Price);
            parameters.Add(this.Quantity);
            parameters.Add(this.Discount);
            parameters.Add(this.ShippingCharge);
            parameters.Add(this.SalesTaxId);

            return Factory.Get<DbGetSalesTaxResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}