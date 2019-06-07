// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Core;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "core.calculate_interest(principal numeric, rate numeric, days integer, round_up integer, num_of_days_in_year integer)" on the database.
    /// </summary>
    public class CalculateInterestProcedure : DbAccess, ICalculateInterestRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "calculate_interest";
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
        /// Maps to "principal" argument of the function "core.calculate_interest".
        /// </summary>
        public decimal Principal { get; set; }
        /// <summary>
        /// Maps to "rate" argument of the function "core.calculate_interest".
        /// </summary>
        public decimal Rate { get; set; }
        /// <summary>
        /// Maps to "days" argument of the function "core.calculate_interest".
        /// </summary>
        public int Days { get; set; }
        /// <summary>
        /// Maps to "round_up" argument of the function "core.calculate_interest".
        /// </summary>
        public int RoundUp { get; set; }
        /// <summary>
        /// Maps to "num_of_days_in_year" argument of the function "core.calculate_interest".
        /// </summary>
        public int NumOfDaysInYear { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.calculate_interest(principal numeric, rate numeric, days integer, round_up integer, num_of_days_in_year integer)" on the database.
        /// </summary>
        public CalculateInterestProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.calculate_interest(principal numeric, rate numeric, days integer, round_up integer, num_of_days_in_year integer)" on the database.
        /// </summary>
        /// <param name="principal">Enter argument value for "principal" parameter of the function "core.calculate_interest".</param>
        /// <param name="rate">Enter argument value for "rate" parameter of the function "core.calculate_interest".</param>
        /// <param name="days">Enter argument value for "days" parameter of the function "core.calculate_interest".</param>
        /// <param name="roundUp">Enter argument value for "round_up" parameter of the function "core.calculate_interest".</param>
        /// <param name="numOfDaysInYear">Enter argument value for "num_of_days_in_year" parameter of the function "core.calculate_interest".</param>
        public CalculateInterestProcedure(decimal principal, decimal rate, int days, int roundUp, int numOfDaysInYear)
        {
            this.Principal = principal;
            this.Rate = rate;
            this.Days = days;
            this.RoundUp = roundUp;
            this.NumOfDaysInYear = numOfDaysInYear;
        }
        /// <summary>
        /// Prepares and executes the function "core.calculate_interest".
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
                    Log.Information("Access to the function \"CalculateInterestProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.calculate_interest(@Principal, @Rate, @Days, @RoundUp, @NumOfDaysInYear);";

            query = query.ReplaceWholeWord("@Principal", "@0::numeric");
            query = query.ReplaceWholeWord("@Rate", "@1::numeric");
            query = query.ReplaceWholeWord("@Days", "@2::integer");
            query = query.ReplaceWholeWord("@RoundUp", "@3::integer");
            query = query.ReplaceWholeWord("@NumOfDaysInYear", "@4::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.Principal);
            parameters.Add(this.Rate);
            parameters.Add(this.Days);
            parameters.Add(this.RoundUp);
            parameters.Add(this.NumOfDaysInYear);

            return Factory.Scalar<decimal>(this._Catalog, query, parameters.ToArray());
        }


    }
}