using MixERP.Net.WebControls.ReportEngine.Data;

namespace MixERP.Net.WebControls.ReportEngine.Helpers
{
    public static class ReportInstaller
    {
        public static void InstallReport(string catalog, string menuCode, string parentMenuCode, int level, string menuText, string path)
        {
            Installer.InstallReport(catalog, menuCode, parentMenuCode, level, menuText, path);
        }
    }
}