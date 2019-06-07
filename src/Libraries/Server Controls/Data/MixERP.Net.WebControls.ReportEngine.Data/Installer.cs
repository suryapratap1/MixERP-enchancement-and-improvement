using MixERP.Net.DbFactory;
using Npgsql;

namespace MixERP.Net.WebControls.ReportEngine.Data
{
    public static class Installer
    {
        public static void InstallReport(string catalog, string menuCode, string parentMenuCode, int level, string menuText, string path)
        {
            const string sql = @"INSERT INTO core.menus(menu_text, url, menu_code, level, parent_menu_id)
                            SELECT @MenuText, @Path, @MenuCode, @Level, core.get_menu_id(@ParentMenuCode)
                            WHERE NOT EXISTS(SELECT * FROM core.menus WHERE menu_code=@MenuCode);";

            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@MenuCode", menuCode);
                command.Parameters.AddWithValue("@MenuText", menuText);
                command.Parameters.AddWithValue("@Path", path);
                command.Parameters.AddWithValue("@Level", level);
                command.Parameters.AddWithValue("@ParentMenuCode", parentMenuCode);

                DbOperation.ExecuteNonQuery(catalog, command);
            }
        }
    }
}