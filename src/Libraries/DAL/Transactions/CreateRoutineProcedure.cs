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
    /// Prepares, validates, and executes the function "transactions.create_routine(_routine_code character varying, _routine regproc, _order integer)" on the database.
    /// </summary>
    public class CreateRoutineProcedure : DbAccess, ICreateRoutineRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_routine";
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
        /// Maps to "_routine_code" argument of the function "transactions.create_routine".
        /// </summary>
        public string RoutineCode { get; set; }
        /// <summary>
        /// Maps to "_routine" argument of the function "transactions.create_routine".
        /// </summary>
        public string Routine { get; set; }
        /// <summary>
        /// Maps to "_order" argument of the function "transactions.create_routine".
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.create_routine(_routine_code character varying, _routine regproc, _order integer)" on the database.
        /// </summary>
        public CreateRoutineProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.create_routine(_routine_code character varying, _routine regproc, _order integer)" on the database.
        /// </summary>
        /// <param name="routineCode">Enter argument value for "_routine_code" parameter of the function "transactions.create_routine".</param>
        /// <param name="routine">Enter argument value for "_routine" parameter of the function "transactions.create_routine".</param>
        /// <param name="order">Enter argument value for "_order" parameter of the function "transactions.create_routine".</param>
        public CreateRoutineProcedure(string routineCode, string routine, int order)
        {
            this.RoutineCode = routineCode;
            this.Routine = routine;
            this.Order = order;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.create_routine".
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
                    Log.Information("Access to the function \"CreateRoutineProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.create_routine(@RoutineCode, @Routine, @Order);";

            query = query.ReplaceWholeWord("@RoutineCode", "@0::character varying");
            query = query.ReplaceWholeWord("@Routine", "@1::regproc");
            query = query.ReplaceWholeWord("@Order", "@2::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.RoutineCode);
            parameters.Add(this.Routine);
            parameters.Add(this.Order);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}