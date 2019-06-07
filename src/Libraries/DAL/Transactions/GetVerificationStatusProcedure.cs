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
    /// Prepares, validates, and executes the function "transactions.get_verification_status(_tran_id bigint)" on the database.
    /// </summary>
    public class GetVerificationStatusProcedure : DbAccess, IGetVerificationStatusRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_verification_status";
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
        /// Maps to "_tran_id" argument of the function "transactions.get_verification_status".
        /// </summary>
        public long TranId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_verification_status(_tran_id bigint)" on the database.
        /// </summary>
        public GetVerificationStatusProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_verification_status(_tran_id bigint)" on the database.
        /// </summary>
        /// <param name="tranId">Enter argument value for "_tran_id" parameter of the function "transactions.get_verification_status".</param>
        public GetVerificationStatusProcedure(long tranId)
        {
            this.TranId = tranId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_verification_status".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public short Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetVerificationStatusProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_verification_status(@TranId);";

            query = query.ReplaceWholeWord("@TranId", "@0::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.TranId);

            return Factory.Scalar<short>(this._Catalog, query, parameters.ToArray());
        }


    }
}