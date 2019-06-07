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
    /// Prepares, validates, and executes the function "transactions.get_product_view(user_id_ integer, book_ text, office_id_ integer, date_from_ date, date_to_ date, office_ character varying, party_ text, price_type_ text, user_ character varying, reference_number_ character varying, statement_reference_ text)" on the database.
    /// </summary>
    public class GetProductViewProcedure : DbAccess, IGetProductViewRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_product_view";
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
        /// Maps to "user_id_" argument of the function "transactions.get_product_view".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "book_" argument of the function "transactions.get_product_view".
        /// </summary>
        public string Book { get; set; }
        /// <summary>
        /// Maps to "office_id_" argument of the function "transactions.get_product_view".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "date_from_" argument of the function "transactions.get_product_view".
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Maps to "date_to_" argument of the function "transactions.get_product_view".
        /// </summary>
        public DateTime DateTo { get; set; }
        /// <summary>
        /// Maps to "office_" argument of the function "transactions.get_product_view".
        /// </summary>
        public string Office { get; set; }
        /// <summary>
        /// Maps to "party_" argument of the function "transactions.get_product_view".
        /// </summary>
        public string Party { get; set; }
        /// <summary>
        /// Maps to "price_type_" argument of the function "transactions.get_product_view".
        /// </summary>
        public string PriceType { get; set; }
        /// <summary>
        /// Maps to "user_" argument of the function "transactions.get_product_view".
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Maps to "reference_number_" argument of the function "transactions.get_product_view".
        /// </summary>
        public string ReferenceNumber { get; set; }
        /// <summary>
        /// Maps to "statement_reference_" argument of the function "transactions.get_product_view".
        /// </summary>
        public string StatementReference { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_product_view(user_id_ integer, book_ text, office_id_ integer, date_from_ date, date_to_ date, office_ character varying, party_ text, price_type_ text, user_ character varying, reference_number_ character varying, statement_reference_ text)" on the database.
        /// </summary>
        public GetProductViewProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_product_view(user_id_ integer, book_ text, office_id_ integer, date_from_ date, date_to_ date, office_ character varying, party_ text, price_type_ text, user_ character varying, reference_number_ character varying, statement_reference_ text)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "user_id_" parameter of the function "transactions.get_product_view".</param>
        /// <param name="book">Enter argument value for "book_" parameter of the function "transactions.get_product_view".</param>
        /// <param name="officeId">Enter argument value for "office_id_" parameter of the function "transactions.get_product_view".</param>
        /// <param name="dateFrom">Enter argument value for "date_from_" parameter of the function "transactions.get_product_view".</param>
        /// <param name="dateTo">Enter argument value for "date_to_" parameter of the function "transactions.get_product_view".</param>
        /// <param name="office">Enter argument value for "office_" parameter of the function "transactions.get_product_view".</param>
        /// <param name="party">Enter argument value for "party_" parameter of the function "transactions.get_product_view".</param>
        /// <param name="priceType">Enter argument value for "price_type_" parameter of the function "transactions.get_product_view".</param>
        /// <param name="user">Enter argument value for "user_" parameter of the function "transactions.get_product_view".</param>
        /// <param name="referenceNumber">Enter argument value for "reference_number_" parameter of the function "transactions.get_product_view".</param>
        /// <param name="statementReference">Enter argument value for "statement_reference_" parameter of the function "transactions.get_product_view".</param>
        public GetProductViewProcedure(int userId, string book, int officeId, DateTime dateFrom, DateTime dateTo, string office, string party, string priceType, string user, string referenceNumber, string statementReference)
        {
            this.UserId = userId;
            this.Book = book;
            this.OfficeId = officeId;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.Office = office;
            this.Party = party;
            this.PriceType = priceType;
            this.User = user;
            this.ReferenceNumber = referenceNumber;
            this.StatementReference = statementReference;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_product_view".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetProductViewResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetProductViewProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_product_view(@UserId, @Book, @OfficeId, @DateFrom, @DateTo, @Office, @Party, @PriceType, @User, @ReferenceNumber, @StatementReference);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@Book", "@1::text");
            query = query.ReplaceWholeWord("@OfficeId", "@2::integer");
            query = query.ReplaceWholeWord("@DateFrom", "@3::date");
            query = query.ReplaceWholeWord("@DateTo", "@4::date");
            query = query.ReplaceWholeWord("@Office", "@5::character varying");
            query = query.ReplaceWholeWord("@Party", "@6::text");
            query = query.ReplaceWholeWord("@PriceType", "@7::text");
            query = query.ReplaceWholeWord("@User", "@8::character varying");
            query = query.ReplaceWholeWord("@ReferenceNumber", "@9::character varying");
            query = query.ReplaceWholeWord("@StatementReference", "@10::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.Book);
            parameters.Add(this.OfficeId);
            parameters.Add(this.DateFrom);
            parameters.Add(this.DateTo);
            parameters.Add(this.Office);
            parameters.Add(this.Party);
            parameters.Add(this.PriceType);
            parameters.Add(this.User);
            parameters.Add(this.ReferenceNumber);
            parameters.Add(this.StatementReference);

            return Factory.Get<DbGetProductViewResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}