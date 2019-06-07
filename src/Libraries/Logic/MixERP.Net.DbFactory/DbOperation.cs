using MixERP.Net.Framework;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using Npgsql;
using Serilog;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MixERP.Net.DbFactory
{
    public class DbNotificationArgs : EventArgs
    {
        public NpgsqlError Notice { get; set; }
        public string Message { get; set; }
    }

    public class DbOperation
    {
        public EventHandler<DbNotificationArgs> Listen;

        [CLSCompliant(false)]
        public static bool ExecuteNonQuery(string catalog, NpgsqlCommand command)
        {
            try
            {
                if (command != null)
                {
                    if (ValidateCommand(command))
                    {
                        using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.GetConnectionString(catalog)))
                        {
                            command.Connection = connection;
                            connection.Open();

                            command.ExecuteNonQuery();
                            return true;
                        }
                    }
                }

                return false;
            }
            catch (NpgsqlException ex)
            {
                if (ex.Code.StartsWith("P"))
                {
                    string errorMessage = GetDBErrorResource(ex);
                    throw new MixERPException(errorMessage, ex);
                }

                throw;
            }
        }

        [CLSCompliant(false)]
        public static bool ExecuteNonQuery(string catalog, string sql)
        {
            if (string.IsNullOrWhiteSpace(sql))
            {
                return false;
            }

            return ExecuteNonQuery(catalog, new NpgsqlCommand(sql));
        }

        private static string GetDBErrorResource(NpgsqlException ex)
        {
            string message = DbErrors.Get(ex.Code);

            if (message == ex.Code)
            {
                return ex.Message;
            }

            return message;
        }

        [CLSCompliant(false)]
        public static NpgsqlDataAdapter GetDataAdapter(string catalog, NpgsqlCommand command)
        {
            try
            {
                if (command != null)
                {
                    if (ValidateCommand(command))
                    {
                        using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.GetConnectionString(catalog)))
                        {
                            command.Connection = connection;

                            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                            {
                                return adapter;
                            }
                        }
                    }
                }

                return null;
            }
            catch (NpgsqlException ex)
            {
                if (ex.Code.StartsWith("P"))
                {
                    string errorMessage = GetDBErrorResource(ex);
                    throw new MixERPException(errorMessage, ex);
                }

                throw;
            }
        }

        [CLSCompliant(false)]
        public static NpgsqlDataReader GetDataReader(string catalog, NpgsqlCommand command)
        {
            try
            {
                if (command != null)
                {
                    if (ValidateCommand(command))
                    {
                        using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.GetConnectionString(catalog)))
                        {
                            command.Connection = connection;
                            command.Connection.Open();
                            return command.ExecuteReader();
                        }
                    }
                }

                return null;
            }
            catch (NpgsqlException ex)
            {
                if (ex.Code.StartsWith("P"))
                {
                    string errorMessage = GetDBErrorResource(ex);
                    throw new MixERPException(errorMessage, ex);
                }

                throw;
            }
        }

        [CLSCompliant(false)]
        public static DataSet GetDataSet(string catalog, NpgsqlCommand command)
        {
            try
            {
                if (ValidateCommand(command))
                {
                    using (NpgsqlDataAdapter adapter = GetDataAdapter(catalog, command))
                    {
                        using (DataSet set = new DataSet())
                        {
                            adapter.Fill(set);
                            set.Locale = CultureInfo.CurrentUICulture;
                            return set;
                        }
                    }
                }

                return null;
            }
            catch (NpgsqlException ex)
            {
                if (ex.Code.StartsWith("P"))
                {
                    string errorMessage = GetDBErrorResource(ex);
                    throw new MixERPException(errorMessage, ex);
                }

                throw;
            }
        }

        [CLSCompliant(false)]
        public static DataTable GetDataTable(NpgsqlCommand command, string connectionString)
        {
            try
            {
                if (command != null)
                {
                    if (ValidateCommand(command))
                    {
                        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                        {
                            command.Connection = connection;

                            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                            {
                                using (DataTable dataTable = new DataTable())
                                {
                                    dataTable.Locale = CultureManager.GetCurrent();
                                    adapter.Fill(dataTable);
                                    return dataTable;
                                }
                            }
                        }
                    }
                }

                return null;
            }
            catch (NpgsqlException ex)
            {
                if (ex.Code.StartsWith("P"))
                {
                    string errorMessage = GetDBErrorResource(ex);
                    throw new MixERPException(errorMessage, ex);
                }

                throw;
            }
        }

        [CLSCompliant(false)]
        public static DataTable GetDataTable(string catalog, NpgsqlCommand command)
        {
            return GetDataTable(command, DbConnection.GetConnectionString(catalog));
        }

        [CLSCompliant(false)]
        public static DataView GetDataView(string catalog, NpgsqlCommand command)
        {
            if (ValidateCommand(command))
            {
                using (DataView view = new DataView(GetDataTable(catalog, command)))
                {
                    return view;
                }
            }

            return null;
        }

        [CLSCompliant(false)]
        public static object GetScalarValue(string catalog, NpgsqlCommand command)
        {
            try
            {
                if (command != null)
                {
                    if (ValidateCommand(command))
                    {
                        using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.GetConnectionString(catalog)))
                        {
                            command.Connection = connection;
                            connection.Open();
                            return command.ExecuteScalar();
                        }
                    }
                }

                return null;
            }
            catch (NpgsqlException ex)
            {
                if (ex.Code.StartsWith("P"))
                {
                    string errorMessage = GetDBErrorResource(ex);
                    throw new MixERPException(errorMessage, ex);
                }

                throw;
            }
        }

        public static bool IsServerAvailable(string catalog)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.GetConnectionString(catalog)))
                {
                    connection.Open();
                }

                return true;
            }
            catch (NpgsqlException ex)
            {
                Log.Warning("Server is not available: {Exception}.", ex);
            }

            return false;
        }

        public Task ListenNonQuery(string catalog, NpgsqlCommand command)
        {
            try
            {
                if (command != null)
                {
                    if (ValidateCommand(command))
                    {
                        Task task = new Task(delegate
                        {
                            try
                            {
                                using (
                                    NpgsqlConnection connection =
                                        new NpgsqlConnection(DbConnection.GetConnectionString(catalog)))
                                {
                                    command.Connection = connection;
                                    connection.Notice += Connection_Notice;
                                    connection.Open();
                                    command.ExecuteNonQuery();
                                }
                            }
                            catch (NpgsqlException ex)
                            {
                                string errorMessage = ex.Message;

                                if (ex.Code.StartsWith("P"))
                                {
                                    errorMessage = GetDBErrorResource(ex);
                                }

                                EventHandler<DbNotificationArgs> listen = this.Listen;

                                if (listen != null)
                                {
                                    DbNotificationArgs args = new DbNotificationArgs
                                    {
                                        Message = errorMessage
                                    };

                                    listen(this, args);
                                }
                            }                            
                        });

                        return task;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                if (ex.Code.StartsWith("P"))
                {
                    string errorMessage = GetDBErrorResource(ex);
                    throw new MixERPException(errorMessage, ex);
                }

                throw;
            }

            return null;
        }

        private static Collection<string> GetCommandTextParameterCollection(string commandText)
        {
            Collection<string> parameters = new Collection<string>();

            foreach (Match match in Regex.Matches(commandText, @"@(\w+)"))
            {
                parameters.Add(match.Value);
            }

            return parameters;
        }

        private static bool ValidateCommand(NpgsqlCommand command)
        {
            return ValidateParameters(command);
        }

        private static bool ValidateParameters(NpgsqlCommand command)
        {
            Collection<string> commandTextParameters = GetCommandTextParameterCollection(command.CommandText);

            foreach (NpgsqlParameter npgsqlParameter in command.Parameters)
            {
                bool match = false;

                foreach (string commandTextParameter in commandTextParameters)
                {
                    if (npgsqlParameter.ParameterName.Equals(commandTextParameter))
                    {
                        match = true;
                    }
                }

                if (!match)
                {
                    throw new InvalidOperationException(string.Format(CultureManager.GetCurrentUICulture(),
                        Warnings.InvalidParameterName, npgsqlParameter.ParameterName));
                }
            }

            return true;
        }

        private void Connection_Notice(object sender, NpgsqlNoticeEventArgs e)
        {
            EventHandler<DbNotificationArgs> listen = this.Listen;

            if (listen != null)
            {
                DbNotificationArgs args = new DbNotificationArgs
                {
                    Notice = e.Notice,
                    Message = e.Notice.Message
                };

                listen(this, args);
            }
        }
    }
}