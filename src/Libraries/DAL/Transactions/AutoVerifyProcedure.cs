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
    /// Prepares, validates, and executes the function "transactions.auto_verify(_tran_id bigint, _office_id integer)" on the database.
    /// </summary>
    public class AutoVerifyProcedure : DbAccess, IAutoVerifyRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "auto_verify";
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
        /// Maps to "_tran_id" argument of the function "transactions.auto_verify".
        /// </summary>
        public long TranId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.auto_verify".
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.auto_verify(_tran_id bigint, _office_id integer)" on the database.
        /// </summary>
        public AutoVerifyProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.auto_verify(_tran_id bigint, _office_id integer)" on the database.
        /// </summary>
        /// <param name="tranId">Enter argument value for "_tran_id" parameter of the function "transactions.auto_verify".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.auto_verify".</param>
        public AutoVerifyProcedure(long tranId, int officeId)
        {
            this.TranId = tranId;
            this.OfficeId = officeId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.auto_verify".
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
                    Log.Information("Access to the function \"AutoVerifyProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.auto_verify(@TranId, @OfficeId);";

            query = query.ReplaceWholeWord("@TranId", "@0::bigint");
            query = query.ReplaceWholeWord("@OfficeId", "@1::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.TranId);
            parameters.Add(this.OfficeId);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}