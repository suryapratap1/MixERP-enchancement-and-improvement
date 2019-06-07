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
    /// Prepares, validates, and executes the function "core.create_payment_card(_payment_card_code character varying, _payment_card_name character varying, _card_type_id integer)" on the database.
    /// </summary>
    public class CreatePaymentCardProcedure : DbAccess, ICreatePaymentCardRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_payment_card";
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
        /// Maps to "_payment_card_code" argument of the function "core.create_payment_card".
        /// </summary>
        public string PaymentCardCode { get; set; }
        /// <summary>
        /// Maps to "_payment_card_name" argument of the function "core.create_payment_card".
        /// </summary>
        public string PaymentCardName { get; set; }
        /// <summary>
        /// Maps to "_card_type_id" argument of the function "core.create_payment_card".
        /// </summary>
        public int CardTypeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_payment_card(_payment_card_code character varying, _payment_card_name character varying, _card_type_id integer)" on the database.
        /// </summary>
        public CreatePaymentCardProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_payment_card(_payment_card_code character varying, _payment_card_name character varying, _card_type_id integer)" on the database.
        /// </summary>
        /// <param name="paymentCardCode">Enter argument value for "_payment_card_code" parameter of the function "core.create_payment_card".</param>
        /// <param name="paymentCardName">Enter argument value for "_payment_card_name" parameter of the function "core.create_payment_card".</param>
        /// <param name="cardTypeId">Enter argument value for "_card_type_id" parameter of the function "core.create_payment_card".</param>
        public CreatePaymentCardProcedure(string paymentCardCode, string paymentCardName, int cardTypeId)
        {
            this.PaymentCardCode = paymentCardCode;
            this.PaymentCardName = paymentCardName;
            this.CardTypeId = cardTypeId;
        }
        /// <summary>
        /// Prepares and executes the function "core.create_payment_card".
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
                    Log.Information("Access to the function \"CreatePaymentCardProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.create_payment_card(@PaymentCardCode, @PaymentCardName, @CardTypeId);";

            query = query.ReplaceWholeWord("@PaymentCardCode", "@0::character varying");
            query = query.ReplaceWholeWord("@PaymentCardName", "@1::character varying");
            query = query.ReplaceWholeWord("@CardTypeId", "@2::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.PaymentCardCode);
            parameters.Add(this.PaymentCardName);
            parameters.Add(this.CardTypeId);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}