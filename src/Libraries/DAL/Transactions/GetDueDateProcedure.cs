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
    /// Prepares, validates, and executes the function "transactions.get_due_date(_value_date date, _payment_term_id integer)" on the database.
    /// </summary>
    public class GetDueDateProcedure : DbAccess, IGetDueDateRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_due_date";
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
        /// Maps to "_value_date" argument of the function "transactions.get_due_date".
        /// </summary>
        public DateTime ValueDate { get; set; }
        /// <summary>
        /// Maps to "_payment_term_id" argument of the function "transactions.get_due_date".
        /// </summary>
        public int PaymentTermId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_due_date(_value_date date, _payment_term_id integer)" on the database.
        /// </summary>
        public GetDueDateProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_due_date(_value_date date, _payment_term_id integer)" on the database.
        /// </summary>
        /// <param name="valueDate">Enter argument value for "_value_date" parameter of the function "transactions.get_due_date".</param>
        /// <param name="paymentTermId">Enter argument value for "_payment_term_id" parameter of the function "transactions.get_due_date".</param>
        public GetDueDateProcedure(DateTime valueDate, int paymentTermId)
        {
            this.ValueDate = valueDate;
            this.PaymentTermId = paymentTermId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_due_date".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public DateTime Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetDueDateProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_due_date(@ValueDate, @PaymentTermId);";

            query = query.ReplaceWholeWord("@ValueDate", "@0::date");
            query = query.ReplaceWholeWord("@PaymentTermId", "@1::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.ValueDate);
            parameters.Add(this.PaymentTermId);

            return Factory.Scalar<DateTime>(this._Catalog, query, parameters.ToArray());
        }


    }
}