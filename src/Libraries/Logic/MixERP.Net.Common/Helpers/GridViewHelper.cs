using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.Common.Helpers
{
    public static class GridViewHelper
    {
        public static void AddDataBoundControl(GridView grid, string dataField, string headerText, string dataFormatString = "", bool alignRight = false)
        {
            BoundField field = new BoundField();
            field.DataField = dataField;
            field.HeaderText = headerText;
            field.DataFormatString = dataFormatString;

            if (alignRight)
            {
                field.HeaderStyle.CssClass = "text right";
                field.ItemStyle.CssClass = "text right";
            }

            grid.Columns.Add(field);
        }

        public class GridViewSelectTemplate : ITemplate
        {
            public void InstantiateIn(Control container)
            {
                using (HtmlGenericControl toggleCheckBox = new HtmlGenericControl("div"))
                {
                    toggleCheckBox.Attributes.Add("class", "ui toggle checkbox");

                    using (HtmlInputCheckBox checkBox = new HtmlInputCheckBox())
                    {
                        toggleCheckBox.Controls.Add(checkBox);
                    }

                    using (HtmlGenericControl label = new HtmlGenericControl("label"))
                    {
                        toggleCheckBox.Controls.Add(label);
                    }

                    container.Controls.Add(toggleCheckBox);
                }
            }
        }
    }
}