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
    /// Provides simplified data access features to perform SCRUD operation on the database table "core.salesperson_bonus_setups".
    /// </summary>
    public class SalespersonBonusSetup : DbAccess, ISalespersonBonusSetupRepository
    {
        /// <summary>
        /// The schema of this table. Returns literal "core".
        /// </summary>
        public override string _ObjectNamespace => "core";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "salesperson_bonus_setups".
        /// </summary>
        public override string _ObjectName => "salesperson_bonus_setups";

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
        /// Performs SQL count on the table "core.salesperson_bonus_setups".
        /// </summary>
        /// <returns>Returns the number of rows of the table "core.salesperson_bonus_setups".</returns>
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
                    Log.Information("Access to count entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT COUNT(*) FROM core.salesperson_bonus_setups;";
            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "core.salesperson_bonus_setups" to return all instances of the "SalespersonBonusSetup" class. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalespersonBonusSetup" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetAll()
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
                    Log.Information("Access to the export entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.salesperson_bonus_setups ORDER BY salesperson_bonus_setup_id;";
            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "core.salesperson_bonus_setups" to return all instances of the "SalespersonBonusSetup" class to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalespersonBonusSetup" class.</returns>
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
                    Log.Information("Access to the export entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.salesperson_bonus_setups ORDER BY salesperson_bonus_setup_id;";
            return Factory.Get<dynamic>(this._Catalog, sql);
        }

        /// <summary>
        /// Executes a select query on the table "core.salesperson_bonus_setups" with a where filter on the column "salesperson_bonus_setup_id" to return a single instance of the "SalespersonBonusSetup" class. 
        /// </summary>
        /// <param name="salespersonBonusSetupId">The column "salesperson_bonus_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of "SalespersonBonusSetup" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.SalespersonBonusSetup Get(int salespersonBonusSetupId)
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
                    Log.Information("Access to the get entity \"SalespersonBonusSetup\" filtered by \"SalespersonBonusSetupId\" with value {SalespersonBonusSetupId} was denied to the user with Login ID {_LoginId}", salespersonBonusSetupId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.salesperson_bonus_setups WHERE salesperson_bonus_setup_id=@0;";
            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this._Catalog, sql, salespersonBonusSetupId).FirstOrDefault();
        }

        /// <summary>
        /// Gets the first record of the table "core.salesperson_bonus_setups". 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of "SalespersonBonusSetup" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.SalespersonBonusSetup GetFirst()
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
                    Log.Information("Access to the get the first record of entity \"SalespersonBonusSetup\" was denied to the user with Login ID {_LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.salesperson_bonus_setups ORDER BY salesperson_bonus_setup_id LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this._Catalog, sql).FirstOrDefault();
        }

        /// <summary>
        /// Gets the previous record of the table "core.salesperson_bonus_setups" sorted by salespersonBonusSetupId.
        /// </summary>
        /// <param name="salespersonBonusSetupId">The column "salesperson_bonus_setup_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of "SalespersonBonusSetup" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.SalespersonBonusSetup GetPrevious(int salespersonBonusSetupId)
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
                    Log.Information("Access to the get the previous entity of \"SalespersonBonusSetup\" by \"SalespersonBonusSetupId\" with value {SalespersonBonusSetupId} was denied to the user with Login ID {_LoginId}", salespersonBonusSetupId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.salesperson_bonus_setups WHERE salesperson_bonus_setup_id < @0 ORDER BY salesperson_bonus_setup_id DESC LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this._Catalog, sql, salespersonBonusSetupId).FirstOrDefault();
        }

        /// <summary>
        /// Gets the next record of the table "core.salesperson_bonus_setups" sorted by salespersonBonusSetupId.
        /// </summary>
        /// <param name="salespersonBonusSetupId">The column "salesperson_bonus_setup_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of "SalespersonBonusSetup" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.SalespersonBonusSetup GetNext(int salespersonBonusSetupId)
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
                    Log.Information("Access to the get the next entity of \"SalespersonBonusSetup\" by \"SalespersonBonusSetupId\" with value {SalespersonBonusSetupId} was denied to the user with Login ID {_LoginId}", salespersonBonusSetupId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.salesperson_bonus_setups WHERE salesperson_bonus_setup_id > @0 ORDER BY salesperson_bonus_setup_id LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this._Catalog, sql, salespersonBonusSetupId).FirstOrDefault();
        }


        /// <summary>
        /// Gets the last record of the table "core.salesperson_bonus_setups". 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of "SalespersonBonusSetup" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public MixERP.Net.Entities.Core.SalespersonBonusSetup GetLast()
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
                    Log.Information("Access to the get the last record of entity \"SalespersonBonusSetup\" was denied to the user with Login ID {_LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.salesperson_bonus_setups ORDER BY salesperson_bonus_setup_id DESC LIMIT 1;";
            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this._Catalog, sql).FirstOrDefault();
        }

        /// <summary>
        /// Executes a select query on the table "core.salesperson_bonus_setups" with a where filter on the column "salesperson_bonus_setup_id" to return a multiple instances of the "SalespersonBonusSetup" class. 
        /// </summary>
        /// <param name="salespersonBonusSetupIds">Array of column "salesperson_bonus_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of "SalespersonBonusSetup" class mapped to the database row.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> Get(int[] salespersonBonusSetupIds)
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
                    Log.Information("Access to entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}. salespersonBonusSetupIds: {salespersonBonusSetupIds}.", this._LoginId, salespersonBonusSetupIds);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.salesperson_bonus_setups WHERE salesperson_bonus_setup_id IN (@0);";

            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this._Catalog, sql, salespersonBonusSetupIds);
        }

        /// <summary>
        /// Custom fields are user defined form elements for core.salesperson_bonus_setups.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for the table core.salesperson_bonus_setups</returns>
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
                    Log.Information("Access to get custom fields for entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            string sql;
            if (string.IsNullOrWhiteSpace(resourceId))
            {
                sql = "SELECT * FROM core.custom_field_definition_view WHERE table_name='core.salesperson_bonus_setups' ORDER BY field_order;";
                return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql);
            }

            sql = "SELECT * from core.get_custom_field_definition('core.salesperson_bonus_setups'::text, @0::text) ORDER BY field_order;";
            return Factory.Get<PetaPoco.CustomField>(this._Catalog, sql, resourceId);
        }

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of core.salesperson_bonus_setups.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table core.salesperson_bonus_setups</returns>
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
                    Log.Information("Access to get display field for entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT salesperson_bonus_setup_id AS key, salesperson_bonus_setup_id as value FROM core.salesperson_bonus_setups;";
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
        /// Inserts or updates the instance of SalespersonBonusSetup class on the database table "core.salesperson_bonus_setups".
        /// </summary>
        /// <param name="salespersonBonusSetup">The instance of "SalespersonBonusSetup" class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object AddOrEdit(dynamic salespersonBonusSetup, List<EntityParser.CustomField> customFields)
        {
            if (string.IsNullOrWhiteSpace(this._Catalog))
            {
                return null;
            }

            salespersonBonusSetup.audit_user_id = this._UserId;
            salespersonBonusSetup.audit_ts = System.DateTime.UtcNow;

            object primaryKeyValue = salespersonBonusSetup.salesperson_bonus_setup_id;

            if (Cast.To<int>(primaryKeyValue) > 0)
            {
                primaryKeyValue = salespersonBonusSetup.salesperson_bonus_setup_id;
                this.Update(salespersonBonusSetup, int.Parse(salespersonBonusSetup.salesperson_bonus_setup_id));
            }
            else
            {
                primaryKeyValue = this.Add(salespersonBonusSetup);
            }

            string sql = "DELETE FROM core.custom_fields WHERE custom_field_setup_id IN(" +
                         "SELECT custom_field_setup_id " +
                         "FROM core.custom_field_setup " +
                         "WHERE form_name=core.get_custom_field_form_name('core.salesperson_bonus_setups')" +
                         ");";

            Factory.NonQuery(this._Catalog, sql);

            if (customFields == null)
            {
                return primaryKeyValue;
            }

            foreach (var field in customFields)
            {
                sql = "INSERT INTO core.custom_fields(custom_field_setup_id, resource_id, value) " +
                      "SELECT core.get_custom_field_setup_id_by_table_name('core.salesperson_bonus_setups', @0::character varying(100)), " +
                      "@1, @2;";

                Factory.NonQuery(this._Catalog, sql, field.FieldName, primaryKeyValue, field.Value);
            }

            return primaryKeyValue;
        }

        /// <summary>
        /// Inserts the instance of SalespersonBonusSetup class on the database table "core.salesperson_bonus_setups".
        /// </summary>
        /// <param name="salespersonBonusSetup">The instance of "SalespersonBonusSetup" class to insert.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public object Add(dynamic salespersonBonusSetup)
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
                    Log.Information("Access to add entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}. {SalespersonBonusSetup}", this._LoginId, salespersonBonusSetup);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            return Factory.Insert(this._Catalog, salespersonBonusSetup, "core.salesperson_bonus_setups", "salesperson_bonus_setup_id");
        }

        /// <summary>
        /// Inserts or updates multiple instances of SalespersonBonusSetup class on the database table "core.salesperson_bonus_setups";
        /// </summary>
        /// <param name="salespersonBonusSetups">List of "SalespersonBonusSetup" class to import.</param>
        /// <returns></returns>
        public List<object> BulkImport(List<ExpandoObject> salespersonBonusSetups)
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.ImportData, this._LoginId, this._Catalog, false);
                }

                if (!this.HasAccess)
                {
                    Log.Information("Access to import entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}. {salespersonBonusSetups}", this._LoginId, salespersonBonusSetups);
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
                        foreach (dynamic salespersonBonusSetup in salespersonBonusSetups)
                        {
                            line++;

                            salespersonBonusSetup.audit_user_id = this._UserId;
                            salespersonBonusSetup.audit_ts = System.DateTime.UtcNow;

                            object primaryKeyValue = salespersonBonusSetup.salesperson_bonus_setup_id;

                            if (Cast.To<int>(primaryKeyValue) > 0)
                            {
                                result.Add(salespersonBonusSetup.salesperson_bonus_setup_id);
                                db.Update("core.salesperson_bonus_setups", "salesperson_bonus_setup_id", salespersonBonusSetup, salespersonBonusSetup.salesperson_bonus_setup_id);
                            }
                            else
                            {
                                result.Add(db.Insert("core.salesperson_bonus_setups", "salesperson_bonus_setup_id", salespersonBonusSetup));
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
        /// Updates the row of the table "core.salesperson_bonus_setups" with an instance of "SalespersonBonusSetup" class against the primary key value.
        /// </summary>
        /// <param name="salespersonBonusSetup">The instance of "SalespersonBonusSetup" class to update.</param>
        /// <param name="salespersonBonusSetupId">The value of the column "salesperson_bonus_setup_id" which will be updated.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Update(dynamic salespersonBonusSetup, int salespersonBonusSetupId)
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
                    Log.Information("Access to edit entity \"SalespersonBonusSetup\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {SalespersonBonusSetup}", salespersonBonusSetupId, this._LoginId, salespersonBonusSetup);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Factory.Update(this._Catalog, salespersonBonusSetup, salespersonBonusSetupId, "core.salesperson_bonus_setups", "salesperson_bonus_setup_id");
        }

        /// <summary>
        /// Deletes the row of the table "core.salesperson_bonus_setups" against the primary key value.
        /// </summary>
        /// <param name="salespersonBonusSetupId">The value of the column "salesperson_bonus_setup_id" which will be deleted.</param>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Delete(int salespersonBonusSetupId)
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
                    Log.Information("Access to delete entity \"SalespersonBonusSetup\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", salespersonBonusSetupId, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "DELETE FROM core.salesperson_bonus_setups WHERE salesperson_bonus_setup_id=@0;";
            Factory.NonQuery(this._Catalog, sql, salespersonBonusSetupId);
        }

        /// <summary>
        /// Performs a select statement on table "core.salesperson_bonus_setups" producing a paginated result of 10.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalespersonBonusSetup" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetPaginatedResult()
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
                    Log.Information("Access to the first page of the entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            const string sql = "SELECT * FROM core.salesperson_bonus_setups ORDER BY salesperson_bonus_setup_id LIMIT 10 OFFSET 0;";
            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a select statement on table "core.salesperson_bonus_setups" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalespersonBonusSetup" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetPaginatedResult(long pageNumber)
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
                    Log.Information("Access to Page #{Page} of the entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}.", pageNumber, this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            const string sql = "SELECT * FROM core.salesperson_bonus_setups ORDER BY salesperson_bonus_setup_id LIMIT 10 OFFSET @0;";

            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this._Catalog, sql, offset);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            const string sql = "SELECT * FROM core.filters WHERE object_name='core.salesperson_bonus_setups' AND lower(filter_name)=lower(@0);";
            return Factory.Get<EntityParser.Filter>(catalog, sql, filterName).ToList();
        }

        /// <summary>
        /// Performs a filtered count on table "core.salesperson_bonus_setups".
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalespersonBonusSetup" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM core.salesperson_bonus_setups WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.SalespersonBonusSetup(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "core.salesperson_bonus_setups" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalespersonBonusSetup" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}. Filters: {Filters}.", pageNumber, this._LoginId, filters);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM core.salesperson_bonus_setups WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.SalespersonBonusSetup(), filters);

            sql.OrderBy("salesperson_bonus_setup_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered count on table "core.salesperson_bonus_setups".
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalespersonBonusSetup" class using the filter.</returns>
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
                    Log.Information("Access to count entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);
            Sql sql = Sql.Builder.Append("SELECT COUNT(*) FROM core.salesperson_bonus_setups WHERE 1 = 1");
            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.SalespersonBonusSetup(), filters);

            return Factory.Scalar<long>(this._Catalog, sql);
        }

        /// <summary>
        /// Performs a filtered select statement on table "core.salesperson_bonus_setups" producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalespersonBonusSetup" class.</returns>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetFiltered(long pageNumber, string filterName)
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
                    Log.Information("Access to Page #{Page} of the filtered entity \"SalespersonBonusSetup\" was denied to the user with Login ID {LoginId}. Filter: {Filter}.", pageNumber, this._LoginId, filterName);
                    throw new UnauthorizedException("Access is denied.");
                }
            }

            List<EntityParser.Filter> filters = this.GetFilters(this._Catalog, filterName);

            long offset = (pageNumber - 1) * 10;
            Sql sql = Sql.Builder.Append("SELECT * FROM core.salesperson_bonus_setups WHERE 1 = 1");

            MixERP.Net.EntityParser.Data.Service.AddFilters(ref sql, new MixERP.Net.Entities.Core.SalespersonBonusSetup(), filters);

            sql.OrderBy("salesperson_bonus_setup_id");

            if (pageNumber > 0)
            {
                sql.Append("LIMIT @0", 10);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<MixERP.Net.Entities.Core.SalespersonBonusSetup>(this._Catalog, sql);
        }


    }
}