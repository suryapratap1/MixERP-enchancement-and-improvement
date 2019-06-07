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
    /// Provides simplified data access features to perform SCRUD operation on the database table "transactions.inventory_transfer_deliveries".
    /// </summary>
    public class InventoryTransferDelivery : DbAccess, IInventoryTransferDeliveryRepository
    {
        /// <summary>
        /// The schema of this table. Returns literal "transactions".
        /// </summary>
        public override string _ObjectNamespace => "transactions";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "inventory_transfer_deliveries".
        /// </summary>
        public override string _ObjectName => "inventory_transfer_deliveries";

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
        /// Performs SQL count on the table "transactions.inventory_transfer_deliveries".
        /// </summary>
        /// <returns>Returns the number of rows of the table "transactions.inventory_transfer_deliveries".</returns>
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
                    Log.Information("Access to count entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT COUNT(*) FROM transactions.inventory_transfer_deliveries;";
            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "transactions.inventory_transfer_deliveries" to return all instances of the "InventoryTransferDelivery" class. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "InventoryTransferDelivery" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetAll()
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
                    Log.Information("Access to the export entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.inventory_transfer_deliveries ORDER BY inventory_transfer_delivery_id;";
            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferDelivery>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "transactions.inventory_transfer_deliveries" to return all instances of the "InventoryTransferDelivery" class to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "InventoryTransferDelivery" class.</returns>
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
                    Log.Information("Access to the export entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.inventory_transfer_deliveries ORDER BY inventory_transfer_delivery_id;";
            return Factory.Get<dynamic>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "transactions.inventory_transfer_deliveries" with a where filter on the column "inventory_transfer_delivery_id" to return a single instance of the "InventoryTransferDelivery" class. 
        /// </summary>
        /// <param name="inventoryTransferDeliveryId">The column "inventory_transfer_delivery_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of "InventoryTransferDelivery" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Transactions.InventoryTransferDelivery Get(long inventoryTransferDeliveryId)
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
                    Log.Information("Access to the get entity \"InventoryTransferDelivery\" filtered by \"InventoryTransferDeliveryId\" with value {InventoryTransferDeliveryId} was denied to the user with Login ID {_LoginId}", inventoryTransferDeliveryId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.inventory_transfer_deliveries WHERE inventory_transfer_delivery_id=@0;";
            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferDelivery>(this._Catalog, sql, inventoryTransferDeliveryId).FirstOrDefault();
        }

        /// <summary>
        /// Executes a select query on the table "transactions.inventory_transfer_deliveries" with a where filter on the column "inventory_transfer_delivery_id" to return a multiple instances of the "InventoryTransferDelivery" class. 
        /// </summary>
        /// <param name="inventoryTransferDeliveryIds">Array of column "inventory_transfer_delivery_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of "InventoryTransferDelivery" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> Get(long[] inventoryTransferDeliveryIds)
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
                    Log.Information("Access to entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}. inventoryTransferDeliveryIds: {inventoryTransferDeliveryIds}.", this._LoginId, inventoryTransferDeliveryIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.inventory_transfer_deliveries WHERE inventory_transfer_delivery_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferDelivery>(this._Catalog, sql, inventoryTransferDeliveryIds);
        }

        /// <summary>
        /// Custom fields are user defined form elements for transactions.inventory_transfer_deliveries.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table transactions.inventory_transfer_deliveries</returns>
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
                    Log.Information("Access to get custom fields for entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
            if (string.IsNullOrWhiteSpace(resourceId))
            {
                sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='transactions.inventory_transfer_deliveries' ORDER BY field_order;";
                return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('transactions.inventory_transfer_deliveries'::text, @0::text) ORDER BY field_order;";
            return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of transactions.inventory_transfer_deliveries.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table transactions.inventory_transfer_deliveries</returns>
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
                    Log.Information("Access to get display field for entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT inventory_transfer_delivery_id AS key, inventory_transfer_delivery_id as value FROM transactions.inventory_transfer_deliveries;";
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
        /// Inserts or updates the instance of InventoryTransferDelivery class on the database table "transactions.inventory_transfer_deliveries".
        /// </summary>
        /// <param name="inventoryTransferDelivery">The instance of "InventoryTransferDelivery" class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object AddOrEdit(dynamic inventoryTransferDelivery, List<EntityParser.CustomField> customFields)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            inventoryTransferDelivery.audit_ts = System.DateTime.UtcNow;

            object primaryKeyValue = inventoryTransferDelivery.inventory_transfer_delivery_id;

            if (Cast.To<long>(primaryKeyValue) > 0)
            {
                primaryKeyValue = inventoryTransferDelivery.inventory_transfer_delivery_id;
                this.Update(inventoryTransferDelivery, long.Parse(inventoryTransferDelivery.inventory_transfer_delivery_id));
            }
            else
            {
                primaryKeyValue = this.Add(inventoryTransferDelivery);
            }

            string sql = "DELETE FROM core.custom_fields WHERE custom_field_setup_id IN(" +
                         "SELECT custom_field_setup_id " +
                         "FROM core.custom_field_setup " +
                         "WHERE form_name=core.get_custom_field_form_name('transactions.inventory_transfer_deliveries')" +
                         ");";

            Factory.NonQuery(this._Catalog, sql);

            if (customFields == null)
            {
                return primaryKeyValue;
            }

            foreach (var field in customFields)
            {
                sql = "INSERT INTO core.custom_fields(custom_field_setup_id, resource_id, value) " +
                      "SELECT core.get_custom_field_setup_id_by_table_name('transactions.inventory_transfer_deliveries', @0::character varying(100)), " +
                      "@1, @2;";

                Factory.NonQuery(this._Catalog, sql, field.FieldName, primaryKeyValue, field.Value);
            }

            return primaryKeyValue;
        }

        /// <summary>
        /// Inserts the instance of InventoryTransferDelivery class on the database table "transactions.inventory_transfer_deliveries".
        /// </summary>
        /// <param name="inventoryTransferDelivery">The instance of "InventoryTransferDelivery" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object Add(dynamic inventoryTransferDelivery)
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
                    Log.Information("Access to add entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}. {InventoryTransferDelivery}", this._LoginId, inventoryTransferDelivery);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            return Factory.Insert(this._Catalog, inventoryTransferDelivery, "transactions.inventory_transfer_deliveries", "inventory_transfer_delivery_id");
        }

        /// <summary>
        /// Inserts or updates multiple instances of InventoryTransferDelivery class on the database table "transactions.inventory_transfer_deliveries";
        /// </summary>
        /// <param name="inventoryTransferDeliveries">List of "InventoryTransferDelivery" class to import.</param>
        /// <returns></returns>
        public List<object> BulkImport(List<ExpandoObject> inventoryTransferDeliveries)
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ImportData, this._LoginId, this._Catalog, false);
                }

                if (!this.HasAccess)
                {
                    Log.Information("Access to import entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}. {inventoryTransferDeliveries}", this._LoginId, inventoryTransferDeliveries);
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
                        foreach (dynamic inventoryTransferDelivery in inventoryTransferDeliveries)
                        {
                            line++;

                            inventoryTransferDelivery.audit_ts = System.DateTime.UtcNow;

                            object primaryKeyValue = inventoryTransferDelivery.inventory_transfer_delivery_id;

                            if (Cast.To<long>(primaryKeyValue) > 0)
                            {
                                result.Add(inventoryTransferDelivery.inventory_transfer_delivery_id);
                                db.Update("transactions.inventory_transfer_deliveries", "inventory_transfer_delivery_id", inventoryTransferDelivery, inventoryTransferDelivery.inventory_transfer_delivery_id);
                            }
                            else
                            {
                                result.Add(db.Insert("transactions.inventory_transfer_deliveries", "inventory_transfer_delivery_id", inventoryTransferDelivery));
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
        /// Updates the row of the table "transactions.inventory_transfer_deliveries" with an instance of "InventoryTransferDelivery" class against the primary key value.
        /// </summary>
        /// <param name="inventoryTransferDelivery">The instance of "InventoryTransferDelivery" class to update.</param>
        /// <param name="inventoryTransferDeliveryId">The value of the column "inventory_transfer_delivery_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Update(dynamic inventoryTransferDelivery, long inventoryTransferDeliveryId)
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
                    Log.Information("Access to edit entity \"InventoryTransferDelivery\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {InventoryTransferDelivery}", inventoryTransferDeliveryId, this._LoginId, inventoryTransferDelivery);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Factory.Update(this._Catalog, inventoryTransferDelivery, inventoryTransferDeliveryId, "transactions.inventory_transfer_deliveries", "inventory_transfer_delivery_id");
        }

        /// <summary>
        /// Deletes the row of the table "transactions.inventory_transfer_deliveries" against the primary key value.
        /// </summary>
        /// <param name="inventoryTransferDeliveryId">The value of the column "inventory_transfer_delivery_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Delete(long inventoryTransferDeliveryId)
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
                    Log.Information("Access to delete entity \"InventoryTransferDelivery\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", inventoryTransferDeliveryId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "DELETE FROM transactions.inventory_transfer_deliveries WHERE inventory_transfer_delivery_id=@0;";
            Factory.NonQuery(this._Catalog, sql, inventoryTransferDeliveryId);
        }

        /// <summary>
        /// Performs a select statement on table "transactions.inventory_transfer_deliveries" producing a paginated result of 10.
        /// </summary>
        /// <returns>Returns the first page of collection of "InventoryTransferDelivery" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetPaginatedResult()
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
                    Log.Information("Access to the first page of the entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM transactions.inventory_transfer_deliveries ORDER BY inventory_transfer_delivery_id LIMIT 10 OFFSET 0;";
            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferDelivery>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a select statement on table "transactions.inventory_transfer_deliveries" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "InventoryTransferDelivery" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetPaginatedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}.", pageNumber, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            const string sql = "SELECT * FROM transactions.inventory_transfer_deliveries ORDER BY inventory_transfer_delivery_id LIMIT 10 OFFSET @0;";

            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferDelivery>(this._Catalog, sql, offset);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            const string sql = "SELECT * FROM core.filters WHERE object_name='transactions.inventory_transfer_deliveries' AND lower(filter_name)=lower(@0);";
            return Factory.Get<EntityParser.Filter>(catalog, sql, filterName).ToList();
        }

        /// <summary>
        /// Performs a filtered count on table "transactions.inventory_transfer_deliveries".
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "InventoryTransferDelivery" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM transactions.inventory_transfer_deliveries WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.InventoryTransferDelivery(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "transactions.inventory_transfer_deliveries" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "InventoryTransferDelivery" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM transactions.inventory_transfer_deliveries WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.InventoryTransferDelivery(), filters);

            sql.OrderBy("inventory_transfer_delivery_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferDelivery>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered count on table "transactions.inventory_transfer_deliveries".
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "InventoryTransferDelivery" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);
            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM transactions.inventory_transfer_deliveries WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.InventoryTransferDelivery(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "transactions.inventory_transfer_deliveries" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "InventoryTransferDelivery" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetFiltered(long pageNumber, string filterName)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"InventoryTransferDelivery\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", pageNumber, this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM transactions.inventory_transfer_deliveries WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Transactions.InventoryTransferDelivery(), filters);

            sql.OrderBy("inventory_transfer_delivery_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Transactions.InventoryTransferDelivery>(this._Catalog, sql);
        }


    }
}