using System;
using System.Web.UI.WebControls;
using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n;

namespace MixERP.Net.WebControls.ReportEngine
{
    public partial class Report
    {
        private void GridView_DataBound(object sender, EventArgs e)
        {
            var grid = (GridView) sender;
            var arg = Conversion.TryCastInteger(grid.ID.Replace("GridView", ""));

            if (string.IsNullOrWhiteSpace(this.runningTotalFieldIndicesCollection[arg]))
            {
                return;
            }

            if (grid.FooterRow == null)
            {
                return;
            }

            grid.FooterRow.Visible = true;

            for (var i = 0; i < this.runningTotalTextColumnIndexCollection[arg]; i++)
            {
                grid.FooterRow.Cells[i].Visible = false;
            }

            grid.FooterRow.Cells[this.runningTotalTextColumnIndexCollection[arg]].ColumnSpan =
                this.runningTotalTextColumnIndexCollection[arg] + 1;
            grid.FooterRow.Cells[this.runningTotalTextColumnIndexCollection[arg]].Text = this.RunningTotalText;
            grid.FooterRow.Cells[this.runningTotalTextColumnIndexCollection[arg]].Style.Add("text-align", "right");
            grid.FooterRow.Cells[this.runningTotalTextColumnIndexCollection[arg]].Font.Bold = true;

            foreach (var field in this.runningTotalFieldIndicesCollection[arg].Split(','))
            {
                var index = Conversion.TryCastInteger(field.Trim());

                decimal total = 0;

                if (index > 0)
                {
                    foreach (GridViewRow row in grid.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            total += Conversion.TryCastDecimal(row.Cells[index].Text);
                        }
                    }


                    var culture = CultureManager.GetCurrent();
                    grid.FooterRow.Cells[index].Text =
                        total.ToString("C", culture).Replace(culture.NumberFormat.CurrencySymbol, "");
                    grid.FooterRow.Cells[index].CssClass = "text right";
                    grid.FooterRow.Cells[index].Font.Bold = true;
                }
            }
        }

        private void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                for (var i = 0; i < e.Row.Cells.Count; i++)
                {
                    var cellText = e.Row.Cells[i].Text;

                    var className = ConfigurationHelper.GetReportParameter("ResourceClassName");

                    var localized = ResourceManager.GetString(className, cellText);

                    cellText = localized;
                    e.Row.Cells[i].Text = cellText;
                }
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var grid = (GridView) sender;
                var arg = Conversion.TryCastInteger(grid.ID.Replace("GridView", ""));


                //Apply formatting on decimal fields
                if (string.IsNullOrWhiteSpace(this.decimalFieldIndicesCollection[arg]))
                {
                    return;
                }

                var decimalFields = this.decimalFieldIndicesCollection[arg];
                foreach (var fieldIndex in decimalFields.Split(','))
                {
                    var index = Conversion.TryCastInteger(fieldIndex);
                    var value = Conversion.TryCastDecimal(e.Row.Cells[index].Text);
                    e.Row.Cells[index].Text = string.Format(CultureManager.GetCurrent(), "{0:N}", value);
                    e.Row.Cells[index].CssClass = "text right";
                }
            }
        }
    }
}