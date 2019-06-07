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
    /// Prepares, validates, and executes the function "transactions.post_purhcase_reorder(_value_date date, _login_id bigint, _user_id integer, _office_id integer, _details transactions.purchase_reorder_type[])" on the database.
    /// </summary>
    public class PostPurhcaseReorderProcedure : DbAccess, IPostPurhcaseReorderRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "post_purhcase_reorder";
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
        /// Maps to "_value_date" argument of the function "transactions.post_purhcase_reorder".
        /// </summary>
        public DateTime ValueDate { get; set; }
        /// <summary>
        /// Maps to "_login_id" argument of the function "transactions.post_purhcase_reorder".
        /// </summary>
        public long LoginId { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "transactions.post_purhcase_reorder".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.post_purhcase_reorder".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_details" argument of the function "transactions.post_purhcase_reorder".
        /// </summary>
        public MixERP.Net.Entities.Transactions.PurchaseReorderType[] Details { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.post_purhcase_reorder(_value_date date, _login_id bigint, _user_id integer, _office_id integer, _details transactions.purchase_reorder_type[])" on the database.
        /// </summary>
        public PostPurhcaseReorderProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.post_purhcase_reorder(_value_date date, _login_id bigint, _user_id integer, _office_id integer, _details transactions.purchase_reorder_type[])" on the database.
        /// </summary>
        /// <param name="valueDate">Enter argument value for "_value_date" parameter of the function "transactions.post_purhcase_reorder".</param>
        /// <param name="loginId">Enter argument value for "_login_id" parameter of the function "transactions.post_purhcase_reorder".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.post_purhcase_reorder".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.post_purhcase_reorder".</param>
        /// <param name="details">Enter argument value for "_details" parameter of the function "transactions.post_purhcase_reorder".</param>
        public PostPurhcaseReorderProcedure(DateTime valueDate, long loginId, int userId, int officeId, MixERP.Net.Entities.Transactions.PurchaseReorderType[] details)
        {
            this.ValueDate = valueDate;
            this.LoginId = loginId;
            this.UserId = userId;
            this.OfficeId = officeId;
            this.Details = details;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.post_purhcase_reorder".
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
                    Log.Information("Access to the function \"PostPurhcaseReorderProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.post_purhcase_reorder(@ValueDate, @LoginId, @UserId, @OfficeId, @Details);";

            query = query.ReplaceWholeWord("@ValueDate", "@0::date");
            query = query.ReplaceWholeWord("@LoginId", "@1::bigint");
            query = query.ReplaceWholeWord("@UserId", "@2::integer");
            query = query.ReplaceWholeWord("@OfficeId", "@3::integer");

            int detailsOffset = 4;
            query = query.ReplaceWholeWord("@Details", "ARRAY[" + this.SqlForDetails(this.Details, detailsOffset, 6) + "]");


            List<object> parameters = new List<object>();
            parameters.Add(this.ValueDate);
            parameters.Add(this.LoginId);
            parameters.Add(this.UserId);
            parameters.Add(this.OfficeId);
            parameters.AddRange(this.ParamsForDetails(this.Details));

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }

        private string SqlForDetails(MixERP.Net.Entities.Transactions.PurchaseReorderType[] details, int offset, int memberCount)
        {
            if (details == null)
            {
                return "NULL::transactions.purchase_reorder_type";
            }
            List<string> parameters = new List<string>();
            for (int i = 0; i < details.Count(); i++)
            {
                List<string> args = new List<string>();
                for (int j = 0; j < memberCount; j++)
                {
                    args.Add("@" + offset);
                    offset++;
                }

                string parameter = "ROW({0})::transactions.purchase_reorder_type";
                parameter = string.Format(System.Globalization.CultureInfo.InvariantCulture, parameter,
                    string.Join(",", args));
                parameters.Add(parameter);
            }
            return string.Join(",", parameters);
        }

        private List<object> ParamsForDetails(MixERP.Net.Entities.Transactions.PurchaseReorderType[] details)
        {
            List<object> collection = new List<object>();

            if (details != null && details.Count() > 0)
            {
                foreach (MixERP.Net.Entities.Transactions.PurchaseReorderType detail in details)
                {
                    collection.Add(detail.ItemId);
                    collection.Add(detail.SupplierCode);
                    collection.Add(detail.UnitId);
                    collection.Add(detail.Price);
                    collection.Add(detail.TaxCode);
                    collection.Add(detail.OrderQuantity);
                    collection.Add(detail);
                }
            }
            return collection;
        }
    }
}