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
    /// Prepares, validates, and executes the function "transactions.get_closing_stock(_on_date date, _office_id integer)" on the database.
    /// </summary>
    public class GetClosingStockProcedure : DbAccess, IGetClosingStockRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_closing_stock";
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
        /// Maps to "_on_date" argument of the function "transactions.get_closing_stock".
        /// </summary>
        public DateTime OnDate { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.get_closing_stock".
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_closing_stock(_on_date date, _office_id integer)" on the database.
        /// </summary>
        public GetClosingStockProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_closing_stock(_on_date date, _office_id integer)" on the database.
        /// </summary>
        /// <param name="onDate">Enter argument value for "_on_date" parameter of the function "transactions.get_closing_stock".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_closing_stock".</param>
        public GetClosingStockProcedure(DateTime onDate, int officeId)
        {
            this.OnDate = onDate;
            this.OfficeId = officeId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_closing_stock".
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
                    Log.Information("Access to the function \"GetClosingStockProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_closing_stock(@OnDate, @OfficeId);";

            query = query.ReplaceWholeWord("@OnDate", "@0::date");
            query = query.ReplaceWholeWord("@OfficeId", "@1::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.OnDate);
            parameters.Add(this.OfficeId);

            return Factory.Scalar<decimal>(this._Catalog, query, parameters.ToArray());
        }


    }
}