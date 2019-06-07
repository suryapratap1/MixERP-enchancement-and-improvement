using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace MixERP.Net.Common.Helpers
{
    public static class DirectoryHelper
    {
        public static void Empty(this DirectoryInfo directory)
        {
            if (!Directory.Exists(directory.FullName))
            {
                return;
            }

            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo subDirectory in directory.GetDirectories())
            {
                subDirectory.Delete(true);
            }
        }

        public static void CopyDirectory(string source, string destination)
        {
            FileSystem.CopyDirectory(source, destination, true);
        }
    }
}