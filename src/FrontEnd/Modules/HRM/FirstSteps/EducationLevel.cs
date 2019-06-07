using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.Core.Modules.HRM.FirstSteps
{
    public class EducationLevel : FirstStep
    {
        public EducationLevel()
        {
            Order = 1000;
            Name = Titles.CreateEducationLevels;
            Category = Titles.HumanResourceManagement;
            CategoryAlias = "hrm";

            Description = Labels.CreateEducationLevelsDescription;
            Icon = "university icon";
            NavigateUrl = "/Modules/HRM/Setup/EducationLevels.mix";

            long count = CountEducationLevels();

            if (count > 0)
            {
                Status = true;
                Message = Titles.OK;
                return;
            }

            Message = Labels.NoEducationLevelDefined;
        }

        private long CountEducationLevels()
        {
            Data.EducationLevel educationLevel = new Data.EducationLevel
            {
                _Catalog = AppUsers.GetCurrentUserDB(),
                _LoginId = AppUsers.GetCurrent().View.LoginId.ToLong(),
                SkipValidation = true
            };

            return educationLevel.Count();
        }
    }
}