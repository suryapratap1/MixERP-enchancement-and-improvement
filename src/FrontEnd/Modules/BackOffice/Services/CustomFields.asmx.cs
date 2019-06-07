using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Entities.Core;
using MixERP.Net.Framework;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.Core.Modules.BackOffice.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class CustomFields : WebService
    {
        [WebMethod]
        public List<string> GetForms()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            IEnumerable<CustomFieldForm> forms = Data.CustomFields.GetCustomFieldForms(catalog);


            return forms.Select(f => f.FormName).ToList();
        }

        [WebMethod]
        public List<string> GetDataTypes()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            IEnumerable<CustomFieldDataType> types = Data.CustomFields.GetCustomFieldDataTypes(catalog);


            return types.Select(f => f.DataType).ToList();
        }

        [WebMethod]
        public List<CustomFieldSetup> GetCustomFieldSetups(string formName)
        {
            if (string.IsNullOrWhiteSpace(formName))
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            string catalog = AppUsers.GetCurrentUserDB();
            IEnumerable<CustomFieldSetup> setups = Data.CustomFields.GetCustomFieldSetups(catalog, formName);

            return setups.OrderBy(x => x.FieldOrder).ToList();
        }

        [WebMethod]
        public void SaveCustomFieldSetups(string formName, List<CustomFieldSetup> fields)
        {
            if (string.IsNullOrWhiteSpace(formName))
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            string catalog = AppUsers.GetCurrentUserDB();
            Data.CustomFields.SaveCustomFieldSetups(catalog, formName, fields);
        }
    }
}