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
    /// Prepares, validates, and executes the function "transactions.post_bonus(_user_id integer, _login_id bigint, _office_id integer, _value_date date)" on the database.
    /// </summary>
    public class PostBonusProcedure : DbAccess, IPostBonusRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "post_bonus";
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
        /// Maps to "_user_id" argument of the function "transactions.post_bonus".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_login_id" argument of the function "transactions.post_bonus".
        /// </summary>
        public long LoginId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.post_bonus".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_value_date" argument of the function "transactions.post_bonus".
        /// </summary>
        public DateTime ValueDate { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.post_bonus(_user_id integer, _login_id bigint, _office_id integer, _value_date date)" on the database.
        /// </summary>
        public PostBonusProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.post_bonus(_user_id integer, _login_id bigint, _office_id integer, _value_date date)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.post_bonus".</param>
        /// <param name="loginId">Enter argument value for "_login_id" parameter of the function "transactions.post_bonus".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.post_bonus".</param>
        /// <param name="valueDate">Enter argument value for "_value_date" parameter of the function "transactions.post_bonus".</param>
        public PostBonusProcedure(int userId, long loginId, int officeId, DateTime valueDate)
        {
            this.UserId = userId;
            this.LoginId = loginId;
            this.OfficeId = officeId;
            this.ValueDate = valueDate;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.post_bonus".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"PostBonusProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.post_bonus(@UserId, @LoginId, @OfficeId, @ValueDate);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@LoginId", "@1::bigint");
            query = query.ReplaceWholeWord("@OfficeId", "@2::integer");
            query = query.ReplaceWholeWord("@ValueDate", "@3::date");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.LoginId);
            parameters.Add(this.OfficeId);
            parameters.Add(this.ValueDate);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}