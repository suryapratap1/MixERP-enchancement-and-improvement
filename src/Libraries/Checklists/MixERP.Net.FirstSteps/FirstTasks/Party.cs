using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.FirstTasks
{
    public class Party : FirstStep
    {
        public Party()
        {
            this.Order = 120;
            this.Name = Titles.CreateParties;
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = Labels.CreatePartiesDescription;
            this.Icon = "users icon";
            this.NavigateUrl = "/Modules/Inventory/Setup/Parties.mix";

            int count = this.CountParties();
            int supplierCount = this.CountSuppliers();

            if (count > 0 && supplierCount > 0)
            {
                this.Status = true;
                this.Message = string.Format(CultureManager.GetCurrent(), Labels.NPartiesFound, count);
                return;
            }

            if (count > 0)
            {
                this.Message = Labels.NoSupplierFound;
                return;
            }

            this.Message = Labels.NoPartyFound;
        }

        private int CountParties()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = "SELECT COUNT(*) FROM core.parties;";
            return Factory.Scalar<int>(catalog, sql);
        }

        private int CountSuppliers()
        {
            string catalog = AppUsers.GetCurrentUserDB();

            const string sql = @"SELECT COUNT(*) FROM core.parties
                                INNER JOIN core.party_types
                                ON core.parties.party_type_id = core.party_types.party_type_id
                                AND core.party_types.is_supplier;
                                ";

            return Factory.Scalar<int>(catalog, sql);
        }
    }
}