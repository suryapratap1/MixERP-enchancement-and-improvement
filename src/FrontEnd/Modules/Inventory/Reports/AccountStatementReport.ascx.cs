using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace MixERP.Net.Core.Modules.Inventory.Reports
{
    public partial class AccountStatementReport : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            string itemCode = this.Page.Request["ItemCode"];
            DateTime from = Conversion.TryCastDate(this.Page.Request["From"]);
            DateTime to = Conversion.TryCastDate(this.Page.Request["To"]);
            int storeId = Conversion.TryCastInteger(this.Page.Request["StoreId"]);

            int userId = AppUsers.GetCurrent().View.UserId.ToInt();


            Collection<KeyValuePair<string, object>> parameter1 = new Collection<KeyValuePair<string, object>>();
            parameter1.Add(new KeyValuePair<string, object>("@ItemCode", itemCode));

            Collection<KeyValuePair<string, object>> parameter2 = new Collection<KeyValuePair<string, object>>();
            parameter2.Add(new KeyValuePair<string, object>("@From", from));
            parameter2.Add(new KeyValuePair<string, object>("@To", to));
            parameter2.Add(new KeyValuePair<string, object>("@UserId", userId.ToString(CultureInfo.InvariantCulture)));
            parameter2.Add(new KeyValuePair<string, object>("@ItemCode", itemCode));
            parameter2.Add(new KeyValuePair<string, object>("@StoreId", storeId.ToString(CultureInfo.InvariantCulture)));

            using (WebReport report = new WebReport())
            {
                report.AddParameterToCollection(parameter1);
                report.AddParameterToCollection(parameter2);
                report.RunningTotalText = Titles.RunningTotal;
                report.Path = "~/Modules/Inventory/Reports/Source/Inventory.AccountStatement.xml";
                report.AutoInitialize = true;

                this.Controls.Add(report);
            }
        }
    }
}