using System.Collections.Generic;
using System.Linq;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;

namespace MixERP.Net.FrontEnd.Application
{
    public static class FirstSteps
    {
        public static bool CheckIfPending()
        {
            if (!AppUsers.GetCurrent().View.IsAdmin.ToBool())
            {
                return false;
            }

            IEnumerable<FirstStep> list = FirstStep.GetAll().Where(x => !x.Status);

            if (list.Any())
            {
                return true;
            }

            return false;
        }
    }
}