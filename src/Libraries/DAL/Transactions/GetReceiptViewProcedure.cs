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
    /// Prepares, validates, and executes the function "transactions.get_receipt_view(_user_id integer, _office_id integer, _date_from date, _date_to date, _office character varying, _party text, _user character varying, _reference_number character varying, _statement_reference text)" on the database.
    /// </summary>
    public class GetReceiptViewProcedure : DbAccess, IGetReceiptViewRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_receipt_view";
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
        /// Maps to "_user_id" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_date_from" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Maps to "_date_to" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public DateTime DateTo { get; set; }
        /// <summary>
        /// Maps to "_office" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public string Office { get; set; }
        /// <summary>
        /// Maps to "_party" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public string Party { get; set; }
        /// <summary>
        /// Maps to "_user" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Maps to "_reference_number" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public string ReferenceNumber { get; set; }
        /// <summary>
        /// Maps to "_statement_reference" argument of the function "transactions.get_receipt_view".
        /// </summary>
        public string StatementReference { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_receipt_view(_user_id integer, _office_id integer, _date_from date, _date_to date, _office character varying, _party text, _user character varying, _reference_number character varying, _statement_reference text)" on the database.
        /// </summary>
        public GetReceiptViewProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_receipt_view(_user_id integer, _office_id integer, _date_from date, _date_to date, _office character varying, _party text, _user character varying, _reference_number character varying, _statement_reference text)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="dateFrom">Enter argument value for "_date_from" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="dateTo">Enter argument value for "_date_to" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="office">Enter argument value for "_office" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="party">Enter argument value for "_party" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="user">Enter argument value for "_user" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="referenceNumber">Enter argument value for "_reference_number" parameter of the function "transactions.get_receipt_view".</param>
        /// <param name="statementReference">Enter argument value for "_statement_reference" parameter of the function "transactions.get_receipt_view".</param>
        public GetReceiptViewProcedure(int userId, int officeId, DateTime dateFrom, DateTime dateTo, string office, string party, string user, string referenceNumber, string statementReference)
        {
            this.UserId = userId;
            this.OfficeId = officeId;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.Office = office;
            this.Party = party;
            this.User = user;
            this.ReferenceNumber = referenceNumber;
            this.StatementReference = statementReference;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_receipt_view".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetReceiptViewResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetReceiptViewProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_receipt_view(@UserId, @OfficeId, @DateFrom, @DateTo, @Office, @Party, @User, @ReferenceNumber, @StatementReference);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@OfficeId", "@1::integer");
            query = query.ReplaceWholeWord("@DateFrom", "@2::date");
            query = query.ReplaceWholeWord("@DateTo", "@3::date");
            query = query.ReplaceWholeWord("@Office", "@4::character varying");
            query = query.ReplaceWholeWord("@Party", "@5::text");
            query = query.ReplaceWholeWord("@User", "@6::character varying");
            query = query.ReplaceWholeWord("@ReferenceNumber", "@7::character varying");
            query = query.ReplaceWholeWord("@StatementReference", "@8::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.OfficeId);
            parameters.Add(this.DateFrom);
            parameters.Add(this.DateTo);
            parameters.Add(this.Office);
            parameters.Add(this.Party);
            parameters.Add(this.User);
            parameters.Add(this.ReferenceNumber);
            parameters.Add(this.StatementReference);

            return Factory.Get<DbGetReceiptViewResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}