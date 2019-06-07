using System.Collections.Generic;
using System.Data.Common;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.BackOffice.Data.Admin
{
    /// <summary>The user class.</summary>
    public class User
    {
        /// <summary>Gets the collection of all users.</summary>
        /// <returns>
        ///     An enumerator that allows foreach to be used to process the users in this collection.
        /// </returns>
        public static IEnumerable<Entities.Office.UserSelectorView> GetUserSelectorView(string catalog)
        {
            const string sql = "SELECT * FROM office.user_selector_view ORDER BY user_name;";
            return Factory.Get<Entities.Office.UserSelectorView>(catalog, sql);
        }

        public void SetNewPassword(string catalog, int adminUserId, string username, string password)
        {
            try
            {
                const string sql = "SELECT * FROM policy.change_password(@0::integer, @1::text, @2::text);";
                Factory.NonQuery(catalog, sql, adminUserId, username, password);
            }
            catch (DbException ex)
            {
                throw new MixERPException(ex.Message, ex);
            }
        }
    }
}