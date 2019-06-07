using System.IO;

namespace MixERP.Net.Common.Helpers
{
    public static class PathHelper
    {
        public static string Combine(string path1, string path2)
        {
            string normalized = NormalizePhysicalPath(path2);
            return Path.Combine(path1, normalized);
        }

        public static string NormalizePhysicalPath(string path)
        {
            string normalized = path.Replace("/", "\\");

            if (normalized.StartsWith("\\"))
            {
                normalized = normalized.Substring(1);
            }

            return normalized;
        }
    }
}