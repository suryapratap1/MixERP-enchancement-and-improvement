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
    /// Prepares, validates, and executes the function "transactions.get_journal_view(_user_id integer, _office_id integer, _from date, _to date, _tran_id bigint, _tran_code character varying, _book character varying, _reference_number character varying, _statement_reference character varying, _posted_by character varying, _office character varying, _status character varying, _verified_by character varying, _reason character varying)" on the database.
    /// </summary>
    public class GetJournalViewProcedure : DbAccess, IGetJournalViewRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_journal_view";
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
        /// Maps to "_user_id" argument of the function "transactions.get_journal_view".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.get_journal_view".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_from" argument of the function "transactions.get_journal_view".
        /// </summary>
        public DateTime From { get; set; }
        /// <summary>
        /// Maps to "_to" argument of the function "transactions.get_journal_view".
        /// </summary>
        public DateTime To { get; set; }
        /// <summary>
        /// Maps to "_tran_id" argument of the function "transactions.get_journal_view".
        /// </summary>
        public long TranId { get; set; }
        /// <summary>
        /// Maps to "_tran_code" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string TranCode { get; set; }
        /// <summary>
        /// Maps to "_book" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string Book { get; set; }
        /// <summary>
        /// Maps to "_reference_number" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string ReferenceNumber { get; set; }
        /// <summary>
        /// Maps to "_statement_reference" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string StatementReference { get; set; }
        /// <summary>
        /// Maps to "_posted_by" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string PostedBy { get; set; }
        /// <summary>
        /// Maps to "_office" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string Office { get; set; }
        /// <summary>
        /// Maps to "_status" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Maps to "_verified_by" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string VerifiedBy { get; set; }
        /// <summary>
        /// Maps to "_reason" argument of the function "transactions.get_journal_view".
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_journal_view(_user_id integer, _office_id integer, _from date, _to date, _tran_id bigint, _tran_code character varying, _book character varying, _reference_number character varying, _statement_reference character varying, _posted_by character varying, _office character varying, _status character varying, _verified_by character varying, _reason character varying)" on the database.
        /// </summary>
        public GetJournalViewProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_journal_view(_user_id integer, _office_id integer, _from date, _to date, _tran_id bigint, _tran_code character varying, _book character varying, _reference_number character varying, _statement_reference character varying, _posted_by character varying, _office character varying, _status character varying, _verified_by character varying, _reason character varying)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="from">Enter argument value for "_from" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="to">Enter argument value for "_to" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="tranId">Enter argument value for "_tran_id" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="tranCode">Enter argument value for "_tran_code" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="book">Enter argument value for "_book" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="referenceNumber">Enter argument value for "_reference_number" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="statementReference">Enter argument value for "_statement_reference" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="postedBy">Enter argument value for "_posted_by" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="office">Enter argument value for "_office" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="status">Enter argument value for "_status" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="verifiedBy">Enter argument value for "_verified_by" parameter of the function "transactions.get_journal_view".</param>
        /// <param name="reason">Enter argument value for "_reason" parameter of the function "transactions.get_journal_view".</param>
        public GetJournalViewProcedure(int userId, int officeId, DateTime from, DateTime to, long tranId, string tranCode, string book, string referenceNumber, string statementReference, string postedBy, string office, string status, string verifiedBy, string reason)
        {
            this.UserId = userId;
            this.OfficeId = officeId;
            this.From = from;
            this.To = to;
            this.TranId = tranId;
            this.TranCode = tranCode;
            this.Book = book;
            this.ReferenceNumber = referenceNumber;
            this.StatementReference = statementReference;
            this.PostedBy = postedBy;
            this.Office = office;
            this.Status = status;
            this.VerifiedBy = verifiedBy;
            this.Reason = reason;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_journal_view".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetJournalViewResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetJournalViewProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_journal_view(@UserId, @OfficeId, @From, @To, @TranId, @TranCode, @Book, @ReferenceNumber, @StatementReference, @PostedBy, @Office, @Status, @VerifiedBy, @Reason);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@OfficeId", "@1::integer");
            query = query.ReplaceWholeWord("@From", "@2::date");
            query = query.ReplaceWholeWord("@To", "@3::date");
            query = query.ReplaceWholeWord("@TranId", "@4::bigint");
            query = query.ReplaceWholeWord("@TranCode", "@5::character varying");
            query = query.ReplaceWholeWord("@Book", "@6::character varying");
            query = query.ReplaceWholeWord("@ReferenceNumber", "@7::character varying");
            query = query.ReplaceWholeWord("@StatementReference", "@8::character varying");
            query = query.ReplaceWholeWord("@PostedBy", "@9::character varying");
            query = query.ReplaceWholeWord("@Office", "@10::character varying");
            query = query.ReplaceWholeWord("@Status", "@11::character varying");
            query = query.ReplaceWholeWord("@VerifiedBy", "@12::character varying");
            query = query.ReplaceWholeWord("@Reason", "@13::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.OfficeId);
            parameters.Add(this.From);
            parameters.Add(this.To);
            parameters.Add(this.TranId);
            parameters.Add(this.TranCode);
            parameters.Add(this.Book);
            parameters.Add(this.ReferenceNumber);
            parameters.Add(this.StatementReference);
            parameters.Add(this.PostedBy);
            parameters.Add(this.Office);
            parameters.Add(this.Status);
            parameters.Add(this.VerifiedBy);
            parameters.Add(this.Reason);

            return Factory.Get<DbGetJournalViewResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}