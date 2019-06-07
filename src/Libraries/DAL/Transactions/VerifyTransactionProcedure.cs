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
    /// Prepares, validates, and executes the function "transactions.verify_transaction(_transaction_master_id bigint, _office_id integer, _user_id integer, _login_id bigint, _verification_status_id smallint, _reason character varying)" on the database.
    /// </summary>
    public class VerifyTransactionProcedure : DbAccess, IVerifyTransactionRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "verify_transaction";
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
        /// Maps to "_transaction_master_id" argument of the function "transactions.verify_transaction".
        /// </summary>
        public long TransactionMasterId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.verify_transaction".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "transactions.verify_transaction".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_login_id" argument of the function "transactions.verify_transaction".
        /// </summary>
        public long LoginId { get; set; }
        /// <summary>
        /// Maps to "_verification_status_id" argument of the function "transactions.verify_transaction".
        /// </summary>
        public short VerificationStatusId { get; set; }
        /// <summary>
        /// Maps to "_reason" argument of the function "transactions.verify_transaction".
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.verify_transaction(_transaction_master_id bigint, _office_id integer, _user_id integer, _login_id bigint, _verification_status_id smallint, _reason character varying)" on the database.
        /// </summary>
        public VerifyTransactionProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.verify_transaction(_transaction_master_id bigint, _office_id integer, _user_id integer, _login_id bigint, _verification_status_id smallint, _reason character varying)" on the database.
        /// </summary>
        /// <param name="transactionMasterId">Enter argument value for "_transaction_master_id" parameter of the function "transactions.verify_transaction".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.verify_transaction".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.verify_transaction".</param>
        /// <param name="loginId">Enter argument value for "_login_id" parameter of the function "transactions.verify_transaction".</param>
        /// <param name="verificationStatusId">Enter argument value for "_verification_status_id" parameter of the function "transactions.verify_transaction".</param>
        /// <param name="reason">Enter argument value for "_reason" parameter of the function "transactions.verify_transaction".</param>
        public VerifyTransactionProcedure(long transactionMasterId, int officeId, int userId, long loginId, short verificationStatusId, string reason)
        {
            this.TransactionMasterId = transactionMasterId;
            this.OfficeId = officeId;
            this.UserId = userId;
            this.LoginId = loginId;
            this.VerificationStatusId = verificationStatusId;
            this.Reason = reason;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.verify_transaction".
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
                    Log.Information("Access to the function \"VerifyTransactionProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.verify_transaction(@TransactionMasterId, @OfficeId, @UserId, @LoginId, @VerificationStatusId, @Reason);";

            query = query.ReplaceWholeWord("@TransactionMasterId", "@0::bigint");
            query = query.ReplaceWholeWord("@OfficeId", "@1::integer");
            query = query.ReplaceWholeWord("@UserId", "@2::integer");
            query = query.ReplaceWholeWord("@LoginId", "@3::bigint");
            query = query.ReplaceWholeWord("@VerificationStatusId", "@4::smallint");
            query = query.ReplaceWholeWord("@Reason", "@5::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.TransactionMasterId);
            parameters.Add(this.OfficeId);
            parameters.Add(this.UserId);
            parameters.Add(this.LoginId);
            parameters.Add(this.VerificationStatusId);
            parameters.Add(this.Reason);

            return Factory.Scalar<long>(this._Catalog, query, parameters.ToArray());
        }


    }
}