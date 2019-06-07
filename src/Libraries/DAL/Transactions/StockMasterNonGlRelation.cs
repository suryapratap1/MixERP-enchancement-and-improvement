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
    /// Provides simplified data access features to perform SCRUD operation on the database table "transactions.stock_master_non_gl_relations".
    /// </summary>
    public class StockMasterNonGlRelation : DbAccess, IStockMasterNonGlRelationRepository
    {
        /// <summary>
        /// The schema of this table. Returns literal "transactions".
        /// </summary>
        public override string _ObjectNamespace => "transactions";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "stock_master_non_gl_relations".
        /// </summary>
        public override string _ObjectName => "stock_master_non_gl_relations";

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
        /// Performs SQL count on the table "transactions.stock_master_non_gl_relations".
        /// </summary>
        /// <returns>Returns the number of rows of the table "transactions.stock_master_non_gl_relations".</returns>
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
                    Log.Information("Access to count entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT COUNT(*) FROM transactions.stock_master_non_gl_relations;";
            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "transactions.stock_master_non_gl_relations" to return all instances of the "StockMasterNonGlRelation" class. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "StockMasterNonGlRelation" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetAll()
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
                    Log.Information("Access to the export entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.stock_master_non_gl_relations ORDER BY stock_master_non_gl_relation_id;";
            return Factory.Get<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "transactions.stock_master_non_gl_relations" to return all instances of the "StockMasterNonGlRelation" class to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "StockMasterNonGlRelation" class.</returns>
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
                    Log.Information("Access to the export entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.stock_master_non_gl_relations ORDER BY stock_master_non_gl_relation_id;";
            return Factory.Get<dynamic>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "transactions.stock_master_non_gl_relations" with a where filter on the column "stock_master_non_gl_relation_id" to return a single instance of the "StockMasterNonGlRelation" class. 
        /// </summary>
        /// <param name="stockMasterNonGlRelationId">The column "stock_master_non_gl_relation_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of "StockMasterNonGlRelation" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Transactions.StockMasterNonGlRelation Get(long stockMasterNonGlRelationId)
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
                    Log.Information("Access to the get entity \"StockMasterNonGlRelation\" filtered by \"StockMasterNonGlRelationId\" with value {StockMasterNonGlRelationId} was denied to the user with Login ID {_LoginId}", stockMasterNonGlRelationId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.stock_master_non_gl_relations WHERE stock_master_non_gl_relation_id=@0;";
            return Factory.Get<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation>(this._Catalog, sql, stockMasterNonGlRelationId).FirstOrDefault();
        }

        /// <summary>
        /// Executes a select query on the table "transactions.stock_master_non_gl_relations" with a where filter on the column "stock_master_non_gl_relation_id" to return a multiple instances of the "StockMasterNonGlRelation" class. 
        /// </summary>
        /// <param name="stockMasterNonGlRelationIds">Array of column "stock_master_non_gl_relation_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of "StockMasterNonGlRelation" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> Get(long[] stockMasterNonGlRelationIds)
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
                    Log.Information("Access to entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}. stockMasterNonGlRelationIds: {stockMasterNonGlRelationIds}.", this._LoginId, stockMasterNonGlRelationIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.stock_master_non_gl_relations WHERE stock_master_non_gl_relation_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation>(this._Catalog, sql, stockMasterNonGlRelationIds);
        }

        /// <summary>
        /// Custom fields are user defined form elements for transactions.stock_master_non_gl_relations.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table transactions.stock_master_non_gl_relations</returns>
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
                    Log.Information("Access to get custom fields for entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
            if (string.IsNullOrWhiteSpace(resourceId))
            {
                sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='transactions.stock_master_non_gl_relations' ORDER BY field_order;";
                return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('transactions.stock_master_non_gl_relations'::text, @0::text) ORDER BY field_order;";
            return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of transactions.stock_master_non_gl_relations.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table transactions.stock_master_non_gl_relations</returns>
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
                    Log.Information("Access to get display field for entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT stock_master_non_gl_relation_id AS key, stock_master_non_gl_relation_id as value FROM transactions.stock_master_non_gl_relations;";
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
        /// Inserts or updates the instance of StockMasterNonGlRelation class on the database table "transactions.stock_master_non_gl_relations".
        /// </summary>
        /// <param name="stockMasterNonGlRelation">The instance of "StockMasterNonGlRelation" class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object AddOrEdit(dynamic stockMasterNonGlRelation, List<EntityParser.CustomField> customFields)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }



            object primaryKeyValue = stockMasterNonGlRelation.stock_master_non_gl_relation_id;

            if (Cast.To<long>(primaryKeyValue) > 0)
            {
                primaryKeyValue = stockMasterNonGlRelation.stock_master_non_gl_relation_id;
                this.Update(stockMasterNonGlRelation, long.Parse(stockMasterNonGlRelation.stock_master_non_gl_relation_id));
            }
            else
            {
                primaryKeyValue = this.Add(stockMasterNonGlRelation);
            }

            string sql = "DELETE FROM core.custom_fields WHERE custom_field_setup_id IN(" +
                         "SELECT custom_field_setup_id " +
                         "FROM core.custom_field_setup " +
                         "WHERE form_name=core.get_custom_field_form_name('transactions.stock_master_non_gl_relations')" +
                         ");";

            Factory.NonQuery(this._Catalog, sql);

            if (customFields == null)
            {
                return primaryKeyValue;
            }

            foreach (var field in customFields)
            {
                sql = "INSERT INTO core.custom_fields(custom_field_setup_id, resource_id, value) " +
                      "SELECT core.get_custom_field_setup_id_by_table_name('transactions.stock_master_non_gl_relations', @0::character varying(100)), " +
                      "@1, @2;";

                Factory.NonQuery(this._Catalog, sql, field.FieldName, primaryKeyValue, field.Value);
            }

            return primaryKeyValue;
        }

        /// <summary>
        /// Inserts the instance of StockMasterNonGlRelation class on the database table "transactions.stock_master_non_gl_relations".
        /// </summary>
        /// <param name="stockMasterNonGlRelation">The instance of "StockMasterNonGlRelation" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object Add(dynamic stockMasterNonGlRelation)
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
                    Log.Information("Access to add entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}. {StockMasterNonGlRelation}", this._LoginId, stockMasterNonGlRelation);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            return Factory.Insert(this._Catalog, stockMasterNonGlRelation, "transactions.stock_master_non_gl_relations", "stock_master_non_gl_relation_id");
        }

        /// <summary>
        /// Inserts or updates multiple instances of StockMasterNonGlRelation class on the database table "transactions.stock_master_non_gl_relations";
        /// </summary>
        /// <param name="stockMasterNonGlRelations">List of "StockMasterNonGlRelation" class to import.</param>
        /// <returns></returns>
        public List<object> BulkImport(List<ExpandoObject> stockMasterNonGlRelations)
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ImportData, this._LoginId, this._Catalog, false);
                }

                if (!this.HasAccess)
                {
                    Log.Information("Access to import entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}. {stockMasterNonGlRelations}", this._LoginId, stockMasterNonGlRelations);
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
                        foreach (dynamic stockMasterNonGlRelation in stockMasterNonGlRelations)
                        {
                            line++;



                            object primaryKeyValue = stockMasterNonGlRelation.stock_master_non_gl_relation_id;

                            if (Cast.To<long>(primaryKeyValue) > 0)
                            {
                                result.Add(stockMasterNonGlRelation.stock_master_non_gl_relation_id);
                                db.Update("transactions.stock_master_non_gl_relations", "stock_master_non_gl_relation_id", stockMasterNonGlRelation, stockMasterNonGlRelation.stock_master_non_gl_relation_id);
                            }
                            else
                            {
                                result.Add(db.Insert("transactions.stock_master_non_gl_relations", "stock_master_non_gl_relation_id", stockMasterNonGlRelation));
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
        /// Updates the row of the table "transactions.stock_master_non_gl_relations" with an instance of "StockMasterNonGlRelation" class against the primary key value.
        /// </summary>
        /// <param name="stockMasterNonGlRelation">The instance of "StockMasterNonGlRelation" class to update.</param>
        /// <param name="stockMasterNonGlRelationId">The value of the column "stock_master_non_gl_relation_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Update(dynamic stockMasterNonGlRelation, long stockMasterNonGlRelationId)
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
                    Log.Information("Access to edit entity \"StockMasterNonGlRelation\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {StockMasterNonGlRelation}", stockMasterNonGlRelationId, this._LoginId, stockMasterNonGlRelation);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Factory.Update(this._Catalog, stockMasterNonGlRelation, stockMasterNonGlRelationId, "transactions.stock_master_non_gl_relations", "stock_master_non_gl_relation_id");
        }

        /// <summary>
        /// Deletes the row of the table "transactions.stock_master_non_gl_relations" against the primary key value.
        /// </summary>
        /// <param name="stockMasterNonGlRelationId">The value of the column "stock_master_non_gl_relation_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Delete(long stockMasterNonGlRelationId)
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
                    Log.Information("Access to delete entity \"StockMasterNonGlRelation\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", stockMasterNonGlRelationId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "DELETE FROM transactions.stock_master_non_gl_relations WHERE stock_master_non_gl_relation_id=@0;";
            Factory.NonQuery(this._Catalog, sql, stockMasterNonGlRelationId);
        }

        /// <summary>
        /// Performs a select statement on table "transactions.stock_master_non_gl_relations" producing a paginated result of 10.
        /// </summary>
        /// <returns>Returns the first page of collection of "StockMasterNonGlRelation" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetPaginatedResult()
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
                    Log.Information("Access to the first page of the entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.stock_master_non_gl_relations ORDER BY stock_master_non_gl_relation_id LIMIT 10 OFFSET 0;";
            return Factory.Get<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a select statement on table "transactions.stock_master_non_gl_relations" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "StockMasterNonGlRelation" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetPaginatedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}.", pageNumber, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            const string sql = "SELECT * FROM transactions.stock_master_non_gl_relations ORDER BY stock_master_non_gl_relation_id LIMIT 10 OFFSET @0;";

            return Factory.Get<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation>(this._Catalog, sql, offset);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            const string sql = "SELECT * FROM core.filters WHERE object_name='transactions.stock_master_non_gl_relations' AND lower(filter_name)=lower(@0);";
            return Factory.Get<EntityParser.Filter>(catalog, sql, filterName).ToList();
        }

        /// <summary>
        /// Performs a filtered count on table "transactions.stock_master_non_gl_relations".
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "StockMasterNonGlRelation" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM transactions.stock_master_non_gl_relations WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.StockMasterNonGlRelation(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "transactions.stock_master_non_gl_relations" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "StockMasterNonGlRelation" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM transactions.stock_master_non_gl_relations WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.StockMasterNonGlRelation(), filters);

            sql.OrderBy("stock_master_non_gl_relation_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered count on table "transactions.stock_master_non_gl_relations".
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "StockMasterNonGlRelation" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);
            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM transactions.stock_master_non_gl_relations WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.StockMasterNonGlRelation(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "transactions.stock_master_non_gl_relations" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "StockMasterNonGlRelation" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetFiltered(long pageNumber, string filterName)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"StockMasterNonGlRelation\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", pageNumber, this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM transactions.stock_master_non_gl_relations WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.StockMasterNonGlRelation(), filters);

            sql.OrderBy("stock_master_non_gl_relation_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation>(this._Catalog, sql);
        }


    }
}