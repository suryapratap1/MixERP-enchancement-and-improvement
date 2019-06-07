using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.NewUser.FirstTasks
{
    public class CountySalesTax : FirstStep
    {
        public CountySalesTax()
        {
            this.Order = 204;
            this.Name = Titles.CreateCountySalesTax;
            this.Category = Titles.TaxSetup;
            this.CategoryAlias = "tax-setup";

            this.Description = Labels.CreateCountySalesTaxDescription;
            this.Icon = "tasks icon";
            this.NavigateUrl = "/Modules/BackOffice/Tax/CountySalesTaxes.mix";

            int count = this.CountCountySalesTaxes();

            if (count > 0)
            {
                this.Status = true;
                this.Message = string.Format(CultureManager.GetCurrent(), Labels.NCountySalesTaxesDefined, count);
                return;
            }

            this.Message = Labels.NoCountySalesTaxDefined;

            if (!this.HasCountySalesTax())
            {
                this.Status = true;
            }
        }

        private int CountCountySalesTaxes()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            const string sql = "SELECT COUNT(*) FROM core.county_sales_taxes;";
            return Factory.Scalar<int>(catalog, sql, officeId);
        }

        private bool HasCountySalesTax()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            const string sql = "SELECT has_county_sales_tax FROM office.offices WHERE office_id=@0;";
            return Factory.Scalar<bool>(catalog, sql, officeId);
        }
    }
}