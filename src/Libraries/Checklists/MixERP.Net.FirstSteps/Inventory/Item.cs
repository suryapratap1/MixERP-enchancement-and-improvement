using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.Office
{
    public class Item : FirstStep
    {
        public Item()
        {
            this.Order = 410;
            this.Name = Titles.CreateItemOrService;
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = Labels.CreateItemOrServiceDescription;
            this.Icon = "shop icon";
            this.NavigateUrl = "/Modules/Inventory/Setup/Items.mix";

            int count = this.CountItems();

            this.Message = string.Format(CultureManager.GetCurrent(), Labels.NItemsFound, count);

            if (count > 2)
            {
                this.Status = true;
            }
        }

        private int CountItems()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.items;";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}