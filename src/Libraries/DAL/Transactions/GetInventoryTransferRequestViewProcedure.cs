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
    /// Prepares, validates, and executes the function "transactions.get_inventory_transfer_request_view(_user_id integer, _login_id bigint, _office_id integer, _from date, _to date, _office text, _store text, _authorized text, _delivered text, _received text, _user text, _reference_number text, _statement_reference text)" on the database.
    /// </summary>
    public class GetInventoryTransferRequestViewProcedure : DbAccess, IGetInventoryTransferRequestViewRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_inventory_transfer_request_view";
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
        /// Maps to "_user_id" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_login_id" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public long LoginId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_from" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public DateTime From { get; set; }
        /// <summary>
        /// Maps to "_to" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public DateTime To { get; set; }
        /// <summary>
        /// Maps to "_office" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public string Office { get; set; }
        /// <summary>
        /// Maps to "_store" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public string Store { get; set; }
        /// <summary>
        /// Maps to "_authorized" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public string Authorized { get; set; }
        /// <summary>
        /// Maps to "_delivered" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public string Delivered { get; set; }
        /// <summary>
        /// Maps to "_received" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public string Received { get; set; }
        /// <summary>
        /// Maps to "_user" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Maps to "_reference_number" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public string ReferenceNumber { get; set; }
        /// <summary>
        /// Maps to "_statement_reference" argument of the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        public string StatementReference { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_inventory_transfer_request_view(_user_id integer, _login_id bigint, _office_id integer, _from date, _to date, _office text, _store text, _authorized text, _delivered text, _received text, _user text, _reference_number text, _statement_reference text)" on the database.
        /// </summary>
        public GetInventoryTransferRequestViewProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_inventory_transfer_request_view(_user_id integer, _login_id bigint, _office_id integer, _from date, _to date, _office text, _store text, _authorized text, _delivered text, _received text, _user text, _reference_number text, _statement_reference text)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="loginId">Enter argument value for "_login_id" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="from">Enter argument value for "_from" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="to">Enter argument value for "_to" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="office">Enter argument value for "_office" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="store">Enter argument value for "_store" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="authorized">Enter argument value for "_authorized" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="delivered">Enter argument value for "_delivered" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="received">Enter argument value for "_received" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="user">Enter argument value for "_user" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="referenceNumber">Enter argument value for "_reference_number" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        /// <param name="statementReference">Enter argument value for "_statement_reference" parameter of the function "transactions.get_inventory_transfer_request_view".</param>
        public GetInventoryTransferRequestViewProcedure(int userId, long loginId, int officeId, DateTime from, DateTime to, string office, string store, string authorized, string delivered, string received, string user, string referenceNumber, string statementReference)
        {
            this.UserId = userId;
            this.LoginId = loginId;
            this.OfficeId = officeId;
            this.From = from;
            this.To = to;
            this.Office = office;
            this.Store = store;
            this.Authorized = authorized;
            this.Delivered = delivered;
            this.Received = received;
            this.User = user;
            this.ReferenceNumber = referenceNumber;
            this.StatementReference = statementReference;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_inventory_transfer_request_view".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetInventoryTransferRequestViewResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetInventoryTransferRequestViewProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_inventory_transfer_request_view(@UserId, @LoginId, @OfficeId, @From, @To, @Office, @Store, @Authorized, @Delivered, @Received, @User, @ReferenceNumber, @StatementReference);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@LoginId", "@1::bigint");
            query = query.ReplaceWholeWord("@OfficeId", "@2::integer");
            query = query.ReplaceWholeWord("@From", "@3::date");
            query = query.ReplaceWholeWord("@To", "@4::date");
            query = query.ReplaceWholeWord("@Office", "@5::text");
            query = query.ReplaceWholeWord("@Store", "@6::text");
            query = query.ReplaceWholeWord("@Authorized", "@7::text");
            query = query.ReplaceWholeWord("@Delivered", "@8::text");
            query = query.ReplaceWholeWord("@Received", "@9::text");
            query = query.ReplaceWholeWord("@User", "@10::text");
            query = query.ReplaceWholeWord("@ReferenceNumber", "@11::text");
            query = query.ReplaceWholeWord("@StatementReference", "@12::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.LoginId);
            parameters.Add(this.OfficeId);
            parameters.Add(this.From);
            parameters.Add(this.To);
            parameters.Add(this.Office);
            parameters.Add(this.Store);
            parameters.Add(this.Authorized);
            parameters.Add(this.Delivered);
            parameters.Add(this.Received);
            parameters.Add(this.User);
            parameters.Add(this.ReferenceNumber);
            parameters.Add(this.StatementReference);

            return Factory.Get<DbGetInventoryTransferRequestViewResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}