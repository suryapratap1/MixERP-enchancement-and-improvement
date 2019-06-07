using System;
using System.IO.Compression;
using System.Security;
using System.Security.Permissions;
using System.Web.Hosting;

namespace MixERP.Net.Common.Helpers
{
    public static class FileSystemHelper
    {
        public static bool IsDirectoryWritable(string directory)
        {
            if (string.IsNullOrWhiteSpace(directory))
            {
                return false;
            }

            FileIOPermission permission = new FileIOPermission(FileIOPermissionAccess.Write, HostingEnvironment.MapPath(directory));
            PermissionSet permissionSet = new PermissionSet(PermissionState.None);
            permissionSet.AddPermission(permission);

            return permissionSet.IsSubsetOf(AppDomain.CurrentDomain.PermissionSet);
        }

        public static void Unzip(string archive, string destnation)
        {
            ZipFile.ExtractToDirectory(archive, destnation);
        }
    }
}