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
    /// Prepares, validates, and executes the function "transactions.get_transaction_code(value_date date, office_id integer, user_id integer, login_id bigint)" on the database.
    /// </summary>
    public class GetTransactionCodeProcedure : DbAccess, IGetTransactionCodeRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_transaction_code";
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
        /// Maps to "value_date" argument of the function "transactions.get_transaction_code".
        /// </summary>
        public DateTime ValueDate { get; set; }
        /// <summary>
        /// Maps to "office_id" argument of the function "transactions.get_transaction_code".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "user_id" argument of the function "transactions.get_transaction_code".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "login_id" argument of the function "transactions.get_transaction_code".
        /// </summary>
        public long LoginId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_transaction_code(value_date date, office_id integer, user_id integer, login_id bigint)" on the database.
        /// </summary>
        public GetTransactionCodeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_transaction_code(value_date date, office_id integer, user_id integer, login_id bigint)" on the database.
        /// </summary>
        /// <param name="valueDate">Enter argument value for "value_date" parameter of the function "transactions.get_transaction_code".</param>
        /// <param name="officeId">Enter argument value for "office_id" parameter of the function "transactions.get_transaction_code".</param>
        /// <param name="userId">Enter argument value for "user_id" parameter of the function "transactions.get_transaction_code".</param>
        /// <param name="loginId">Enter argument value for "login_id" parameter of the function "transactions.get_transaction_code".</param>
        public GetTransactionCodeProcedure(DateTime valueDate, int officeId, int userId, long loginId)
        {
            this.ValueDate = valueDate;
            this.OfficeId = officeId;
            this.UserId = userId;
            this.LoginId = loginId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_transaction_code".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public string Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetTransactionCodeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_transaction_code(@ValueDate, @OfficeId, @UserId, @LoginId);";

            query = query.ReplaceWholeWord("@ValueDate", "@0::date");
            query = query.ReplaceWholeWord("@OfficeId", "@1::integer");
            query = query.ReplaceWholeWord("@UserId", "@2::integer");
            query = query.ReplaceWholeWord("@LoginId", "@3::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.ValueDate);
            parameters.Add(this.OfficeId);
            parameters.Add(this.UserId);
            parameters.Add(this.LoginId);

            return Factory.Scalar<string>(this._Catalog, query, parameters.ToArray());
        }


    }
}