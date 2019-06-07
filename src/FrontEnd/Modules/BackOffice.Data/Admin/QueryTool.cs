using Npgsql;
using System;
using System.Data;

namespace MixERP.Net.Core.Modules.BackOffice.Data.Admin
{
    [Obsolete]
    public static class QueryTool
    {
        public static DataTable GetDataTable(string catalog, NpgsqlCommand command)
        {
            return DbFactory.DbOperation.GetDataTable(catalog, command);
        }
    }
}