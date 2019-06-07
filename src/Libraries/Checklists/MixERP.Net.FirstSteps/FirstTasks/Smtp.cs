using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.FirstTasks
{
    public class Smtp : FirstStep
    {
        public Smtp()
        {
            this.Order = 181;
            this.Name = Titles.SetupEmail;
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = Labels.SetupEmailDescription;
            this.Icon = "mail icon";
            this.NavigateUrl = "/Modules/BackOffice/OTS/Smtp.mix";

            if (this.CountSmtp() > 0)
            {
                this.Status = true;
                this.Message = Titles.OK;
                return;
            }

            this.Message = Labels.SMTPIsDisabled;
        }

        private int CountSmtp()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM config.smtp WHERE enabled;";
            return Factory.Scalar<int>(catalog, sql);
        }
    }
}