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
    /// Prepares, validates, and executes the function "office.count_item_in_stock(item_id_ integer, unit_id_ integer, office_id_ integer)" on the database.
    /// </summary>
    public class CountItemInStockProcedure : DbAccess, ICountItemInStockRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "count_item_in_stock";
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
        /// Maps to "item_id_" argument of the function "office.count_item_in_stock".
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Maps to "unit_id_" argument of the function "office.count_item_in_stock".
        /// </summary>
        public int UnitId { get; set; }
        /// <summary>
        /// Maps to "office_id_" argument of the function "office.count_item_in_stock".
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "office.count_item_in_stock(item_id_ integer, unit_id_ integer, office_id_ integer)" on the database.
        /// </summary>
        public CountItemInStockProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "office.count_item_in_stock(item_id_ integer, unit_id_ integer, office_id_ integer)" on the database.
        /// </summary>
        /// <param name="itemId">Enter argument value for "item_id_" parameter of the function "office.count_item_in_stock".</param>
        /// <param name="unitId">Enter argument value for "unit_id_" parameter of the function "office.count_item_in_stock".</param>
        /// <param name="officeId">Enter argument value for "office_id_" parameter of the function "office.count_item_in_stock".</param>
        public CountItemInStockProcedure(int itemId, int unitId, int officeId)
        {
            this.ItemId = itemId;
            this.UnitId = unitId;
            this.OfficeId = officeId;
        }
        /// <summary>
        /// Prepares and executes the function "office.count_item_in_stock".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public decimal Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"CountItemInStockProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM office.count_item_in_stock(@ItemId, @UnitId, @OfficeId);";

            query = query.ReplaceWholeWord("@ItemId", "@0::integer");
            query = query.ReplaceWholeWord("@UnitId", "@1::integer");
            query = query.ReplaceWholeWord("@OfficeId", "@2::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.ItemId);
            parameters.Add(this.UnitId);
            parameters.Add(this.OfficeId);

            return Factory.Scalar<decimal>(this._Catalog, query, parameters.ToArray());
        }


    }
}