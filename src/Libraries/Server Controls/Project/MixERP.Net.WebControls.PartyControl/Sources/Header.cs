using MixERP.Net.i18n.Resources;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.PartyControl
{
    public partial class PartyControl
    {
        private static Control GetHeader()
        {
            using (HtmlGenericControl form = ControlHelper.GetGenericControl(@"div", @"ui form"))
            {
                using (HtmlGenericControl fields = ControlHelper.GetGenericControl("div", "inline fields"))
                {
                    using (HtmlGenericControl partyCodeField = ControlHelper.GetGenericControl(@"div", @"small field"))
                    {
                        using (Literal partyDropDownListLabelLiteral = new Literal())
                        {
                            partyDropDownListLabelLiteral.Text = ControlHelper.GetLabelText(@"PartyCodeTextBox", Titles.SelectCustomer);

                            using (HtmlInputText partyCodeTextBox = ControlHelper.GetInputText(@"PartyCodeTextBox", string.Empty))
                            {
                                partyCodeField.Controls.Add(partyDropDownListLabelLiteral);
                                partyCodeField.Controls.Add(partyCodeTextBox);
                            }

                            fields.Controls.Add(partyCodeField);
                        }
                    }

                    using (HtmlGenericControl partyDropDownListField = ControlHelper.GetGenericControl("div", "medium field"))
                    {
                        using (HtmlSelect partyDropDownList = ControlHelper.GetSelect(@"PartyDropDownList", string.Empty))
                        {
                            partyDropDownListField.Controls.Add(partyDropDownList);
                        }

                        fields.Controls.Add(partyDropDownListField);
                    }

                    using (HtmlButton goButton = ControlHelper.GetButton(@"GoButton", @"ui small teal button", Titles.Go))
                    {
                        fields.Controls.Add(goButton);
                    }

                    form.Controls.Add(fields);
                    return form;
                }
            }
        }
    }
}