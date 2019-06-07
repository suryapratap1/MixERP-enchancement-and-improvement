using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.FirstTasks
{
    public class State : FirstStep
    {
        public State()
        {
            this.Order = 120;
            this.Name = Titles.CreateState;
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = Labels.CreateStateDescription;
            this.Icon = "users icon";
            this.NavigateUrl = "/Modules/BackOffice/States.mix";

            int count = this.CountStates();

            if (count > 0)
            {
                this.Status = true;
                this.Message = string.Format(CultureManager.GetCurrent(), Labels.NStatesFound, count);
                return;
            }

            if (count > 0)
            {
                this.Message = Labels.NoStateFound;
                return;
            }

            this.Message = Labels.NoPartyFound;
        }

        private int CountStates()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.states;";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}