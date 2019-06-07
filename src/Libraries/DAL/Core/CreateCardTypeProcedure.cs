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
    /// Prepares, validates, and executes the function "core.create_card_type(_card_type_id integer, _card_type_code character varying, _card_type_name character varying)" on the database.
    /// </summary>
    public class CreateCardTypeProcedure : DbAccess, ICreateCardTypeRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_card_type";
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
        /// Maps to "_card_type_id" argument of the function "core.create_card_type".
        /// </summary>
        public int CardTypeId { get; set; }
        /// <summary>
        /// Maps to "_card_type_code" argument of the function "core.create_card_type".
        /// </summary>
        public string CardTypeCode { get; set; }
        /// <summary>
        /// Maps to "_card_type_name" argument of the function "core.create_card_type".
        /// </summary>
        public string CardTypeName { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_card_type(_card_type_id integer, _card_type_code character varying, _card_type_name character varying)" on the database.
        /// </summary>
        public CreateCardTypeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_card_type(_card_type_id integer, _card_type_code character varying, _card_type_name character varying)" on the database.
        /// </summary>
        /// <param name="cardTypeId">Enter argument value for "_card_type_id" parameter of the function "core.create_card_type".</param>
        /// <param name="cardTypeCode">Enter argument value for "_card_type_code" parameter of the function "core.create_card_type".</param>
        /// <param name="cardTypeName">Enter argument value for "_card_type_name" parameter of the function "core.create_card_type".</param>
        public CreateCardTypeProcedure(int cardTypeId, string cardTypeCode, string cardTypeName)
        {
            this.CardTypeId = cardTypeId;
            this.CardTypeCode = cardTypeCode;
            this.CardTypeName = cardTypeName;
        }
        /// <summary>
        /// Prepares and executes the function "core.create_card_type".
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
                    Log.Information("Access to the function \"CreateCardTypeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.create_card_type(@CardTypeId, @CardTypeCode, @CardTypeName);";

            query = query.ReplaceWholeWord("@CardTypeId", "@0::integer");
            query = query.ReplaceWholeWord("@CardTypeCode", "@1::character varying");
            query = query.ReplaceWholeWord("@CardTypeName", "@2::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.CardTypeId);
            parameters.Add(this.CardTypeCode);
            parameters.Add(this.CardTypeName);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}