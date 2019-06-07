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
    /// Prepares, validates, and executes the function "transactions.post_stock_transfer_acknowledgement(_office_id integer, _user_id integer, _login_id bigint, _request_id bigint)" on the database.
    /// </summary>
    public class PostStockTransferAcknowledgementProcedure : DbAccess, IPostStockTransferAcknowledgementRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "post_stock_transfer_acknowledgement";
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
        /// Maps to "_office_id" argument of the function "transactions.post_stock_transfer_acknowledgement".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "transactions.post_stock_transfer_acknowledgement".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_login_id" argument of the function "transactions.post_stock_transfer_acknowledgement".
        /// </summary>
        public long LoginId { get; set; }
        /// <summary>
        /// Maps to "_request_id" argument of the function "transactions.post_stock_transfer_acknowledgement".
        /// </summary>
        public long RequestId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.post_stock_transfer_acknowledgement(_office_id integer, _user_id integer, _login_id bigint, _request_id bigint)" on the database.
        /// </summary>
        public PostStockTransferAcknowledgementProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.post_stock_transfer_acknowledgement(_office_id integer, _user_id integer, _login_id bigint, _request_id bigint)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.post_stock_transfer_acknowledgement".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.post_stock_transfer_acknowledgement".</param>
        /// <param name="loginId">Enter argument value for "_login_id" parameter of the function "transactions.post_stock_transfer_acknowledgement".</param>
        /// <param name="requestId">Enter argument value for "_request_id" parameter of the function "transactions.post_stock_transfer_acknowledgement".</param>
        public PostStockTransferAcknowledgementProcedure(int officeId, int userId, long loginId, long requestId)
        {
            this.OfficeId = officeId;
            this.UserId = userId;
            this.LoginId = loginId;
            this.RequestId = requestId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.post_stock_transfer_acknowledgement".
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
                    Log.Information("Access to the function \"PostStockTransferAcknowledgementProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.post_stock_transfer_acknowledgement(@OfficeId, @UserId, @LoginId, @RequestId);";

            query = query.ReplaceWholeWord("@OfficeId", "@0::integer");
            query = query.ReplaceWholeWord("@UserId", "@1::integer");
            query = query.ReplaceWholeWord("@LoginId", "@2::bigint");
            query = query.ReplaceWholeWord("@RequestId", "@3::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.OfficeId);
            parameters.Add(this.UserId);
            parameters.Add(this.LoginId);
            parameters.Add(this.RequestId);

            return Factory.Scalar<long>(this._Catalog, query, parameters.ToArray());
        }


    }
}