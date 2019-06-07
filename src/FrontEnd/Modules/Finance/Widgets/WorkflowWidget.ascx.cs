using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Core.Modules.Finance.Data.Core;
using MixERP.Net.Entities.Core;
using MixERP.Net.Framework.Controls;
using MixERP.Net.i18n.Resources;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.Core.Modules.Finance.Widgets
{
    public partial class WorkflowWidget : MixERPWidget
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            this.CreateWidget(this.Placeholder1);
        }

        private void CreateWidget(Control container)
        {
            using (HtmlGenericControl widget = new HtmlGenericControl("div"))
            {
                widget.ID = "WorkflowWidget";
                widget.Attributes.Add("class", "eight wide column widget");

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
            DbGetWorkflowModelResult model = Workflow.GetWorkflowModel(AppUsers.GetCurrentUserDB());

            using (HtmlGenericControl ul = new HtmlGenericControl("ul"))
            {
                HtmlControlHelper.AddListItem(ul, Titles.FlaggedTransactions, model.FlaggedTransactions);
                HtmlControlHelper.AddListItem(ul, Titles.InVerificationStack, model.InVerificationStack);
                HtmlControlHelper.AddListItem(ul, Titles.AutomaticallyApprovedByWorkflow, model.AutoApproved);
                HtmlControlHelper.AddListItem(ul, Titles.ApprovedTransactions, model.Approved);
                HtmlControlHelper.AddListItem(ul, Titles.RejectedTransactions, model.Rejected);
                HtmlControlHelper.AddListItem(ul, Titles.ClosedTransactions, model.Closed);
                HtmlControlHelper.AddListItem(ul, Titles.WithdrawnTransactions, model.Withdrawn);
                container.Controls.Add(ul);
            }
        }

        private void CreateHeader(Control container)
        {
            using (HtmlGenericControl header = new HtmlGenericControl("div"))
            {
                header.Attributes.Add("class", "ui header");
                header.InnerText = Titles.Workflow;

                container.Controls.Add(header);
            }
        }
    }
}