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
    /// Prepares, validates, and executes the function "transactions.get_merge_model(_tran_ids bigint[], _book text)" on the database.
    /// </summary>
    public class GetMergeModelProcedure : DbAccess, IGetMergeModelRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_merge_model";
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
        /// Maps to "_tran_ids" argument of the function "transactions.get_merge_model".
        /// </summary>
        public long[] TranIds { get; set; }
        /// <summary>
        /// Maps to "_book" argument of the function "transactions.get_merge_model".
        /// </summary>
        public string Book { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_merge_model(_tran_ids bigint[], _book text)" on the database.
        /// </summary>
        public GetMergeModelProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_merge_model(_tran_ids bigint[], _book text)" on the database.
        /// </summary>
        /// <param name="tranIds">Enter argument value for "_tran_ids" parameter of the function "transactions.get_merge_model".</param>
        /// <param name="book">Enter argument value for "_book" parameter of the function "transactions.get_merge_model".</param>
        public GetMergeModelProcedure(long[] tranIds, string book)
        {
            this.TranIds = tranIds;
            this.Book = book;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_merge_model".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetMergeModelResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetMergeModelProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_merge_model(@TranIds, @Book);";


            int tranIdsOffset = 0;
            query = query.ReplaceWholeWord("@TranIds", "ARRAY[" + this.SqlForTranIds(this.TranIds, tranIdsOffset, 1) + "]");

            int offset = tranIdsOffset + (this.TranIds == null ? 0 : this.TranIds.Count() * 1)/*The object TranIds has 1 member(s).*/;
            query = query.ReplaceWholeWord("@Book", "@" + offset + "::text");

            offset++;


            List<object> parameters = new List<object>();
            parameters.AddRange(this.ParamsForTranIds(this.TranIds));
            parameters.Add(this.Book);

            return Factory.Get<DbGetMergeModelResult>(this._Catalog, query, parameters.ToArray());
        }

        private string SqlForTranIds(long[] tranIds, int offset, int memberCount)
        {
            if (tranIds == null)
            {
                return "NULL::bigint";
            }
            List<string> parameters = new List<string>();
            for (int i = 0; i < tranIds.Count(); i++)
            {
                List<string> args = new List<string>();
                args.Add("@" + offset);
                offset++;
                string parameter = "{0}::bigint";
                parameter = string.Format(System.Globalization.CultureInfo.InvariantCulture, parameter,
                    string.Join(",", args));
                parameters.Add(parameter);
            }
            return string.Join(",", parameters);
        }

        private List<object> ParamsForTranIds(long[] tranIds)
        {
            List<object> collection = new List<object>();

            if (tranIds != null && tranIds.Count() > 0)
            {
                foreach (long tranId in tranIds)
                {
                    collection.Add(tranId);
                }
            }
            return collection;
        }
    }
}