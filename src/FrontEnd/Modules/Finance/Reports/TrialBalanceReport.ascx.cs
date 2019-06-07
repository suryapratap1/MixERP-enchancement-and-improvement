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

namespace MixERP.Net.Core.Modules.Finance.Reports
{
    public partial class TrialBalanceReport : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {

            DateTime fromDate = Conversion.TryCastDate(this.Page.Request["FromDate"]);
            DateTime toDate = Conversion.TryCastDate(this.Page.Request["ToDate"]);
            decimal factor = Conversion.TryCastDecimal(this.Page.Request["Factor"]);
            bool compact = Conversion.TryCastBoolean(this.Page.Request["Compact"]);
            bool changeSide = Conversion.TryCastBoolean(this.Page.Request["ChangeSide"]);
            bool includeZeroBalanceAccounts = Conversion.TryCastBoolean(this.Page.Request["IncludeZeroBalanceAccounts"]);

            int userId = AppUsers.GetCurrent().View.UserId.ToInt();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();


            Collection<KeyValuePair<string, object>> parameter1 = new Collection<KeyValuePair<string, object>>();
            parameter1.Add(new KeyValuePair<string, object>("@From", fromDate));
            parameter1.Add(new KeyValuePair<string, object>("@To", toDate));
            parameter1.Add(new KeyValuePair<string, object>("@OfficeId", officeId.ToString(CultureInfo.InvariantCulture)));
            parameter1.Add(new KeyValuePair<string, object>("@Compact", compact.ToString(CultureInfo.InvariantCulture)));
            parameter1.Add(new KeyValuePair<string, object>("@Factor", factor.ToString(CultureInfo.InvariantCulture)));
            parameter1.Add(new KeyValuePair<string, object>("@UserId", userId.ToString(CultureInfo.InvariantCulture)));
            parameter1.Add(new KeyValuePair<string, object>("@ChangeSideWhenNegative", changeSide.ToString(CultureInfo.InvariantCulture)));
            parameter1.Add(new KeyValuePair<string, object>("@IncludeZeroBalanceAccounts", includeZeroBalanceAccounts.ToString(CultureInfo.InvariantCulture)));
           

            using (WebReport report = new WebReport())
            {
                report.AddParameterToCollection(parameter1);
                report.RunningTotalText = Titles.RunningTotal;
                report.Path = "~/Modules/Finance/Reports/Source/Transactions.TrialBalance.xml";
                report.AutoInitialize = true;

                this.Placeholder1.Controls.Add(report);
            }
        }
    }
}