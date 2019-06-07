using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Core.Modules.Finance.Data.Helpers;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace MixERP.Net.Core.Modules.Finance.Reports
{
    public partial class GLAdviceReport : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            string tranId = this.Page.Request["TranId"];
            string tranCode = this.Page.Request["TranCode"];

            if (Conversion.TryCastLong(tranId).Equals(0))
            {
                if (!string.IsNullOrWhiteSpace(tranCode))
                {
                    tranId =
                        Transaction.GetTranIdByTranCode(AppUsers.GetCurrentUserDB(), tranCode)
                            .ToString(CultureInfo.InvariantCulture);
                }
            }

            Collection<KeyValuePair<string, object>> list = new Collection<KeyValuePair<string, object>>();
            list.Add(new KeyValuePair<string, object>("@transaction_master_id", tranId));

            using (WebReport report = new WebReport())
            {
                report.AddParameterToCollection(list);
                report.AddParameterToCollection(list);
                report.RunningTotalText = Titles.RunningTotal;
                report.Path = "~/Modules/Finance/Reports/Source/Transactions.GLEntry.xml";
                report.AutoInitialize = true;

                this.Placeholder1.Controls.Add(report);
            }
        }
    }
}