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
    /// Prepares, validates, and executes the function "core.get_state_id_by_shipping_address_code(pg_arg0 text, pg_arg1 bigint)" on the database.
    /// </summary>
    public class GetStateIdByShippingAddressCodeProcedure : DbAccess, IGetStateIdByShippingAddressCodeRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_state_id_by_shipping_address_code";
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
        /// Maps to "pg_arg0" argument of the function "core.get_state_id_by_shipping_address_code".
        /// </summary>
        public string PgArg0 { get; set; }
        /// <summary>
        /// Maps to "pg_arg1" argument of the function "core.get_state_id_by_shipping_address_code".
        /// </summary>
        public long PgArg1 { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_state_id_by_shipping_address_code(pg_arg0 text, pg_arg1 bigint)" on the database.
        /// </summary>
        public GetStateIdByShippingAddressCodeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_state_id_by_shipping_address_code(pg_arg0 text, pg_arg1 bigint)" on the database.
        /// </summary>
        /// <param name="pgArg0">Enter argument value for "pg_arg0" parameter of the function "core.get_state_id_by_shipping_address_code".</param>
        /// <param name="pgArg1">Enter argument value for "pg_arg1" parameter of the function "core.get_state_id_by_shipping_address_code".</param>
        public GetStateIdByShippingAddressCodeProcedure(string pgArg0, long pgArg1)
        {
            this.PgArg0 = pgArg0;
            this.PgArg1 = pgArg1;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_state_id_by_shipping_address_code".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public int Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetStateIdByShippingAddressCodeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_state_id_by_shipping_address_code(@PgArg0, @PgArg1);";

            query = query.ReplaceWholeWord("@PgArg0", "@0::text");
            query = query.ReplaceWholeWord("@PgArg1", "@1::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.PgArg0);
            parameters.Add(this.PgArg1);

            return Factory.Scalar<int>(this._Catalog, query, parameters.ToArray());
        }


    }
}