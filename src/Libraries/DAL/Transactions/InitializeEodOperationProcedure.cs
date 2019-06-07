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
    /// Prepares, validates, and executes the function "transactions.initialize_eod_operation(_user_id integer, _office_id integer, _value_date date)" on the database.
    /// </summary>
    public class InitializeEodOperationProcedure : DbAccess, IInitializeEodOperationRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "initialize_eod_operation";
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
        /// Maps to "_user_id" argument of the function "transactions.initialize_eod_operation".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.initialize_eod_operation".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_value_date" argument of the function "transactions.initialize_eod_operation".
        /// </summary>
        public DateTime ValueDate { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.initialize_eod_operation(_user_id integer, _office_id integer, _value_date date)" on the database.
        /// </summary>
        public InitializeEodOperationProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.initialize_eod_operation(_user_id integer, _office_id integer, _value_date date)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.initialize_eod_operation".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.initialize_eod_operation".</param>
        /// <param name="valueDate">Enter argument value for "_value_date" parameter of the function "transactions.initialize_eod_operation".</param>
        public InitializeEodOperationProcedure(int userId, int officeId, DateTime valueDate)
        {
            this.UserId = userId;
            this.OfficeId = officeId;
            this.ValueDate = valueDate;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.initialize_eod_operation".
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
                    Log.Information("Access to the function \"InitializeEodOperationProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.initialize_eod_operation(@UserId, @OfficeId, @ValueDate);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@OfficeId", "@1::integer");
            query = query.ReplaceWholeWord("@ValueDate", "@2::date");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.OfficeId);
            parameters.Add(this.ValueDate);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}