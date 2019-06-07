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

namespace MixERP.Net.Core.Modules.HRM.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "hrm.employment_status_codes".
    /// </summary>
    public class EmploymentStatusCode : DbAccess, IEmploymentStatusCodeRepository
    {
        /// <summary>
        /// The schema of this table. Returns literal "hrm".
        /// </summary>
        public override string _ObjectNamespace => "hrm";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "employment_status_codes".
        /// </summary>
        public override string _ObjectName => "employment_status_codes";

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
        /// Performs SQL count on the table "hrm.employment_status_codes".
        /// </summary>
        /// <returns>Returns the number of rows of the table "hrm.employment_status_codes".</returns>
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
                    Log.Information("Access to count entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT COUNT(*) FROM hrm.employment_status_codes;";
            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "hrm.employment_status_codes" to return all instances of the "EmploymentStatusCode" class. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "EmploymentStatusCode" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetAll()
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
                    Log.Information("Access to the export entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM hrm.employment_status_codes ORDER BY employment_status_code_id;";
            return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatusCode>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "hrm.employment_status_codes" to return all instances of the "EmploymentStatusCode" class to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "EmploymentStatusCode" class.</returns>
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
                    Log.Information("Access to the export entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM hrm.employment_status_codes ORDER BY employment_status_code_id;";
            return Factory.Get<dynamic>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "hrm.employment_status_codes" with a where filter on the column "employment_status_code_id" to return a single instance of the "EmploymentStatusCode" class. 
        /// </summary>
        /// <param name="employmentStatusCodeId">The column "employment_status_code_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of "EmploymentStatusCode" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.HRM.EmploymentStatusCode Get(int employmentStatusCodeId)
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
                    Log.Information("Access to the get entity \"EmploymentStatusCode\" filtered by \"EmploymentStatusCodeId\" with value {EmploymentStatusCodeId} was denied to the user with Login ID {_LoginId}", employmentStatusCodeId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM hrm.employment_status_codes WHERE employment_status_code_id=@0;";
            return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatusCode>(this._Catalog, sql, employmentStatusCodeId).FirstOrDefault();
        }

        /// <summary>
        /// Gets the first record of the table "hrm.employment_status_codes". 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of "EmploymentStatusCode" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.HRM.EmploymentStatusCode GetFirst()
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
                    Log.Information("Access to the get the first record of entity \"EmploymentStatusCode\" was denied to the user with Login ID {_LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM hrm.employment_status_codes ORDER BY employment_status_code_id LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatusCode>(this._Catalog, sql).FirstOrDefault();
        }

        /// <summary>
        /// Gets the previous record of the table "hrm.employment_status_codes" sorted by employmentStatusCodeId.
        /// </summary>
        /// <param name="employmentStatusCodeId">The column "employment_status_code_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of "EmploymentStatusCode" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.HRM.EmploymentStatusCode GetPrevious(int employmentStatusCodeId)
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
                    Log.Information("Access to the get the previous entity of \"EmploymentStatusCode\" by \"EmploymentStatusCodeId\" with value {EmploymentStatusCodeId} was denied to the user with Login ID {_LoginId}", employmentStatusCodeId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM hrm.employment_status_codes WHERE employment_status_code_id < @0 ORDER BY employment_status_code_id DESC LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatusCode>(this._Catalog, sql, employmentStatusCodeId).FirstOrDefault();
        }

        /// <summary>
        /// Gets the next record of the table "hrm.employment_status_codes" sorted by employmentStatusCodeId.
        /// </summary>
        /// <param name="employmentStatusCodeId">The column "employment_status_code_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of "EmploymentStatusCode" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.HRM.EmploymentStatusCode GetNext(int employmentStatusCodeId)
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
                    Log.Information("Access to the get the next entity of \"EmploymentStatusCode\" by \"EmploymentStatusCodeId\" with value {EmploymentStatusCodeId} was denied to the user with Login ID {_LoginId}", employmentStatusCodeId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM hrm.employment_status_codes WHERE employment_status_code_id > @0 ORDER BY employment_status_code_id LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatusCode>(this._Catalog, sql, employmentStatusCodeId).FirstOrDefault();
        }


        /// <summary>
        /// Gets the last record of the table "hrm.employment_status_codes". 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of "EmploymentStatusCode" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.HRM.EmploymentStatusCode GetLast()
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
                    Log.Information("Access to the get the last record of entity \"EmploymentStatusCode\" was denied to the user with Login ID {_LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM hrm.employment_status_codes ORDER BY employment_status_code_id DESC LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatusCode>(this._Catalog, sql).FirstOrDefault();
        }

        /// <summary>
        /// Executes a select query on the table "hrm.employment_status_codes" with a where filter on the column "employment_status_code_id" to return a multiple instances of the "EmploymentStatusCode" class. 
        /// </summary>
        /// <param name="employmentStatusCodeIds">Array of column "employment_status_code_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of "EmploymentStatusCode" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> Get(int[] employmentStatusCodeIds)
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
                    Log.Information("Access to entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}. employmentStatusCodeIds: {employmentStatusCodeIds}.", this._LoginId, employmentStatusCodeIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM hrm.employment_status_codes WHERE employment_status_code_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatusCode>(this._Catalog, sql, employmentStatusCodeIds);
        }

        /// <summary>
        /// Custom fields are user defined form elements for hrm.employment_status_codes.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table hrm.employment_status_codes</returns>
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
                    Log.Information("Access to get custom fields for entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
            if (string.IsNullOrWhiteSpace(resourceId))
            {
                sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='hrm.employment_status_codes' ORDER BY field_order;";
                return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('hrm.employment_status_codes'::text, @0::text) ORDER BY field_order;";
            return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of hrm.employment_status_codes.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table hrm.employment_status_codes</returns>
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
                    Log.Information("Access to get display field for entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT employment_status_code_id AS key, status_code || ' (' || status_code_name || ')' as value FROM hrm.employment_status_codes;";
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
        /// Inserts or updates the instance of EmploymentStatusCode class on the database table "hrm.employment_status_codes".
        /// </summary>
        /// <param name="employmentStatusCode">The instance of "EmploymentStatusCode" class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object AddOrEdit(dynamic employmentStatusCode, List<EntityParser.CustomField> customFields)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            employmentStatusCode.audit_user_id = this._UserId;
            employmentStatusCode.audit_ts = System.DateTime.UtcNow;

            object primaryKeyValue = employmentStatusCode.employment_status_code_id;

            if (Cast.To<int>(primaryKeyValue) > 0)
            {
                primaryKeyValue = employmentStatusCode.employment_status_code_id;
                this.Update(employmentStatusCode, int.Parse(employmentStatusCode.employment_status_code_id));
            }
            else
            {
                primaryKeyValue = this.Add(employmentStatusCode);
            }

            string sql = "DELETE FROM core.custom_fields WHERE custom_field_setup_id IN(" +
                         "SELECT custom_field_setup_id " +
                         "FROM core.custom_field_setup " +
                         "WHERE form_name=core.get_custom_field_form_name('hrm.employment_status_codes')" +
                         ");";

            Factory.NonQuery(this._Catalog, sql);

            if (customFields == null)
            {
                return primaryKeyValue;
            }

            foreach (var field in customFields)
            {
                sql = "INSERT INTO core.custom_fields(custom_field_setup_id, resource_id, value) " +
                      "SELECT core.get_custom_field_setup_id_by_table_name('hrm.employment_status_codes', @0::character varying(100)), " +
                      "@1, @2;";

                Factory.NonQuery(this._Catalog, sql, field.FieldName, primaryKeyValue, field.Value);
            }

            return primaryKeyValue;
        }

        /// <summary>
        /// Inserts the instance of EmploymentStatusCode class on the database table "hrm.employment_status_codes".
        /// </summary>
        /// <param name="employmentStatusCode">The instance of "EmploymentStatusCode" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object Add(dynamic employmentStatusCode)
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
                    Log.Information("Access to add entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}. {EmploymentStatusCode}", this._LoginId, employmentStatusCode);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            return Factory.Insert(this._Catalog, employmentStatusCode, "hrm.employment_status_codes", "employment_status_code_id");
        }

        /// <summary>
        /// Inserts or updates multiple instances of EmploymentStatusCode class on the database table "hrm.employment_status_codes";
        /// </summary>
        /// <param name="employmentStatusCodes">List of "EmploymentStatusCode" class to import.</param>
        /// <returns></returns>
        public List<object> BulkImport(List<ExpandoObject> employmentStatusCodes)
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ImportData, this._LoginId, this._Catalog, false);
                }

                if (!this.HasAccess)
                {
                    Log.Information("Access to import entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}. {employmentStatusCodes}", this._LoginId, employmentStatusCodes);
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
                        foreach (dynamic employmentStatusCode in employmentStatusCodes)
                        {
                            line++;

                            employmentStatusCode.audit_user_id = this._UserId;
                            employmentStatusCode.audit_ts = System.DateTime.UtcNow;

                            object primaryKeyValue = employmentStatusCode.employment_status_code_id;

                            if (Cast.To<int>(primaryKeyValue) > 0)
                            {
                                result.Add(employmentStatusCode.employment_status_code_id);
                                db.Update("hrm.employment_status_codes", "employment_status_code_id", employmentStatusCode, employmentStatusCode.employment_status_code_id);
                            }
                            else
                            {
                                result.Add(db.Insert("hrm.employment_status_codes", "employment_status_code_id", employmentStatusCode));
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
        /// Updates the row of the table "hrm.employment_status_codes" with an instance of "EmploymentStatusCode" class against the primary key value.
        /// </summary>
        /// <param name="employmentStatusCode">The instance of "EmploymentStatusCode" class to update.</param>
        /// <param name="employmentStatusCodeId">The value of the column "employment_status_code_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Update(dynamic employmentStatusCode, int employmentStatusCodeId)
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
                    Log.Information("Access to edit entity \"EmploymentStatusCode\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {EmploymentStatusCode}", employmentStatusCodeId, this._LoginId, employmentStatusCode);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Factory.Update(this._Catalog, employmentStatusCode, employmentStatusCodeId, "hrm.employment_status_codes", "employment_status_code_id");
        }

        /// <summary>
        /// Deletes the row of the table "hrm.employment_status_codes" against the primary key value.
        /// </summary>
        /// <param name="employmentStatusCodeId">The value of the column "employment_status_code_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Delete(int employmentStatusCodeId)
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
                    Log.Information("Access to delete entity \"EmploymentStatusCode\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", employmentStatusCodeId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "DELETE FROM hrm.employment_status_codes WHERE employment_status_code_id=@0;";
            Factory.NonQuery(this._Catalog, sql, employmentStatusCodeId);
        }

        /// <summary>
        /// Performs a select statement on table "hrm.employment_status_codes" producing a paginated result of 10.
        /// </summary>
        /// <returns>Returns the first page of collection of "EmploymentStatusCode" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetPaginatedResult()
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
                    Log.Information("Access to the first page of the entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM hrm.employment_status_codes ORDER BY employment_status_code_id LIMIT 10 OFFSET 0;";
            return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatusCode>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a select statement on table "hrm.employment_status_codes" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "EmploymentStatusCode" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetPaginatedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}.", pageNumber, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            const string sql = "SELECT * FROM hrm.employment_status_codes ORDER BY employment_status_code_id LIMIT 10 OFFSET @0;";

            return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatusCode>(this._Catalog, sql, offset);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            const string sql = "SELECT * FROM core.filters WHERE object_name='hrm.employment_status_codes' AND lower(filter_name)=lower(@0);";
            return Factory.Get<EntityParser.Filter>(catalog, sql, filterName).ToList();
        }

        /// <summary>
        /// Performs a filtered count on table "hrm.employment_status_codes".
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "EmploymentStatusCode" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM hrm.employment_status_codes WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.HRM.EmploymentStatusCode(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "hrm.employment_status_codes" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "EmploymentStatusCode" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM hrm.employment_status_codes WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.HRM.EmploymentStatusCode(), filters);

            sql.OrderBy("employment_status_code_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatusCode>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered count on table "hrm.employment_status_codes".
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "EmploymentStatusCode" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);
            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM hrm.employment_status_codes WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.HRM.EmploymentStatusCode(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "hrm.employment_status_codes" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "EmploymentStatusCode" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetFiltered(long pageNumber, string filterName)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"EmploymentStatusCode\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", pageNumber, this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM hrm.employment_status_codes WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.HRM.EmploymentStatusCode(), filters);

            sql.OrderBy("employment_status_code_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.HRM.EmploymentStatusCode>(this._Catalog, sql);
        }


    }
}