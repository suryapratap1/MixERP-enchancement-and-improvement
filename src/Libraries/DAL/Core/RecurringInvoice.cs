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

namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "core.recurring_invoices".
    /// </summary>
    public class RecurringInvoice : DbAccess, IRecurringInvoiceRepository
    {
        /// <summary>
        /// The schema of this table. Returns literal "core".
        /// </summary>
        public override string _ObjectNamespace => "core";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "recurring_invoices".
        /// </summary>
        public override string _ObjectName => "recurring_invoices";

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
        /// Performs SQL count on the table "core.recurring_invoices".
        /// </summary>
        /// <returns>Returns the number of rows of the table "core.recurring_invoices".</returns>
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
                    Log.Information("Access to count entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT COUNT(*) FROM core.recurring_invoices;";
            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "core.recurring_invoices" to return all instances of the "RecurringInvoice" class. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "RecurringInvoice" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetAll()
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
                    Log.Information("Access to the export entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.recurring_invoices ORDER BY recurring_invoice_id;";
            return Factory.Get<MixERP.Net.Entities.Core.RecurringInvoice>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "core.recurring_invoices" to return all instances of the "RecurringInvoice" class to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "RecurringInvoice" class.</returns>
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
                    Log.Information("Access to the export entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.recurring_invoices ORDER BY recurring_invoice_id;";
            return Factory.Get<dynamic>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "core.recurring_invoices" with a where filter on the column "recurring_invoice_id" to return a single instance of the "RecurringInvoice" class. 
        /// </summary>
        /// <param name="recurringInvoiceId">The column "recurring_invoice_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of "RecurringInvoice" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.RecurringInvoice Get(int recurringInvoiceId)
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
                    Log.Information("Access to the get entity \"RecurringInvoice\" filtered by \"RecurringInvoiceId\" with value {RecurringInvoiceId} was denied to the user with Login ID {_LoginId}", recurringInvoiceId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.recurring_invoices WHERE recurring_invoice_id=@0;";
            return Factory.Get<MixERP.Net.Entities.Core.RecurringInvoice>(this._Catalog, sql, recurringInvoiceId).FirstOrDefault();
        }

        /// <summary>
        /// Gets the first record of the table "core.recurring_invoices". 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of "RecurringInvoice" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.RecurringInvoice GetFirst()
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
                    Log.Information("Access to the get the first record of entity \"RecurringInvoice\" was denied to the user with Login ID {_LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.recurring_invoices ORDER BY recurring_invoice_id LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.RecurringInvoice>(this._Catalog, sql).FirstOrDefault();
        }

        /// <summary>
        /// Gets the previous record of the table "core.recurring_invoices" sorted by recurringInvoiceId.
        /// </summary>
        /// <param name="recurringInvoiceId">The column "recurring_invoice_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of "RecurringInvoice" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.RecurringInvoice GetPrevious(int recurringInvoiceId)
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
                    Log.Information("Access to the get the previous entity of \"RecurringInvoice\" by \"RecurringInvoiceId\" with value {RecurringInvoiceId} was denied to the user with Login ID {_LoginId}", recurringInvoiceId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.recurring_invoices WHERE recurring_invoice_id < @0 ORDER BY recurring_invoice_id DESC LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.RecurringInvoice>(this._Catalog, sql, recurringInvoiceId).FirstOrDefault();
        }

        /// <summary>
        /// Gets the next record of the table "core.recurring_invoices" sorted by recurringInvoiceId.
        /// </summary>
        /// <param name="recurringInvoiceId">The column "recurring_invoice_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of "RecurringInvoice" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.RecurringInvoice GetNext(int recurringInvoiceId)
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
                    Log.Information("Access to the get the next entity of \"RecurringInvoice\" by \"RecurringInvoiceId\" with value {RecurringInvoiceId} was denied to the user with Login ID {_LoginId}", recurringInvoiceId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.recurring_invoices WHERE recurring_invoice_id > @0 ORDER BY recurring_invoice_id LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.RecurringInvoice>(this._Catalog, sql, recurringInvoiceId).FirstOrDefault();
        }


        /// <summary>
        /// Gets the last record of the table "core.recurring_invoices". 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of "RecurringInvoice" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.RecurringInvoice GetLast()
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
                    Log.Information("Access to the get the last record of entity \"RecurringInvoice\" was denied to the user with Login ID {_LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.recurring_invoices ORDER BY recurring_invoice_id DESC LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.RecurringInvoice>(this._Catalog, sql).FirstOrDefault();
        }

        /// <summary>
        /// Executes a select query on the table "core.recurring_invoices" with a where filter on the column "recurring_invoice_id" to return a multiple instances of the "RecurringInvoice" class. 
        /// </summary>
        /// <param name="recurringInvoiceIds">Array of column "recurring_invoice_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of "RecurringInvoice" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> Get(int[] recurringInvoiceIds)
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
                    Log.Information("Access to entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}. recurringInvoiceIds: {recurringInvoiceIds}.", this._LoginId, recurringInvoiceIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.recurring_invoices WHERE recurring_invoice_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Core.RecurringInvoice>(this._Catalog, sql, recurringInvoiceIds);
        }

        /// <summary>
        /// Custom fields are user defined form elements for core.recurring_invoices.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table core.recurring_invoices</returns>
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
                    Log.Information("Access to get custom fields for entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
            if (string.IsNullOrWhiteSpace(resourceId))
            {
                sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='core.recurring_invoices' ORDER BY field_order;";
                return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('core.recurring_invoices'::text, @0::text) ORDER BY field_order;";
            return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of core.recurring_invoices.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table core.recurring_invoices</returns>
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
                    Log.Information("Access to get display field for entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT recurring_invoice_id AS key, recurring_invoice_code || ' (' || recurring_invoice_name || ')' as value FROM core.recurring_invoices;";
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
        /// Inserts or updates the instance of RecurringInvoice class on the database table "core.recurring_invoices".
        /// </summary>
        /// <param name="recurringInvoice">The instance of "RecurringInvoice" class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object AddOrEdit(dynamic recurringInvoice, List<EntityParser.CustomField> customFields)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            recurringInvoice.audit_user_id = this._UserId;
            recurringInvoice.audit_ts = System.DateTime.UtcNow;

            object primaryKeyValue = recurringInvoice.recurring_invoice_id;

            if (Cast.To<int>(primaryKeyValue) > 0)
            {
                primaryKeyValue = recurringInvoice.recurring_invoice_id;
                this.Update(recurringInvoice, int.Parse(recurringInvoice.recurring_invoice_id));
            }
            else
            {
                primaryKeyValue = this.Add(recurringInvoice);
            }

            string sql = "DELETE FROM core.custom_fields WHERE custom_field_setup_id IN(" +
                         "SELECT custom_field_setup_id " +
                         "FROM core.custom_field_setup " +
                         "WHERE form_name=core.get_custom_field_form_name('core.recurring_invoices')" +
                         ");";

            Factory.NonQuery(this._Catalog, sql);

            if (customFields == null)
            {
                return primaryKeyValue;
            }

            foreach (var field in customFields)
            {
                sql = "INSERT INTO core.custom_fields(custom_field_setup_id, resource_id, value) " +
                      "SELECT core.get_custom_field_setup_id_by_table_name('core.recurring_invoices', @0::character varying(100)), " +
                      "@1, @2;";

                Factory.NonQuery(this._Catalog, sql, field.FieldName, primaryKeyValue, field.Value);
            }

            return primaryKeyValue;
        }

        /// <summary>
        /// Inserts the instance of RecurringInvoice class on the database table "core.recurring_invoices".
        /// </summary>
        /// <param name="recurringInvoice">The instance of "RecurringInvoice" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object Add(dynamic recurringInvoice)
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
                    Log.Information("Access to add entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}. {RecurringInvoice}", this._LoginId, recurringInvoice);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            return Factory.Insert(this._Catalog, recurringInvoice, "core.recurring_invoices", "recurring_invoice_id");
        }

        /// <summary>
        /// Inserts or updates multiple instances of RecurringInvoice class on the database table "core.recurring_invoices";
        /// </summary>
        /// <param name="recurringInvoices">List of "RecurringInvoice" class to import.</param>
        /// <returns></returns>
        public List<object> BulkImport(List<ExpandoObject> recurringInvoices)
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ImportData, this._LoginId, this._Catalog, false);
                }

                if (!this.HasAccess)
                {
                    Log.Information("Access to import entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}. {recurringInvoices}", this._LoginId, recurringInvoices);
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
                        foreach (dynamic recurringInvoice in recurringInvoices)
                        {
                            line++;

                            recurringInvoice.audit_user_id = this._UserId;
                            recurringInvoice.audit_ts = System.DateTime.UtcNow;

                            object primaryKeyValue = recurringInvoice.recurring_invoice_id;

                            if (Cast.To<int>(primaryKeyValue) > 0)
                            {
                                result.Add(recurringInvoice.recurring_invoice_id);
                                db.Update("core.recurring_invoices", "recurring_invoice_id", recurringInvoice, recurringInvoice.recurring_invoice_id);
                            }
                            else
                            {
                                result.Add(db.Insert("core.recurring_invoices", "recurring_invoice_id", recurringInvoice));
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
        /// Updates the row of the table "core.recurring_invoices" with an instance of "RecurringInvoice" class against the primary key value.
        /// </summary>
        /// <param name="recurringInvoice">The instance of "RecurringInvoice" class to update.</param>
        /// <param name="recurringInvoiceId">The value of the column "recurring_invoice_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Update(dynamic recurringInvoice, int recurringInvoiceId)
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
                    Log.Information("Access to edit entity \"RecurringInvoice\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {RecurringInvoice}", recurringInvoiceId, this._LoginId, recurringInvoice);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Factory.Update(this._Catalog, recurringInvoice, recurringInvoiceId, "core.recurring_invoices", "recurring_invoice_id");
        }

        /// <summary>
        /// Deletes the row of the table "core.recurring_invoices" against the primary key value.
        /// </summary>
        /// <param name="recurringInvoiceId">The value of the column "recurring_invoice_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Delete(int recurringInvoiceId)
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
                    Log.Information("Access to delete entity \"RecurringInvoice\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", recurringInvoiceId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "DELETE FROM core.recurring_invoices WHERE recurring_invoice_id=@0;";
            Factory.NonQuery(this._Catalog, sql, recurringInvoiceId);
        }

        /// <summary>
        /// Performs a select statement on table "core.recurring_invoices" producing a paginated result of 10.
        /// </summary>
        /// <returns>Returns the first page of collection of "RecurringInvoice" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetPaginatedResult()
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
                    Log.Information("Access to the first page of the entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.recurring_invoices ORDER BY recurring_invoice_id LIMIT 10 OFFSET 0;";
            return Factory.Get<MixERP.Net.Entities.Core.RecurringInvoice>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a select statement on table "core.recurring_invoices" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "RecurringInvoice" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetPaginatedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}.", pageNumber, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            const string sql = "SELECT * FROM core.recurring_invoices ORDER BY recurring_invoice_id LIMIT 10 OFFSET @0;";

            return Factory.Get<MixERP.Net.Entities.Core.RecurringInvoice>(this._Catalog, sql, offset);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            const string sql = "SELECT * FROM core.filters WHERE object_name='core.recurring_invoices' AND lower(filter_name)=lower(@0);";
            return Factory.Get<EntityParser.Filter>(catalog, sql, filterName).ToList();
        }

        /// <summary>
        /// Performs a filtered count on table "core.recurring_invoices".
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "RecurringInvoice" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM core.recurring_invoices WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.RecurringInvoice(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "core.recurring_invoices" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "RecurringInvoice" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM core.recurring_invoices WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.RecurringInvoice(), filters);

            sql.OrderBy("recurring_invoice_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Core.RecurringInvoice>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered count on table "core.recurring_invoices".
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "RecurringInvoice" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);
            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM core.recurring_invoices WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.RecurringInvoice(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "core.recurring_invoices" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "RecurringInvoice" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetFiltered(long pageNumber, string filterName)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"RecurringInvoice\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", pageNumber, this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM core.recurring_invoices WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.RecurringInvoice(), filters);

            sql.OrderBy("recurring_invoice_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Core.RecurringInvoice>(this._Catalog, sql);
        }


    }
}