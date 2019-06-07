using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.Office
{
    public class ItemGroup : FirstStep
    {
        public ItemGroup()
        {
            this.Order = 400;
            this.Name = Titles.CreateItemGroups;
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = Labels.CreateItemGroupsDescription;
            this.Icon = "shop icon";
            this.NavigateUrl = "/Modules/Inventory/Setup/ItemGroups.mix";

            int count = this.CountItemGroups();

            this.Message = string.Format(CultureManager.GetCurrent(), Labels.NItemGroupsFound, count);

            if (count > 2)
            {
                this.Status = true;
            }
        }

        private int CountItemGroups()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.item_groups;";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}