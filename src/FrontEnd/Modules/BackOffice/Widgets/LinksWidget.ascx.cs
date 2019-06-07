using MixERP.Net.Common.Helpers;
using MixERP.Net.Framework.Controls;
using MixERP.Net.i18n.Resources;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.Core.Modules.BackOffice.Widgets
{
    public partial class LinksWidget : MixERPWidget
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            this.CreateWidget(this.Placeholder1);
        }

        private void CreateWidget(Control container)
        {
            using (HtmlGenericControl widget = new HtmlGenericControl("div"))
            {
                widget.ID = "LinksWidget";
                widget.Attributes.Add("class", "four wide column widget");

                using (HtmlGenericControl segment = HtmlControlHelper.GetSegment("ui attached segment"))
                {
                    using (HtmlGenericControl leftFloatedColumn = new HtmlGenericControl("div"))
                    {
                        leftFloatedColumn.Attributes.Add("class", "ui left floated column");
                        this.CreateHeader(leftFloatedColumn);
                        segment.Controls.Add(leftFloatedColumn);
                    }

                    using (HtmlGenericControl rightFloatedColumn = new HtmlGenericControl("div"))
                    {
                        rightFloatedColumn.Attributes.Add("class", "ui right floated column");


                        using (HtmlGenericControl i = HtmlControlHelper.GetIcon("expand disabled icon"))
                        {
                            rightFloatedColumn.Controls.Add(i);
                        }
                        using (HtmlGenericControl i = HtmlControlHelper.GetIcon("move icon"))
                        {
                            rightFloatedColumn.Controls.Add(i);
                        }
                        using (HtmlGenericControl i = HtmlControlHelper.GetIcon("help icon"))
                        {
                            rightFloatedColumn.Controls.Add(i);
                        }
                        using (HtmlGenericControl i = HtmlControlHelper.GetIcon("close icon"))
                        {
                            rightFloatedColumn.Controls.Add(i);
                        }
                        
                        segment.Controls.Add(rightFloatedColumn);
                    }

                    widget.Controls.Add(segment);
                }

                using (HtmlGenericControl segment = HtmlControlHelper.GetSegment("ui attached segment"))
                {
                    this.CreateList(segment);

                    widget.Controls.Add(segment);
                }

                container.Controls.Add(widget);
            }
        }

        private void CreateList(Control container)
        {
            using (HtmlGenericControl ul = new HtmlGenericControl("ul"))
            {
                this.AddListItem(ul, "http://docs.mixerp.org", Titles.Documentation);
                this.AddListItem(ul, "https://github.com/mixerp/mixerp", Titles.DownloadSourceCode);
                this.AddListItem(ul, "https://github.com/mixerp/mixerp/issues", Titles.SubmitBugs);
                this.AddListItem(ul, "http://mixerp.org/forum/", Titles.Support);
                this.AddListItem(ul, "https://www.facebook.com/mixerp.official", Titles.MixERPOnFacebook);

                container.Controls.Add(ul);
            }
        }

        private void AddListItem(HtmlGenericControl ul, string href, string text)
        {
            using (HtmlGenericControl li = new HtmlGenericControl("li"))
            {
                using (HtmlAnchor anchor = new HtmlAnchor())
                {
                    anchor.InnerText = text;
                    anchor.HRef = href;
                    anchor.Target = "_blank";
                    li.Controls.Add(anchor);
                }
                ul.Controls.Add(li);
            }
        }
        private void CreateHeader(Control container)
        {
            using (HtmlGenericControl header = new HtmlGenericControl("div"))
            {
                header.InnerText = Titles.MixERPLinks;
                header.Attributes.Add("class", "ui header");
                container.Controls.Add(header);
            }
        }
    }
}