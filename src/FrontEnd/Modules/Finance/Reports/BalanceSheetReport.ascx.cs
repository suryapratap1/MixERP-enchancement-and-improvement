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
    public partial class BalanceSheetReport : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            DateTime previousPeriod = Conversion.TryCastDate(this.Page.Request["PreviousPeriod"]);
            DateTime currentPeriod = Conversion.TryCastDate(this.Page.Request["CurrentPeriod"]);
            decimal factor = Conversion.TryCastDecimal(this.Page.Request["Factor"]);

            int userId = AppUsers.GetCurrent().View.UserId.ToInt();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();


            Collection<KeyValuePair<string, object>> parameter2 = new Collection<KeyValuePair<string, object>>();
            parameter2.Add(new KeyValuePair<string, object>("@PreviousPeriod", previousPeriod));
            parameter2.Add(new KeyValuePair<string, object>("@CurrentPeriod", currentPeriod));
            parameter2.Add(new KeyValuePair<string, object>("@UserId", userId.ToString(CultureInfo.InvariantCulture)));
            parameter2.Add(new KeyValuePair<string, object>("@Factor", factor.ToString(CultureInfo.InvariantCulture)));
            parameter2.Add(new KeyValuePair<string, object>("@OfficeId", officeId.ToString(CultureInfo.InvariantCulture)));

            using (WebReport report = new WebReport())
            {
                report.AddParameterToCollection(parameter2);
                report.Path = "~/Modules/Finance/Reports/Source/Transactions.BalanceSheet.xml";
                report.AutoInitialize = true;

                this.Placeholder1.Controls.Add(report);
            }
        }
    }
}