using System;
using System.Web.UI.HtmlControls;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Core.Modules.Inventory.Data.Transactions;
using MixERP.Net.Framework.Contracts;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.StockAdjustmentFactory;

namespace MixERP.Net.Core.Modules.Inventory.Entry
{
    public partial class TransferDelivery : MixERPUserControl, ITransaction
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            long tranId = Conversion.TryCastLong(this.Page.Request.QueryString["RequestId"]);

            if (!this.IsValidStockTransferRequestId(tranId))
            {
                using (HtmlGenericControl header = new HtmlGenericControl("h1"))
                {
                    header.InnerHtml = Warnings.AccessIsDenied;
                    this.Placeholder1.Controls.Add(header);

                    return;
                }
            }

            using (FormView form = new FormView())
            {
                form.Text = Titles.StockTransferDelivery;
                form.StoreServiceUrl = "/Modules/Inventory/Services/ItemData.asmx/GetStores";
                form.ItemServiceUrl = "/Modules/Inventory/Services/ItemData.asmx/GetItems";
                form.UnitServiceUrl = "/Modules/Inventory/Services/ItemData.asmx/GetUnits";
                form.ItemPopupUrl = "/Modules/Inventory/Setup/ItemsPopup.mix?modal=1&CallBackFunctionName=loadItems&AssociatedControlId=ItemIdHidden";
                form.ItemIdQuerySericeUrl = "/Modules/Inventory/Services/ItemData.asmx/GetItemCodeByItemId";
                form.ShippingCompanyServiceUrl = "/Modules/Inventory/Services/ItemData.asmx/GetShippers";
                form.DisplayShipper = true;
                form.DisplaySourceStore = true;
                form.ValidateSides = false;
                form.HideSides = true;
                form.Catalog = AppUsers.GetCurrentUserDB();
                form.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

                this.Placeholder1.Controls.Add(form);
            }
        }

        private bool IsValidStockTransferRequestId(long requestId)
        {
            if (requestId <= 0)
            {
                return false;
            }

            return StockTransferRequest.IsValidStockTransferRequestId(AppUsers.GetCurrentUserDB(), requestId);
        }
    }
}