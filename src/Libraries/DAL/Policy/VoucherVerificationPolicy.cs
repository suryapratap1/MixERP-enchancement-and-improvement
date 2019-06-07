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

namespace MixERP.Net.Schemas.Policy.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "policy.voucher_verification_policy".
    /// </summary>
    public class VoucherVerificationPolicy : DbAccess, IVoucherVerificationPolicyRepository
    {
        /// <summary>
        /// The schema of this table. Returns literal "policy".
        /// </summary>
        public override string _ObjectNamespace => "policy";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "voucher_verification_policy".
        /// </summary>
        public override string _ObjectName => "voucher_verification_policy";

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
        /// Performs SQL count on the table "policy.voucher_verification_policy".
        /// </summary>
        /// <returns>Returns the number of rows of the table "policy.voucher_verification_policy".</returns>
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
                    Log.Information("Access to count entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT COUNT(*) FROM policy.voucher_verification_policy;";
            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "policy.voucher_verification_policy" to return all instances of the "VoucherVerificationPolicy" class. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "VoucherVerificationPolicy" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetAll()
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
                    Log.Information("Access to the export entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM policy.voucher_verification_policy ORDER BY policy_id;";
            return Factory.Get<MixERP.Net.Entities.Policy.VoucherVerificationPolicy>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "policy.voucher_verification_policy" to return all instances of the "VoucherVerificationPolicy" class to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "VoucherVerificationPolicy" class.</returns>
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
                    Log.Information("Access to the export entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM policy.voucher_verification_policy ORDER BY policy_id;";
            return Factory.Get<dynamic>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "policy.voucher_verification_policy" with a where filter on the column "policy_id" to return a single instance of the "VoucherVerificationPolicy" class. 
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of "VoucherVerificationPolicy" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Policy.VoucherVerificationPolicy Get(int policyId)
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
                    Log.Information("Access to the get entity \"VoucherVerificationPolicy\" filtered by \"PolicyId\" with value {PolicyId} was denied to the user with Login ID {_LoginId}", policyId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM policy.voucher_verification_policy WHERE policy_id=@0;";
            return Factory.Get<MixERP.Net.Entities.Policy.VoucherVerificationPolicy>(this._Catalog, sql, policyId).FirstOrDefault();
        }

        /// <summary>
        /// Gets the first record of the table "policy.voucher_verification_policy". 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of "VoucherVerificationPolicy" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetFirst()
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
                    Log.Information("Access to the get the first record of entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {_LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM policy.voucher_verification_policy ORDER BY policy_id LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Policy.VoucherVerificationPolicy>(this._Catalog, sql).FirstOrDefault();
        }

        /// <summary>
        /// Gets the previous record of the table "policy.voucher_verification_policy" sorted by policyId.
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of "VoucherVerificationPolicy" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetPrevious(int policyId)
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
                    Log.Information("Access to the get the previous entity of \"VoucherVerificationPolicy\" by \"PolicyId\" with value {PolicyId} was denied to the user with Login ID {_LoginId}", policyId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM policy.voucher_verification_policy WHERE policy_id < @0 ORDER BY policy_id DESC LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Policy.VoucherVerificationPolicy>(this._Catalog, sql, policyId).FirstOrDefault();
        }

        /// <summary>
        /// Gets the next record of the table "policy.voucher_verification_policy" sorted by policyId.
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of "VoucherVerificationPolicy" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetNext(int policyId)
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
                    Log.Information("Access to the get the next entity of \"VoucherVerificationPolicy\" by \"PolicyId\" with value {PolicyId} was denied to the user with Login ID {_LoginId}", policyId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM policy.voucher_verification_policy WHERE policy_id > @0 ORDER BY policy_id LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Policy.VoucherVerificationPolicy>(this._Catalog, sql, policyId).FirstOrDefault();
        }


        /// <summary>
        /// Gets the last record of the table "policy.voucher_verification_policy". 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of "VoucherVerificationPolicy" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetLast()
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
                    Log.Information("Access to the get the last record of entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {_LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM policy.voucher_verification_policy ORDER BY policy_id DESC LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Policy.VoucherVerificationPolicy>(this._Catalog, sql).FirstOrDefault();
        }

        /// <summary>
        /// Executes a select query on the table "policy.voucher_verification_policy" with a where filter on the column "policy_id" to return a multiple instances of the "VoucherVerificationPolicy" class. 
        /// </summary>
        /// <param name="policyIds">Array of column "policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of "VoucherVerificationPolicy" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> Get(int[] policyIds)
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
                    Log.Information("Access to entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}. policyIds: {policyIds}.", this._LoginId, policyIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM policy.voucher_verification_policy WHERE policy_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Policy.VoucherVerificationPolicy>(this._Catalog, sql, policyIds);
        }

        /// <summary>
        /// Custom fields are user defined form elements for policy.voucher_verification_policy.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table policy.voucher_verification_policy</returns>
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
                    Log.Information("Access to get custom fields for entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
            if (string.IsNullOrWhiteSpace(resourceId))
            {
                sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='policy.voucher_verification_policy' ORDER BY field_order;";
                return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('policy.voucher_verification_policy'::text, @0::text) ORDER BY field_order;";
            return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of policy.voucher_verification_policy.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table policy.voucher_verification_policy</returns>
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
                    Log.Information("Access to get display field for entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT policy_id AS key, policy_id as value FROM policy.voucher_verification_policy;";
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
        /// Inserts or updates the instance of VoucherVerificationPolicy class on the database table "policy.voucher_verification_policy".
        /// </summary>
        /// <param name="voucherVerificationPolicy">The instance of "VoucherVerificationPolicy" class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object AddOrEdit(dynamic voucherVerificationPolicy, List<EntityParser.CustomField> customFields)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            voucherVerificationPolicy.audit_user_id = this._UserId;
            voucherVerificationPolicy.audit_ts = System.DateTime.UtcNow;

            object primaryKeyValue = voucherVerificationPolicy.policy_id;

            if (Cast.To<int>(primaryKeyValue) > 0)
            {
                primaryKeyValue = voucherVerificationPolicy.policy_id;
                this.Update(voucherVerificationPolicy, int.Parse(voucherVerificationPolicy.policy_id));
            }
            else
            {
                primaryKeyValue = this.Add(voucherVerificationPolicy);
            }

            string sql = "DELETE FROM core.custom_fields WHERE custom_field_setup_id IN(" +
                         "SELECT custom_field_setup_id " +
                         "FROM core.custom_field_setup " +
                         "WHERE form_name=core.get_custom_field_form_name('policy.voucher_verification_policy')" +
                         ");";

            Factory.NonQuery(this._Catalog, sql);

            if (customFields == null)
            {
                return primaryKeyValue;
            }

            foreach (var field in customFields)
            {
                sql = "INSERT INTO core.custom_fields(custom_field_setup_id, resource_id, value) " +
                      "SELECT core.get_custom_field_setup_id_by_table_name('policy.voucher_verification_policy', @0::character varying(100)), " +
                      "@1, @2;";

                Factory.NonQuery(this._Catalog, sql, field.FieldName, primaryKeyValue, field.Value);
            }

            return primaryKeyValue;
        }

        /// <summary>
        /// Inserts the instance of VoucherVerificationPolicy class on the database table "policy.voucher_verification_policy".
        /// </summary>
        /// <param name="voucherVerificationPolicy">The instance of "VoucherVerificationPolicy" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object Add(dynamic voucherVerificationPolicy)
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
                    Log.Information("Access to add entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}. {VoucherVerificationPolicy}", this._LoginId, voucherVerificationPolicy);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            return Factory.Insert(this._Catalog, voucherVerificationPolicy, "policy.voucher_verification_policy", "policy_id");
        }

        /// <summary>
        /// Inserts or updates multiple instances of VoucherVerificationPolicy class on the database table "policy.voucher_verification_policy";
        /// </summary>
        /// <param name="voucherVerificationPolicies">List of "VoucherVerificationPolicy" class to import.</param>
        /// <returns></returns>
        public List<object> BulkImport(List<ExpandoObject> voucherVerificationPolicies)
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ImportData, this._LoginId, this._Catalog, false);
                }

                if (!this.HasAccess)
                {
                    Log.Information("Access to import entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}. {voucherVerificationPolicies}", this._LoginId, voucherVerificationPolicies);
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
                        foreach (dynamic voucherVerificationPolicy in voucherVerificationPolicies)
                        {
                            line++;

                            voucherVerificationPolicy.audit_user_id = this._UserId;
                            voucherVerificationPolicy.audit_ts = System.DateTime.UtcNow;

                            object primaryKeyValue = voucherVerificationPolicy.policy_id;

                            if (Cast.To<int>(primaryKeyValue) > 0)
                            {
                                result.Add(voucherVerificationPolicy.policy_id);
                                db.Update("policy.voucher_verification_policy", "policy_id", voucherVerificationPolicy, voucherVerificationPolicy.policy_id);
                            }
                            else
                            {
                                result.Add(db.Insert("policy.voucher_verification_policy", "policy_id", voucherVerificationPolicy));
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
        /// Updates the row of the table "policy.voucher_verification_policy" with an instance of "VoucherVerificationPolicy" class against the primary key value.
        /// </summary>
        /// <param name="voucherVerificationPolicy">The instance of "VoucherVerificationPolicy" class to update.</param>
        /// <param name="policyId">The value of the column "policy_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Update(dynamic voucherVerificationPolicy, int policyId)
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
                    Log.Information("Access to edit entity \"VoucherVerificationPolicy\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {VoucherVerificationPolicy}", policyId, this._LoginId, voucherVerificationPolicy);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Factory.Update(this._Catalog, voucherVerificationPolicy, policyId, "policy.voucher_verification_policy", "policy_id");
        }

        /// <summary>
        /// Deletes the row of the table "policy.voucher_verification_policy" against the primary key value.
        /// </summary>
        /// <param name="policyId">The value of the column "policy_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Delete(int policyId)
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
                    Log.Information("Access to delete entity \"VoucherVerificationPolicy\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", policyId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "DELETE FROM policy.voucher_verification_policy WHERE policy_id=@0;";
            Factory.NonQuery(this._Catalog, sql, policyId);
        }

        /// <summary>
        /// Performs a select statement on table "policy.voucher_verification_policy" producing a paginated result of 10.
        /// </summary>
        /// <returns>Returns the first page of collection of "VoucherVerificationPolicy" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetPaginatedResult()
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
                    Log.Information("Access to the first page of the entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM policy.voucher_verification_policy ORDER BY policy_id LIMIT 10 OFFSET 0;";
            return Factory.Get<MixERP.Net.Entities.Policy.VoucherVerificationPolicy>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a select statement on table "policy.voucher_verification_policy" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "VoucherVerificationPolicy" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetPaginatedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}.", pageNumber, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            const string sql = "SELECT * FROM policy.voucher_verification_policy ORDER BY policy_id LIMIT 10 OFFSET @0;";

            return Factory.Get<MixERP.Net.Entities.Policy.VoucherVerificationPolicy>(this._Catalog, sql, offset);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            const string sql = "SELECT * FROM core.filters WHERE object_name='policy.voucher_verification_policy' AND lower(filter_name)=lower(@0);";
            return Factory.Get<EntityParser.Filter>(catalog, sql, filterName).ToList();
        }

        /// <summary>
        /// Performs a filtered count on table "policy.voucher_verification_policy".
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "VoucherVerificationPolicy" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM policy.voucher_verification_policy WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Policy.VoucherVerificationPolicy(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "policy.voucher_verification_policy" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "VoucherVerificationPolicy" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM policy.voucher_verification_policy WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Policy.VoucherVerificationPolicy(), filters);

            sql.OrderBy("policy_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Policy.VoucherVerificationPolicy>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered count on table "policy.voucher_verification_policy".
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "VoucherVerificationPolicy" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);
            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM policy.voucher_verification_policy WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Policy.VoucherVerificationPolicy(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "policy.voucher_verification_policy" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "VoucherVerificationPolicy" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetFiltered(long pageNumber, string filterName)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"VoucherVerificationPolicy\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", pageNumber, this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM policy.voucher_verification_policy WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Policy.VoucherVerificationPolicy(), filters);

            sql.OrderBy("policy_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Policy.VoucherVerificationPolicy>(this._Catalog, sql);
        }


    }
}