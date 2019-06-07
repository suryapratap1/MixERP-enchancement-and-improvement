using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.FirstTasks
{
    public class Frequency : FirstStep
    {
        public Frequency()
        {
            this.Order = 122;
            this.Name = Titles.CreateFrequencies;
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = Labels.CreateFrequenciesDescription;
            this.Icon = "circle notched icon";
            this.NavigateUrl = "/Modules/BackOffice/Frequency.mix";

            int count = this.CountFrequencySetups();

            if (count % 12 == 0)
            {
                this.Status = true;
                this.Message = Labels.FrequencySetupIsComplete;
                return;
            }

            this.Message = string.Format(CultureManager.GetCurrent(), Labels.NOutOfNFrequenciesDefined,
                count);
        }

        private int CountFrequencySetups()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.frequency_setups;";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}