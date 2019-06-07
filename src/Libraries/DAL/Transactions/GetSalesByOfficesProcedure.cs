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
    /// Prepares, validates, and executes the function "transactions.get_sales_by_offices(office_id integer, divide_by integer)" on the database.
    /// </summary>
    public class GetSalesByOfficesProcedure : DbAccess, IGetSalesByOfficesRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_sales_by_offices";
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
        /// Maps to "office_id" argument of the function "transactions.get_sales_by_offices".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "divide_by" argument of the function "transactions.get_sales_by_offices".
        /// </summary>
        public int DivideBy { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_sales_by_offices(office_id integer, divide_by integer)" on the database.
        /// </summary>
        public GetSalesByOfficesProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_sales_by_offices(office_id integer, divide_by integer)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "office_id" parameter of the function "transactions.get_sales_by_offices".</param>
        /// <param name="divideBy">Enter argument value for "divide_by" parameter of the function "transactions.get_sales_by_offices".</param>
        public GetSalesByOfficesProcedure(int officeId, int divideBy)
        {
            this.OfficeId = officeId;
            this.DivideBy = divideBy;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_sales_by_offices".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetSalesByOfficesResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetSalesByOfficesProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_sales_by_offices(@OfficeId, @DivideBy);";

            query = query.ReplaceWholeWord("@OfficeId", "@0::integer");
            query = query.ReplaceWholeWord("@DivideBy", "@1::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.OfficeId);
            parameters.Add(this.DivideBy);

            return Factory.Get<DbGetSalesByOfficesResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}