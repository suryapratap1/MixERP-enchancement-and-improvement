using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.Entities.Office;
using MixERP.Net.Entities.Policy;
using MixERP.Net.FrontEnd.Base;

namespace MixERP.Net.Core.Modules.BackOffice.Services.Policy
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class EntityAccess : MixERPWebService
    {
        [WebMethod]
        public List<AccessType> GetAccessTypes()
        {
            return Data.Policy.EntityAccess.GetAccessTypes(this.Catalog).ToList();
        }

        [WebMethod]
        public List<Role> GetRoles()
        {
            return Data.Policy.EntityAccess.GetRoles(this.Catalog).ToList();
        }

        [WebMethod]
        public List<User> GetUsers()
        {
            return Data.Policy.EntityAccess.GetUsers(this.Catalog).ToList();
        }
    }
}