// ReSharper disable All
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using MixERP.Net.DbFactory;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using Npgsql;
using PetaPoco;
using Serilog;

namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "transactions.non_gl_stock_tax_details".
    /// </summary>
    public class NonGlStockTaxDetail : DbAccess, INonGlStockTaxDetailRepository
    {
        /// <summary>
        /// The schema of this table. Returns literal "transactions".
        /// </summary>
        public override string _ObjectNamespace => "transactions";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "non_gl_stock_tax_details".
        /// </summary>
        public override string _ObjectName => "non_gl_stock_tax_details";

        /// <summary>
        /// Login id of application user accessing this table.
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
        /// Performs SQL count on the table "transactions.non_gl_stock_tax_details".
        /// </summary>
        /// <returns>Returns the number of rows of the table "transactions.non_gl_stock_tax_details".</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public long Count()
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return 0;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to count entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT COUNT(*) FROM transactions.non_gl_stock_tax_details;";
            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "transactions.non_gl_stock_tax_details" to return all instances of the "NonGlStockTaxDetail" class. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "NonGlStockTaxDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetAll()
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ExportData, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the export entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.non_gl_stock_tax_details ORDER BY non_gl_stock_tax_detail_id;";
            return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "transactions.non_gl_stock_tax_details" to return all instances of the "NonGlStockTaxDetail" class to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "NonGlStockTaxDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<dynamic> Export()
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ExportData, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the export entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.non_gl_stock_tax_details ORDER BY non_gl_stock_tax_detail_id;";
            return Factory.Get<dynamic>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "transactions.non_gl_stock_tax_details" with a where filter on the column "non_gl_stock_tax_detail_id" to return a single instance of the "NonGlStockTaxDetail" class. 
        /// </summary>
        /// <param name="nonGlStockTaxDetailId">The column "non_gl_stock_tax_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of "NonGlStockTaxDetail" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Transactions.NonGlStockTaxDetail Get(long nonGlStockTaxDetailId)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the get entity \"NonGlStockTaxDetail\" filtered by \"NonGlStockTaxDetailId\" with value {NonGlStockTaxDetailId} was denied to the user with Login ID {_LoginId}", nonGlStockTaxDetailId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.non_gl_stock_tax_details WHERE non_gl_stock_tax_detail_id=@0;";
            return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this._Catalog, sql, nonGlStockTaxDetailId).FirstOrDefault();
        }

        /// <summary>
        /// Executes a select query on the table "transactions.non_gl_stock_tax_details" with a where filter on the column "non_gl_stock_tax_detail_id" to return a multiple instances of the "NonGlStockTaxDetail" class. 
        /// </summary>
        /// <param name="nonGlStockTaxDetailIds">Array of column "non_gl_stock_tax_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of "NonGlStockTaxDetail" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> Get(long[] nonGlStockTaxDetailIds)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}. nonGlStockTaxDetailIds: {nonGlStockTaxDetailIds}.", this._LoginId, nonGlStockTaxDetailIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.non_gl_stock_tax_details WHERE non_gl_stock_tax_detail_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this._Catalog, sql, nonGlStockTaxDetailIds);
        }

        /// <summary>
        /// Custom fields are user defined form elements for transactions.non_gl_stock_tax_details.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table transactions.non_gl_stock_tax_details</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to get custom fields for entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
            if (string.IsNullOrWhiteSpace(resourceId))
            {
                sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='transactions.non_gl_stock_tax_details' ORDER BY field_order;";
                return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('transactions.non_gl_stock_tax_details'::text, @0::text) ORDER BY field_order;";
            return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of transactions.non_gl_stock_tax_details.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table transactions.non_gl_stock_tax_details</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            List<DisplayField> displayFields = new List<DisplayField>();

            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return displayFields;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to get display field for entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT non_gl_stock_tax_detail_id AS key, non_gl_stock_tax_detail_id as value FROM transactions.non_gl_stock_tax_details;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                using (DataTable table = DbOperation.GetDataTable(this._Catalog, command))
                {
                    if (table?.Rows == null || table.Rows.Count == 0)
                    {
                        return displayFields;
                    }

                    foreach (DataRow row in table.Rows)
                    {
                        if (row != null)
                        {
                            DisplayField displayField = new DisplayField
                            {
                                Key = row["key"].ToString(),
                                Value = row["value"].ToString()
                            };

                            displayFields.Add(displayField);
                        }
                    }
                }
            }

            return displayFields;
        }

        /// <summary>
        /// Inserts or updates the instance of NonGlStockTaxDetail class on the database table "transactions.non_gl_stock_tax_details".
        /// </summary>
        /// <param name="nonGlStockTaxDetail">The instance of "NonGlStockTaxDetail" class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object AddOrEdit(dynamic nonGlStockTaxDetail, List<EntityParser.CustomField> customFields)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }



            object primaryKeyValue = nonGlStockTaxDetail.non_gl_stock_tax_detail_id;

            if (Cast.To<long>(primaryKeyValue) > 0)
            {
                primaryKeyValue = nonGlStockTaxDetail.non_gl_stock_tax_detail_id;
                this.Update(nonGlStockTaxDetail, long.Parse(nonGlStockTaxDetail.non_gl_stock_tax_detail_id));
            }
            else
            {
                primaryKeyValue = this.Add(nonGlStockTaxDetail);
            }

            string sql = "DELETE FROM core.custom_fields WHERE custom_field_setup_id IN(" +
                         "SELECT custom_field_setup_id " +
                         "FROM core.custom_field_setup " +
                         "WHERE form_name=core.get_custom_field_form_name('transactions.non_gl_stock_tax_details')" +
                         ");";

            Factory.NonQuery(this._Catalog, sql);

            if (customFields == null)
            {
                return primaryKeyValue;
            }

            foreach (var field in customFields)
            {
                sql = "INSERT INTO core.custom_fields(custom_field_setup_id, resource_id, value) " +
                      "SELECT core.get_custom_field_setup_id_by_table_name('transactions.non_gl_stock_tax_details', @0::character varying(100)), " +
                      "@1, @2;";

                Factory.NonQuery(this._Catalog, sql, field.FieldName, primaryKeyValue, field.Value);
            }

            return primaryKeyValue;
        }

        /// <summary>
        /// Inserts the instance of NonGlStockTaxDetail class on the database table "transactions.non_gl_stock_tax_details".
        /// </summary>
        /// <param name="nonGlStockTaxDetail">The instance of "NonGlStockTaxDetail" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object Add(dynamic nonGlStockTaxDetail)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Create, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to add entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}. {NonGlStockTaxDetail}", this._LoginId, nonGlStockTaxDetail);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            return Factory.Insert(this._Catalog, nonGlStockTaxDetail, "transactions.non_gl_stock_tax_details", "non_gl_stock_tax_detail_id");
        }

        /// <summary>
        /// Inserts or updates multiple instances of NonGlStockTaxDetail class on the database table "transactions.non_gl_stock_tax_details";
        /// </summary>
        /// <param name="nonGlStockTaxDetails">List of "NonGlStockTaxDetail" class to import.</param>
        /// <returns></returns>
        public List<object> BulkImport(List<ExpandoObject> nonGlStockTaxDetails)
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ImportData, this._LoginId, this._Catalog, false);
                }

                if (!this.HasAccess)
                {
                    Log.Information("Access to import entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}. {nonGlStockTaxDetails}", this._LoginId, nonGlStockTaxDetails);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            var result = new List<object>();
            int line = 0;
            try
            {
                using (Database db = new Database(Factory.GetConnectionString(this._Catalog), Factory.ProviderName))
                {
                    using (Transaction transaction = db.GetTransaction())
                    {
                        foreach (dynamic nonGlStockTaxDetail in nonGlStockTaxDetails)
                        {
                            line++;



                            object primaryKeyValue = nonGlStockTaxDetail.non_gl_stock_tax_detail_id;

                            if (Cast.To<long>(primaryKeyValue) > 0)
                            {
                                result.Add(nonGlStockTaxDetail.non_gl_stock_tax_detail_id);
                                db.Update("transactions.non_gl_stock_tax_details", "non_gl_stock_tax_detail_id", nonGlStockTaxDetail, nonGlStockTaxDetail.non_gl_stock_tax_detail_id);
                            }
                            else
                            {
                                result.Add(db.Insert("transactions.non_gl_stock_tax_details", "non_gl_stock_tax_detail_id", nonGlStockTaxDetail));
                            }
                        }

                        transaction.Complete();
                    }

                    return result;
                }
            }
            catch (NpgsqlException ex)
            {
                string errorMessage = $"Error on line {line} ";

                if (ex.Code.StartsWith("P"))
                {
                    errorMessage += Factory.GetDBErrorResource(ex);

                    throw new MixERPException(errorMessage, ex);
                }

                errorMessage += ex.Message;
                throw new MixERPException(errorMessage, ex);
            }
            catch (System.Exception ex)
            {
                string errorMessage = $"Error on line {line} ";
                throw new MixERPException(errorMessage, ex);
            }
        }

        /// <summary>
        /// Updates the row of the table "transactions.non_gl_stock_tax_details" with an instance of "NonGlStockTaxDetail" class against the primary key value.
        /// </summary>
        /// <param name="nonGlStockTaxDetail">The instance of "NonGlStockTaxDetail" class to update.</param>
        /// <param name="nonGlStockTaxDetailId">The value of the column "non_gl_stock_tax_detail_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Update(dynamic nonGlStockTaxDetail, long nonGlStockTaxDetailId)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Edit, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to edit entity \"NonGlStockTaxDetail\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {NonGlStockTaxDetail}", nonGlStockTaxDetailId, this._LoginId, nonGlStockTaxDetail);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Factory.Update(this._Catalog, nonGlStockTaxDetail, nonGlStockTaxDetailId, "transactions.non_gl_stock_tax_details", "non_gl_stock_tax_detail_id");
        }

        /// <summary>
        /// Deletes the row of the table "transactions.non_gl_stock_tax_details" against the primary key value.
        /// </summary>
        /// <param name="nonGlStockTaxDetailId">The value of the column "non_gl_stock_tax_detail_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Delete(long nonGlStockTaxDetailId)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Delete, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to delete entity \"NonGlStockTaxDetail\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", nonGlStockTaxDetailId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "DELETE FROM transactions.non_gl_stock_tax_details WHERE non_gl_stock_tax_detail_id=@0;";
            Factory.NonQuery(this._Catalog, sql, nonGlStockTaxDetailId);
        }

        /// <summary>
        /// Performs a select statement on table "transactions.non_gl_stock_tax_details" producing a paginated result of 10.
        /// </summary>
        /// <returns>Returns the first page of collection of "NonGlStockTaxDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetPaginatedResult()
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the first page of the entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.non_gl_stock_tax_details ORDER BY non_gl_stock_tax_detail_id LIMIT 10 OFFSET 0;";
            return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a select statement on table "transactions.non_gl_stock_tax_details" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "NonGlStockTaxDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetPaginatedResult(long pageNumber)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to Page #{Page} of the entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}.", pageNumber, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            const string sql = "SELECT * FROM transactions.non_gl_stock_tax_details ORDER BY non_gl_stock_tax_detail_id LIMIT 10 OFFSET @0;";

            return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this._Catalog, sql, offset);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            const string sql = "SELECT * FROM core.filters WHERE object_name='transactions.non_gl_stock_tax_details' AND lower(filter_name)=lower(@0);";
            return Factory.Get<EntityParser.Filter>(catalog, sql, filterName).ToList();
        }

        /// <summary>
        /// Performs a filtered count on table "transactions.non_gl_stock_tax_details".
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "NonGlStockTaxDetail" class using the filter.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public long CountWhere(List<EntityParser.Filter> filters)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return 0;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to count entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM transactions.non_gl_stock_tax_details WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "transactions.non_gl_stock_tax_details" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "NonGlStockTaxDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to Page #{Page} of the filtered entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM transactions.non_gl_stock_tax_details WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), filters);

            sql.OrderBy("non_gl_stock_tax_detail_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered count on table "transactions.non_gl_stock_tax_details".
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "NonGlStockTaxDetail" class using the filter.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public long CountFiltered(string filterName)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return 0;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to count entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);
            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM transactions.non_gl_stock_tax_details WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "transactions.non_gl_stock_tax_details" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "NonGlStockTaxDetail" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetFiltered(long pageNumber, string filterName)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to Page #{Page} of the filtered entity \"NonGlStockTaxDetail\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", pageNumber, this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM transactions.non_gl_stock_tax_details WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), filters);

            sql.OrderBy("non_gl_stock_tax_detail_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail>(this._Catalog, sql);
        }


    }
}