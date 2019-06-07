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
    /// Prepares, validates, and executes the function "transactions.get_invoice_amount(transaction_master_id_ bigint)" on the database.
    /// </summary>
    public class GetInvoiceAmountProcedure : DbAccess, IGetInvoiceAmountRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_invoice_amount";
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
        /// Maps to "transaction_master_id_" argument of the function "transactions.get_invoice_amount".
        /// </summary>
        public long TransactionMasterId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_invoice_amount(transaction_master_id_ bigint)" on the database.
        /// </summary>
        public GetInvoiceAmountProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_invoice_amount(transaction_master_id_ bigint)" on the database.
        /// </summary>
        /// <param name="transactionMasterId">Enter argument value for "transaction_master_id_" parameter of the function "transactions.get_invoice_amount".</param>
        public GetInvoiceAmountProcedure(long transactionMasterId)
        {
            this.TransactionMasterId = transactionMasterId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_invoice_amount".
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
                    Log.Information("Access to the function \"GetInvoiceAmountProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_invoice_amount(@TransactionMasterId);";

            query = query.ReplaceWholeWord("@TransactionMasterId", "@0::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.TransactionMasterId);

            return Factory.Get<decimal>(this._Catalog, query, parameters.ToArray()).FirstOrDefault();
        }


    }
}