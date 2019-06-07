using MixERP.Net.i18n.Resources;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.PartyControl
{
    public partial class PartyControl
    {
        private Control GetTabs()
        {
            using (HtmlGenericControl tabList = ControlHelper.GetGenericControl(@"div", @"ui tabular top attached menu"))
            {
                using (HtmlAnchor homeAnchor = ControlHelper.GetAnchor("active item", Titles.Home, "home", "home icon"))
                {
                    tabList.Controls.Add(homeAnchor);
                }

                using (HtmlAnchor partySummaryAnchor = ControlHelper.GetAnchor("item", Titles.PartySummary, "party-summary", "user icon"))
                {
                    tabList.Controls.Add(partySummaryAnchor);
                }

                using (HtmlAnchor transactionSummaryAnchor = ControlHelper.GetAnchor("item", Titles.TransactionSummary, "transaction-summary", "book icon"))
                {
                    tabList.Controls.Add(transactionSummaryAnchor);
                }

                using (HtmlAnchor contactInfoAnchor = ControlHelper.GetAnchor("item", Titles.AddressAndContactInfo, "contact-info", "globe icon"))
                {
                    tabList.Controls.Add(contactInfoAnchor);
                }

                return tabList;
            }
        }
    }
}