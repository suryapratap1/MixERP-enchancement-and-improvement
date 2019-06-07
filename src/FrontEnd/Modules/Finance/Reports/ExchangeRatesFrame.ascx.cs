using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;

namespace MixERP.Net.Core.Modules.Finance.Reports
{
    public partial class ExchangeRatesFrame : MixERPUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public override void OnControlLoad(object sender, EventArgs e)
        {
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();


            Collection<KeyValuePair<string, object>> parameter1 = new Collection<KeyValuePair<string, object>>();
            parameter1.Add(new KeyValuePair<string, object>("@OfficeId", officeId.ToString(CultureInfo.InvariantCulture)));

            Collection<KeyValuePair<string, object>> parameter2 = new Collection<KeyValuePair<string, object>>();
            parameter2.Add(new KeyValuePair<string, object>("@OfficeId", officeId.ToString(CultureInfo.InvariantCulture)));

            using (WebReport report = new WebReport())
            {
                report.AddParameterToCollection(parameter1);
                report.AddParameterToCollection(parameter2);
                report.Path = "~/Modules/Finance/Reports/Source/Exchange.Rates.xml";
                report.AutoInitialize = true;

                this.Placeholder1.Controls.Add(report);
            }
        }
    }
}