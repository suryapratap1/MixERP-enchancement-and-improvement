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
    /// Prepares, validates, and executes the function "transactions.is_valid_party_by_transaction_master_id(_transaction_master_id bigint, _party_id bigint)" on the database.
    /// </summary>
    public class IsValidPartyByTransactionMasterIdProcedure : DbAccess, IIsValidPartyByTransactionMasterIdRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "is_valid_party_by_transaction_master_id";
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
        /// Maps to "_transaction_master_id" argument of the function "transactions.is_valid_party_by_transaction_master_id".
        /// </summary>
        public long TransactionMasterId { get; set; }
        /// <summary>
        /// Maps to "_party_id" argument of the function "transactions.is_valid_party_by_transaction_master_id".
        /// </summary>
        public long PartyId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.is_valid_party_by_transaction_master_id(_transaction_master_id bigint, _party_id bigint)" on the database.
        /// </summary>
        public IsValidPartyByTransactionMasterIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.is_valid_party_by_transaction_master_id(_transaction_master_id bigint, _party_id bigint)" on the database.
        /// </summary>
        /// <param name="transactionMasterId">Enter argument value for "_transaction_master_id" parameter of the function "transactions.is_valid_party_by_transaction_master_id".</param>
        /// <param name="partyId">Enter argument value for "_party_id" parameter of the function "transactions.is_valid_party_by_transaction_master_id".</param>
        public IsValidPartyByTransactionMasterIdProcedure(long transactionMasterId, long partyId)
        {
            this.TransactionMasterId = transactionMasterId;
            this.PartyId = partyId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.is_valid_party_by_transaction_master_id".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public bool Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"IsValidPartyByTransactionMasterIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.is_valid_party_by_transaction_master_id(@TransactionMasterId, @PartyId);";

            query = query.ReplaceWholeWord("@TransactionMasterId", "@0::bigint");
            query = query.ReplaceWholeWord("@PartyId", "@1::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.TransactionMasterId);
            parameters.Add(this.PartyId);

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }


    }
}