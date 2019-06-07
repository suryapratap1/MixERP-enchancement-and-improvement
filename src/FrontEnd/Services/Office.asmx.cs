using MixERP.Net.Entities.Office;
using MixERP.Net.Framework;
using MixERP.Net.i18n.Resources;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;

namespace MixERP.Net.FrontEnd.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Office : WebService
    {
        [WebMethod]
        public IEnumerable<DbGetOfficesResult> GetOffices(string catalog)
        {
            IEnumerable<DbGetOfficesResult> offices;

            try
            {
                offices = Data.Office.Offices.GetOffices(catalog);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                throw new MixERPException(Titles.AccessIsDenied);
            }

            return offices;
        }
    }
}