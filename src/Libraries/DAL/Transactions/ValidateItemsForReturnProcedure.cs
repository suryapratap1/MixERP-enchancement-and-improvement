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
    /// Prepares, validates, and executes the function "transactions.validate_items_for_return(_transaction_master_id bigint, _details transactions.stock_detail_type[])" on the database.
    /// </summary>
    public class ValidateItemsForReturnProcedure : DbAccess, IValidateItemsForReturnRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "validate_items_for_return";
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
        /// Maps to "_transaction_master_id" argument of the function "transactions.validate_items_for_return".
        /// </summary>
        public long TransactionMasterId { get; set; }
        /// <summary>
        /// Maps to "_details" argument of the function "transactions.validate_items_for_return".
        /// </summary>
        public MixERP.Net.Entities.Transactions.StockDetailType[] Details { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.validate_items_for_return(_transaction_master_id bigint, _details transactions.stock_detail_type[])" on the database.
        /// </summary>
        public ValidateItemsForReturnProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.validate_items_for_return(_transaction_master_id bigint, _details transactions.stock_detail_type[])" on the database.
        /// </summary>
        /// <param name="transactionMasterId">Enter argument value for "_transaction_master_id" parameter of the function "transactions.validate_items_for_return".</param>
        /// <param name="details">Enter argument value for "_details" parameter of the function "transactions.validate_items_for_return".</param>
        public ValidateItemsForReturnProcedure(long transactionMasterId, MixERP.Net.Entities.Transactions.StockDetailType[] details)
        {
            this.TransactionMasterId = transactionMasterId;
            this.Details = details;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.validate_items_for_return".
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
                    Log.Information("Access to the function \"ValidateItemsForReturnProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.validate_items_for_return(@TransactionMasterId, @Details);";

            query = query.ReplaceWholeWord("@TransactionMasterId", "@0::bigint");

            int detailsOffset = 1;
            query = query.ReplaceWholeWord("@Details", "ARRAY[" + this.SqlForDetails(this.Details, detailsOffset, 9) + "]");


            List<object> parameters = new List<object>();
            parameters.Add(this.TransactionMasterId);
            parameters.AddRange(this.ParamsForDetails(this.Details));

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }

        private string SqlForDetails(MixERP.Net.Entities.Transactions.StockDetailType[] details, int offset, int memberCount)
        {
            if (details == null)
            {
                return "NULL::transactions.stock_detail_type";
            }
            List<string> parameters = new List<string>();
            for (int i = 0; i < details.Count(); i++)
            {
                List<string> args = new List<string>();
                for (int j = 0; j < memberCount; j++)
                {
                    args.Add("@" + offset);
                    offset++;
                }

                string parameter = "ROW({0})::transactions.stock_detail_type";
                parameter = string.Format(System.Globalization.CultureInfo.InvariantCulture, parameter,
                    string.Join(",", args));
                parameters.Add(parameter);
            }
            return string.Join(",", parameters);
        }

        private List<object> ParamsForDetails(MixERP.Net.Entities.Transactions.StockDetailType[] details)
        {
            List<object> collection = new List<object>();

            if (details != null && details.Count() > 0)
            {
                foreach (MixERP.Net.Entities.Transactions.StockDetailType detail in details)
                {
                    collection.Add(detail.StoreId);
                    collection.Add(detail.ItemCode);
                    collection.Add(detail.Quantity);
                    collection.Add(detail.UnitName);
                    collection.Add(detail.Price);
                    collection.Add(detail.Discount);
                    collection.Add(detail.ShippingCharge);
                    collection.Add(detail.TaxForm);
                    collection.Add(detail.Tax);
                    collection.Add(detail);
                }
            }
            return collection;
        }
    }
}