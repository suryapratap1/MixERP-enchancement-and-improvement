using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.FirstTasks
{
    public class FiscalYear : FirstStep
    {
        public FiscalYear()
        {
            this.Order = 121;
            this.Name = Titles.CreateFiscalYear;
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = Labels.CreateFiscalYearDescription;
            this.Icon = "bar chart icon";
            this.NavigateUrl = "/Modules/BackOffice/FiscalYear.mix";

            int count = this.CountFrequencySetups();

            if (count > 0)
            {
                this.Status = true;
                this.Message = Titles.OK;
                return;
            }

            this.Message = Labels.NoFiscalYearDefined;
        }

        private int CountFrequencySetups()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.fiscal_year;";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}