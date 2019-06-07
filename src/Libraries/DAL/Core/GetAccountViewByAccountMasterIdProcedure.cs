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
    /// Prepares, validates, and executes the function "core.get_account_view_by_account_master_id(_account_master_id integer, _row_number integer)" on the database.
    /// </summary>
    public class GetAccountViewByAccountMasterIdProcedure : DbAccess, IGetAccountViewByAccountMasterIdRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_account_view_by_account_master_id";
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
        /// Maps to "_account_master_id" argument of the function "core.get_account_view_by_account_master_id".
        /// </summary>
        public int AccountMasterId { get; set; }
        /// <summary>
        /// Maps to "_row_number" argument of the function "core.get_account_view_by_account_master_id".
        /// </summary>
        public int RowNumber { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_view_by_account_master_id(_account_master_id integer, _row_number integer)" on the database.
        /// </summary>
        public GetAccountViewByAccountMasterIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_account_view_by_account_master_id(_account_master_id integer, _row_number integer)" on the database.
        /// </summary>
        /// <param name="accountMasterId">Enter argument value for "_account_master_id" parameter of the function "core.get_account_view_by_account_master_id".</param>
        /// <param name="rowNumber">Enter argument value for "_row_number" parameter of the function "core.get_account_view_by_account_master_id".</param>
        public GetAccountViewByAccountMasterIdProcedure(int accountMasterId, int rowNumber)
        {
            this.AccountMasterId = accountMasterId;
            this.RowNumber = rowNumber;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_account_view_by_account_master_id".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetAccountViewByAccountMasterIdResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetAccountViewByAccountMasterIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_account_view_by_account_master_id(@AccountMasterId, @RowNumber);";

            query = query.ReplaceWholeWord("@AccountMasterId", "@0::integer");
            query = query.ReplaceWholeWord("@RowNumber", "@1::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.AccountMasterId);
            parameters.Add(this.RowNumber);

            return Factory.Get<DbGetAccountViewByAccountMasterIdResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}