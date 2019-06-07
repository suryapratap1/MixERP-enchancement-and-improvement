using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.FirstTasks
{
    public class Shipper : FirstStep
    {
        public Shipper()
        {
            this.Order = 110;
            this.Name = Titles.CreateShippingCompany;
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = Labels.CreateShippingCompanyDescription;
            this.Icon = "users icon";
            this.NavigateUrl = "/Modules/Inventory/Setup/Shippers.mix";

            int count = this.CountParties();

            if (count > 0)
            {
                this.Status = true;
                this.Message = string.Format(CultureManager.GetCurrent(), Labels.NShippersFound, count);
                return;
            }

            this.Message = Labels.NoShipperFound;
        }

        private int CountParties()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.shippers;";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}