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
    /// Prepares, validates, and executes the function "transactions.post_inventory_transfer_request(_office_id integer, _user_id integer, _login_id bigint, _value_date date, _reference_number character varying, _statement_reference text, _details transactions.stock_adjustment_type[])" on the database.
    /// </summary>
    public class PostInventoryTransferRequestProcedure : DbAccess, IPostInventoryTransferRequestRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "post_inventory_transfer_request";
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
        /// Maps to "_office_id" argument of the function "transactions.post_inventory_transfer_request".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "transactions.post_inventory_transfer_request".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_login_id" argument of the function "transactions.post_inventory_transfer_request".
        /// </summary>
        public long LoginId { get; set; }
        /// <summary>
        /// Maps to "_value_date" argument of the function "transactions.post_inventory_transfer_request".
        /// </summary>
        public DateTime ValueDate { get; set; }
        /// <summary>
        /// Maps to "_reference_number" argument of the function "transactions.post_inventory_transfer_request".
        /// </summary>
        public string ReferenceNumber { get; set; }
        /// <summary>
        /// Maps to "_statement_reference" argument of the function "transactions.post_inventory_transfer_request".
        /// </summary>
        public string StatementReference { get; set; }
        /// <summary>
        /// Maps to "_details" argument of the function "transactions.post_inventory_transfer_request".
        /// </summary>
        public MixERP.Net.Entities.Transactions.StockAdjustmentType[] Details { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.post_inventory_transfer_request(_office_id integer, _user_id integer, _login_id bigint, _value_date date, _reference_number character varying, _statement_reference text, _details transactions.stock_adjustment_type[])" on the database.
        /// </summary>
        public PostInventoryTransferRequestProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.post_inventory_transfer_request(_office_id integer, _user_id integer, _login_id bigint, _value_date date, _reference_number character varying, _statement_reference text, _details transactions.stock_adjustment_type[])" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.post_inventory_transfer_request".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.post_inventory_transfer_request".</param>
        /// <param name="loginId">Enter argument value for "_login_id" parameter of the function "transactions.post_inventory_transfer_request".</param>
        /// <param name="valueDate">Enter argument value for "_value_date" parameter of the function "transactions.post_inventory_transfer_request".</param>
        /// <param name="referenceNumber">Enter argument value for "_reference_number" parameter of the function "transactions.post_inventory_transfer_request".</param>
        /// <param name="statementReference">Enter argument value for "_statement_reference" parameter of the function "transactions.post_inventory_transfer_request".</param>
        /// <param name="details">Enter argument value for "_details" parameter of the function "transactions.post_inventory_transfer_request".</param>
        public PostInventoryTransferRequestProcedure(int officeId, int userId, long loginId, DateTime valueDate, string referenceNumber, string statementReference, MixERP.Net.Entities.Transactions.StockAdjustmentType[] details)
        {
            this.OfficeId = officeId;
            this.UserId = userId;
            this.LoginId = loginId;
            this.ValueDate = valueDate;
            this.ReferenceNumber = referenceNumber;
            this.StatementReference = statementReference;
            this.Details = details;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.post_inventory_transfer_request".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public long Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"PostInventoryTransferRequestProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.post_inventory_transfer_request(@OfficeId, @UserId, @LoginId, @ValueDate, @ReferenceNumber, @StatementReference, @Details);";

            query = query.ReplaceWholeWord("@OfficeId", "@0::integer");
            query = query.ReplaceWholeWord("@UserId", "@1::integer");
            query = query.ReplaceWholeWord("@LoginId", "@2::bigint");
            query = query.ReplaceWholeWord("@ValueDate", "@3::date");
            query = query.ReplaceWholeWord("@ReferenceNumber", "@4::character varying");
            query = query.ReplaceWholeWord("@StatementReference", "@5::text");

            int detailsOffset = 6;
            query = query.ReplaceWholeWord("@Details", "ARRAY[" + this.SqlForDetails(this.Details, detailsOffset, 5) + "]");


            List<object> parameters = new List<object>();
            parameters.Add(this.OfficeId);
            parameters.Add(this.UserId);
            parameters.Add(this.LoginId);
            parameters.Add(this.ValueDate);
            parameters.Add(this.ReferenceNumber);
            parameters.Add(this.StatementReference);
            parameters.AddRange(this.ParamsForDetails(this.Details));

            return Factory.Scalar<long>(this._Catalog, query, parameters.ToArray());
        }

        private string SqlForDetails(MixERP.Net.Entities.Transactions.StockAdjustmentType[] details, int offset, int memberCount)
        {
            if (details == null)
            {
                return "NULL::transactions.stock_adjustment_type";
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

                string parameter = "ROW({0})::transactions.stock_adjustment_type";
                parameter = string.Format(System.Globalization.CultureInfo.InvariantCulture, parameter,
                    string.Join(",", args));
                parameters.Add(parameter);
            }
            return string.Join(",", parameters);
        }

        private List<object> ParamsForDetails(MixERP.Net.Entities.Transactions.StockAdjustmentType[] details)
        {
            List<object> collection = new List<object>();

            if (details != null && details.Count() > 0)
            {
                foreach (MixERP.Net.Entities.Transactions.StockAdjustmentType detail in details)
                {
                    collection.Add(detail.TranType);
                    collection.Add(detail.StoreName);
                    collection.Add(detail.ItemCode);
                    collection.Add(detail.UnitName);
                    collection.Add(detail.Quantity);
                    collection.Add(detail);
                }
            }
            return collection;
        }
    }
}