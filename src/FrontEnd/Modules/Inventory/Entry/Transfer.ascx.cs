using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.StockAdjustmentFactory;
using System;
using MixERP.Net.Framework.Contracts;

namespace MixERP.Net.Core.Modules.Inventory.Entry
{
    public partial class Transfer : MixERPUserControl, ITransaction
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (FormView form = new FormView())
            {
                form.Text = Titles.StockTransferJournal;
                form.StoreServiceUrl = "/Modules/Inventory/Services/ItemData.asmx/GetStores";
                form.ItemServiceUrl = "/Modules/Inventory/Services/ItemData.asmx/GetItems";
                form.UnitServiceUrl = "/Modules/Inventory/Services/ItemData.asmx/GetUnits";
                form.ItemPopupUrl = "/Modules/Inventory/Setup/ItemsPopup.mix?modal=1&CallBackFunctionName=loadItems&AssociatedControlId=ItemIdHidden";
                form.ItemIdQuerySericeUrl = "/Modules/Inventory/Services/ItemData.asmx/GetItemCodeByItemId";
                form.ValidateSides = true;
                form.Catalog = AppUsers.GetCurrentUserDB();
                form.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

                this.Placeholder1.Controls.Add(form);
            }
        }
    }
}