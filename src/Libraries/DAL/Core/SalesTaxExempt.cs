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
    /// Provides simplified data access features to perform SCRUD operation on the database table "core.sales_tax_exempts".
    /// </summary>
    public class SalesTaxExempt : DbAccess, ISalesTaxExemptRepository
    {
        /// <summary>
        /// The schema of this table. Returns literal "core".
        /// </summary>
        public override string _ObjectNamespace => "core";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "sales_tax_exempts".
        /// </summary>
        public override string _ObjectName => "sales_tax_exempts";

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
        /// Performs SQL count on the table "core.sales_tax_exempts".
        /// </summary>
        /// <returns>Returns the number of rows of the table "core.sales_tax_exempts".</returns>
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
                    Log.Information("Access to count entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT COUNT(*) FROM core.sales_tax_exempts;";
            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "core.sales_tax_exempts" to return all instances of the "SalesTaxExempt" class. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesTaxExempt" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetAll()
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
                    Log.Information("Access to the export entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.sales_tax_exempts ORDER BY sales_tax_exempt_id;";
            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "core.sales_tax_exempts" to return all instances of the "SalesTaxExempt" class to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesTaxExempt" class.</returns>
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
                    Log.Information("Access to the export entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.sales_tax_exempts ORDER BY sales_tax_exempt_id;";
            return Factory.Get<dynamic>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "core.sales_tax_exempts" with a where filter on the column "sales_tax_exempt_id" to return a single instance of the "SalesTaxExempt" class. 
        /// </summary>
        /// <param name="salesTaxExemptId">The column "sales_tax_exempt_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of "SalesTaxExempt" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.SalesTaxExempt Get(int salesTaxExemptId)
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
                    Log.Information("Access to the get entity \"SalesTaxExempt\" filtered by \"SalesTaxExemptId\" with value {SalesTaxExemptId} was denied to the user with Login ID {_LoginId}", salesTaxExemptId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.sales_tax_exempts WHERE sales_tax_exempt_id=@0;";
            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this._Catalog, sql, salesTaxExemptId).FirstOrDefault();
        }

        /// <summary>
        /// Gets the first record of the table "core.sales_tax_exempts". 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of "SalesTaxExempt" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.SalesTaxExempt GetFirst()
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
                    Log.Information("Access to the get the first record of entity \"SalesTaxExempt\" was denied to the user with Login ID {_LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.sales_tax_exempts ORDER BY sales_tax_exempt_id LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this._Catalog, sql).FirstOrDefault();
        }

        /// <summary>
        /// Gets the previous record of the table "core.sales_tax_exempts" sorted by salesTaxExemptId.
        /// </summary>
        /// <param name="salesTaxExemptId">The column "sales_tax_exempt_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of "SalesTaxExempt" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.SalesTaxExempt GetPrevious(int salesTaxExemptId)
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
                    Log.Information("Access to the get the previous entity of \"SalesTaxExempt\" by \"SalesTaxExemptId\" with value {SalesTaxExemptId} was denied to the user with Login ID {_LoginId}", salesTaxExemptId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.sales_tax_exempts WHERE sales_tax_exempt_id < @0 ORDER BY sales_tax_exempt_id DESC LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this._Catalog, sql, salesTaxExemptId).FirstOrDefault();
        }

        /// <summary>
        /// Gets the next record of the table "core.sales_tax_exempts" sorted by salesTaxExemptId.
        /// </summary>
        /// <param name="salesTaxExemptId">The column "sales_tax_exempt_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of "SalesTaxExempt" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.SalesTaxExempt GetNext(int salesTaxExemptId)
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
                    Log.Information("Access to the get the next entity of \"SalesTaxExempt\" by \"SalesTaxExemptId\" with value {SalesTaxExemptId} was denied to the user with Login ID {_LoginId}", salesTaxExemptId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.sales_tax_exempts WHERE sales_tax_exempt_id > @0 ORDER BY sales_tax_exempt_id LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this._Catalog, sql, salesTaxExemptId).FirstOrDefault();
        }


        /// <summary>
        /// Gets the last record of the table "core.sales_tax_exempts". 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of "SalesTaxExempt" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.SalesTaxExempt GetLast()
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
                    Log.Information("Access to the get the last record of entity \"SalesTaxExempt\" was denied to the user with Login ID {_LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.sales_tax_exempts ORDER BY sales_tax_exempt_id DESC LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this._Catalog, sql).FirstOrDefault();
        }

        /// <summary>
        /// Executes a select query on the table "core.sales_tax_exempts" with a where filter on the column "sales_tax_exempt_id" to return a multiple instances of the "SalesTaxExempt" class. 
        /// </summary>
        /// <param name="salesTaxExemptIds">Array of column "sales_tax_exempt_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of "SalesTaxExempt" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> Get(int[] salesTaxExemptIds)
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
                    Log.Information("Access to entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}. salesTaxExemptIds: {salesTaxExemptIds}.", this._LoginId, salesTaxExemptIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.sales_tax_exempts WHERE sales_tax_exempt_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this._Catalog, sql, salesTaxExemptIds);
        }

        /// <summary>
        /// Custom fields are user defined form elements for core.sales_tax_exempts.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table core.sales_tax_exempts</returns>
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
                    Log.Information("Access to get custom fields for entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
            if (string.IsNullOrWhiteSpace(resourceId))
            {
                sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='core.sales_tax_exempts' ORDER BY field_order;";
                return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('core.sales_tax_exempts'::text, @0::text) ORDER BY field_order;";
            return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of core.sales_tax_exempts.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table core.sales_tax_exempts</returns>
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
                    Log.Information("Access to get display field for entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT sales_tax_exempt_id AS key, sales_tax_exempt_code || ' (' || sales_tax_exempt_name || ')' as value FROM core.sales_tax_exempts;";
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
        /// Inserts or updates the instance of SalesTaxExempt class on the database table "core.sales_tax_exempts".
        /// </summary>
        /// <param name="salesTaxExempt">The instance of "SalesTaxExempt" class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object AddOrEdit(dynamic salesTaxExempt, List<EntityParser.CustomField> customFields)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            salesTaxExempt.audit_user_id = this._UserId;
            salesTaxExempt.audit_ts = System.DateTime.UtcNow;

            object primaryKeyValue = salesTaxExempt.sales_tax_exempt_id;

            if (Cast.To<int>(primaryKeyValue) > 0)
            {
                primaryKeyValue = salesTaxExempt.sales_tax_exempt_id;
                this.Update(salesTaxExempt, int.Parse(salesTaxExempt.sales_tax_exempt_id));
            }
            else
            {
                primaryKeyValue = this.Add(salesTaxExempt);
            }

            string sql = "DELETE FROM core.custom_fields WHERE custom_field_setup_id IN(" +
                         "SELECT custom_field_setup_id " +
                         "FROM core.custom_field_setup " +
                         "WHERE form_name=core.get_custom_field_form_name('core.sales_tax_exempts')" +
                         ");";

            Factory.NonQuery(this._Catalog, sql);

            if (customFields == null)
            {
                return primaryKeyValue;
            }

            foreach (var field in customFields)
            {
                sql = "INSERT INTO core.custom_fields(custom_field_setup_id, resource_id, value) " +
                      "SELECT core.get_custom_field_setup_id_by_table_name('core.sales_tax_exempts', @0::character varying(100)), " +
                      "@1, @2;";

                Factory.NonQuery(this._Catalog, sql, field.FieldName, primaryKeyValue, field.Value);
            }

            return primaryKeyValue;
        }

        /// <summary>
        /// Inserts the instance of SalesTaxExempt class on the database table "core.sales_tax_exempts".
        /// </summary>
        /// <param name="salesTaxExempt">The instance of "SalesTaxExempt" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object Add(dynamic salesTaxExempt)
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
                    Log.Information("Access to add entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}. {SalesTaxExempt}", this._LoginId, salesTaxExempt);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            return Factory.Insert(this._Catalog, salesTaxExempt, "core.sales_tax_exempts", "sales_tax_exempt_id");
        }

        /// <summary>
        /// Inserts or updates multiple instances of SalesTaxExempt class on the database table "core.sales_tax_exempts";
        /// </summary>
        /// <param name="salesTaxExempts">List of "SalesTaxExempt" class to import.</param>
        /// <returns></returns>
        public List<object> BulkImport(List<ExpandoObject> salesTaxExempts)
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ImportData, this._LoginId, this._Catalog, false);
                }

                if (!this.HasAccess)
                {
                    Log.Information("Access to import entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}. {salesTaxExempts}", this._LoginId, salesTaxExempts);
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
                        foreach (dynamic salesTaxExempt in salesTaxExempts)
                        {
                            line++;

                            salesTaxExempt.audit_user_id = this._UserId;
                            salesTaxExempt.audit_ts = System.DateTime.UtcNow;

                            object primaryKeyValue = salesTaxExempt.sales_tax_exempt_id;

                            if (Cast.To<int>(primaryKeyValue) > 0)
                            {
                                result.Add(salesTaxExempt.sales_tax_exempt_id);
                                db.Update("core.sales_tax_exempts", "sales_tax_exempt_id", salesTaxExempt, salesTaxExempt.sales_tax_exempt_id);
                            }
                            else
                            {
                                result.Add(db.Insert("core.sales_tax_exempts", "sales_tax_exempt_id", salesTaxExempt));
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
        /// Updates the row of the table "core.sales_tax_exempts" with an instance of "SalesTaxExempt" class against the primary key value.
        /// </summary>
        /// <param name="salesTaxExempt">The instance of "SalesTaxExempt" class to update.</param>
        /// <param name="salesTaxExemptId">The value of the column "sales_tax_exempt_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Update(dynamic salesTaxExempt, int salesTaxExemptId)
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
                    Log.Information("Access to edit entity \"SalesTaxExempt\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {SalesTaxExempt}", salesTaxExemptId, this._LoginId, salesTaxExempt);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Factory.Update(this._Catalog, salesTaxExempt, salesTaxExemptId, "core.sales_tax_exempts", "sales_tax_exempt_id");
        }

        /// <summary>
        /// Deletes the row of the table "core.sales_tax_exempts" against the primary key value.
        /// </summary>
        /// <param name="salesTaxExemptId">The value of the column "sales_tax_exempt_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Delete(int salesTaxExemptId)
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
                    Log.Information("Access to delete entity \"SalesTaxExempt\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", salesTaxExemptId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "DELETE FROM core.sales_tax_exempts WHERE sales_tax_exempt_id=@0;";
            Factory.NonQuery(this._Catalog, sql, salesTaxExemptId);
        }

        /// <summary>
        /// Performs a select statement on table "core.sales_tax_exempts" producing a paginated result of 10.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesTaxExempt" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetPaginatedResult()
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
                    Log.Information("Access to the first page of the entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.sales_tax_exempts ORDER BY sales_tax_exempt_id LIMIT 10 OFFSET 0;";
            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a select statement on table "core.sales_tax_exempts" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesTaxExempt" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetPaginatedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}.", pageNumber, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            const string sql = "SELECT * FROM core.sales_tax_exempts ORDER BY sales_tax_exempt_id LIMIT 10 OFFSET @0;";

            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this._Catalog, sql, offset);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            const string sql = "SELECT * FROM core.filters WHERE object_name='core.sales_tax_exempts' AND lower(filter_name)=lower(@0);";
            return Factory.Get<EntityParser.Filter>(catalog, sql, filterName).ToList();
        }

        /// <summary>
        /// Performs a filtered count on table "core.sales_tax_exempts".
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesTaxExempt" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM core.sales_tax_exempts WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.SalesTaxExempt(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "core.sales_tax_exempts" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesTaxExempt" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM core.sales_tax_exempts WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.SalesTaxExempt(), filters);

            sql.OrderBy("sales_tax_exempt_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered count on table "core.sales_tax_exempts".
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesTaxExempt" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);
            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM core.sales_tax_exempts WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.SalesTaxExempt(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "core.sales_tax_exempts" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesTaxExempt" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetFiltered(long pageNumber, string filterName)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"SalesTaxExempt\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", pageNumber, this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM core.sales_tax_exempts WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.SalesTaxExempt(), filters);

            sql.OrderBy("sales_tax_exempt_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Core.SalesTaxExempt>(this._Catalog, sql);
        }


    }
}