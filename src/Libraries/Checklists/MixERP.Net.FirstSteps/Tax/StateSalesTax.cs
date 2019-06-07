using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.NewUser.FirstTasks
{
    public class StateSalesTax : FirstStep
    {
        public StateSalesTax()
        {
            this.Order = 203;
            this.Name = Titles.CreateStateSalesTax;
            this.Category = Titles.TaxSetup;
            this.CategoryAlias = "tax-setup";

            this.Description = Labels.CreateStateSalesTaxDescription;
            this.Icon = "tasks icon";
            this.NavigateUrl = "/Modules/BackOffice/Tax/StateSalesTaxes.mix";

            int count = this.CountStateSalesTaxes();

            if (count > 0)
            {
                this.Status = true;
                this.Message = string.Format(CultureManager.GetCurrent(), Labels.NStateSalesTaxesDefined, count);
                return;
            }

            this.Message = Labels.NoStateSalesTaxDefined;

            if (!this.HasStateSalesTax())
            {
                this.Status = true;
            }
        }

        private int CountStateSalesTaxes()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            const string sql = "SELECT COUNT(*) FROM core.state_sales_taxes;";
            return Factory.Scalar<int>(catalog, sql, officeId);
        }

        private bool HasStateSalesTax()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            const string sql = "SELECT has_state_sales_tax FROM office.offices WHERE office_id=@0;";
            return Factory.Scalar<bool>(catalog, sql, officeId);
        }
    }
}