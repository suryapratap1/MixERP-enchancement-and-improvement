using System;
using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Office;
using MixERP.Net.Entities.Policy;
using PetaPoco;

namespace MixERP.Net.Core.Modules.BackOffice.Data.Policy
{
    public static class EntityAccess
    {
        public static IEnumerable<AccessType> GetAccessTypes(string catalog)
        {
            const string sql = "SELECT * FROM policy.access_types;";
            return Factory.Get<AccessType>(catalog, sql);
        }

        public static IEnumerable<Role> GetRoles(string catalog)
        {
            const string sql = "SELECT * FROM office.roles WHERE NOT is_system;";
            return Factory.Get<Role>(catalog, sql);
        }
        public static IEnumerable<User> GetUsers(string catalog)
        {
            const string sql = "SELECT office.users.* FROM office.users INNER JOIN office.roles ON office.users.role_id = office.roles.role_id WHERE NOT is_system;";
            return Factory.Get<User>(catalog, sql);
        }
    }
}