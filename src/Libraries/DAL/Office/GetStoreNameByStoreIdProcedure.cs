// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Office;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Office.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "office.get_store_name_by_store_id(_store_id integer)" on the database.
    /// </summary>
    public class GetStoreNameByStoreIdProcedure : DbAccess, IGetStoreNameByStoreIdRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_store_name_by_store_id";
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
        /// Maps to "_store_id" argument of the function "office.get_store_name_by_store_id".
        /// </summary>
        public int StoreId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "office.get_store_name_by_store_id(_store_id integer)" on the database.
        /// </summary>
        public GetStoreNameByStoreIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "office.get_store_name_by_store_id(_store_id integer)" on the database.
        /// </summary>
        /// <param name="storeId">Enter argument value for "_store_id" parameter of the function "office.get_store_name_by_store_id".</param>
        public GetStoreNameByStoreIdProcedure(int storeId)
        {
            this.StoreId = storeId;
        }
        /// <summary>
        /// Prepares and executes the function "office.get_store_name_by_store_id".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public string Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetStoreNameByStoreIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM office.get_store_name_by_store_id(@StoreId);";

            query = query.ReplaceWholeWord("@StoreId", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.StoreId);

            return Factory.Scalar<string>(this._Catalog, query, parameters.ToArray());
        }


    }
}