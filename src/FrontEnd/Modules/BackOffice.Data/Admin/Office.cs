using System.Collections.Generic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.BackOffice.Data.Admin
{
    public class Office
    {
        /// <summary>Gets the collection of all offices.</summary>
        /// <returns>
        ///     An enumerator that allows foreach to be used to process the users in this collection.
        /// </returns>
        public static IEnumerable<Entities.Office.Office> GetOffices(string catalog)
        {
            const string sql = "SELECT * FROM office.offices ORDER BY office_id;";
            return Factory.Get<Entities.Office.Office>(catalog, sql);
        }
    }
}