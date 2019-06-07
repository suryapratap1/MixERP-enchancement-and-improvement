using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.NewUser.FirstTasks
{
    public class SalesTax : FirstStep
    {
        public SalesTax()
        {
            this.Order = 205;
            this.Name = Titles.CreateSalesTaxForm;
            this.Category = Titles.TaxSetup;
            this.CategoryAlias = "tax-setup";

            this.Description = Labels.CreateSalesTaxFormDescription;
            this.Icon = "tasks icon";
            this.NavigateUrl = "/Modules/BackOffice/Tax/SalesTaxes.mix";

            int count = this.CountSalesTaxes();

            if (count > 0)
            {
                this.Status = true;
                this.Message = string.Format(CultureManager.GetCurrent(), Labels.NSalesTaxFormsDefined, count);
                return;
            }

            this.Message = Labels.NoSalesTaxFormDefined;
        }

        private int CountSalesTaxes()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            const string sql = "SELECT COUNT(*) FROM core.sales_taxes;";
            return Factory.Scalar<int>(catalog, sql, officeId);
        }
    }
}