using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.NewUser.UserManagment
{
    public class VerificationPolicy : FirstStep
    {
        public VerificationPolicy()
        {
            this.Order = 10;
            this.Name = Titles.VoucherVerificationPolicy;
            this.Category = Titles.UserManagement;
            this.CategoryAlias = "user-management";

            this.Description = Labels.VoucherVerificationPolicyDescription;
            this.Icon = "privacy icon";

            this.NavigateUrl = "/Modules/BackOffice/Policy/VoucherVerification.mix";

            int count = this.CountPolicy();

            if (count > 0)
            {
                this.Message = string.Format(CultureManager.GetCurrent(), Labels.NotDefinedForNUsers, count);
                return;
            }

            this.Status = true;
            this.Message = Titles.OK;
        }

        private int CountPolicy()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            const string sql = @"SELECT COUNT(*)
                                FROM office.users
                                WHERE office.is_admin(user_id)
                                AND user_id NOT IN
                                (
                                    SELECT user_id FROM policy.voucher_verification_policy
                                    WHERE office_id = @0
                                );";

            return Factory.Scalar<int>(catalog, sql, officeId);
        }
    }
}