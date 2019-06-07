using MixERP.Net.Common.Helpers;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory.Helpers
{
    internal static class TableHelper
    {
        internal static HtmlTableCell GetFieldCell()
        {
            using (HtmlTableCell cell = new HtmlTableCell())
            {
                cell.Attributes.Add("class", "ui field");
                return cell;
            }
        }

        internal static void AddCell(HtmlTableRow row, string text)
        {
            using (HtmlTableCell cell = new HtmlTableCell())
            {
                cell.InnerHtml = text;

                row.Cells.Add(cell);
            }
        }

        internal static void CreateHeaderCell(TableRow row, string text, string targetControlId)
        {
            using (TableHeaderCell cell = new TableHeaderCell())
            {
                if (targetControlId != null)
                {
                    using (HtmlGenericControl label = HtmlControlHelper.GetLabel(text, targetControlId))
                    {
                        cell.Controls.Add(label);
                    }
                }
                else
                {
                    cell.Text = text;
                }

                row.Cells.Add(cell);
            }
        }
    }
}