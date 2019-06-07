using System.Collections.ObjectModel;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.ReportEngine
{
    public partial class Report
    {
        private Literal bodyContentsLiteral;
        private Literal bottomSectionLiteral;
        private HtmlAnchor closeImageButton;

        /// <summary>
        ///     CommandPanel is displayed at the top of the report.
        /// </summary>
        private Panel commandPanel;

        private Collection<DataTable> dataTableCollection;
        private Collection<string> decimalFieldIndicesCollection;
        private bool disposed;
        private LinkButton emailImageButton;
        private LinkButton pdfLinkButton;
        private LinkButton excelLinkButton;
        private LinkButton wordLinkButton;
        private HtmlAnchor filterAnchor;
        private HtmlAnchor goBottomAnchor;
        private HtmlAnchor goTopAnchor;
        private PlaceHolder gridPlaceHolder;
        private ReportHeader header;
        private HtmlAnchor printAnchor;

        /// <summary>
        ///     ReportBody is displayed below the CommandPanel and contains the following sections:
        ///     1. Report Header
        ///     2. Report Title
        ///     3. Top Section
        ///     4. Report Details (Grid)
        ///     5. Bottom Section
        /// </summary>
        private Panel reportBody;

        private Panel reportContainer;
        private HiddenField reportHidden;
        private string reportPath;
        private HiddenField reportTitleHidden;
        private Literal reportTitleLiteral;
        private Collection<string> runningTotalFieldIndicesCollection;
        private Collection<int> runningTotalTextColumnIndexCollection;
        private Literal topSectionLiteral;

        public override void Dispose()
        {
            if (!this.disposed)
            {
                this.Dispose(true);
                base.Dispose();
            }
        }

        private void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }

            if (this.bodyContentsLiteral != null)
            {
                this.bodyContentsLiteral.Dispose();
                this.bodyContentsLiteral = null;
            }

            if (this.bottomSectionLiteral != null)
            {
                this.bottomSectionLiteral.Dispose();
                this.bottomSectionLiteral = null;
            }

            if (this.closeImageButton != null)
            {
                this.closeImageButton.Dispose();
                this.closeImageButton = null;
            }

            if (this.commandPanel != null)
            {
                this.commandPanel.Dispose();
                this.commandPanel = null;
            }

            if (this.dataTableCollection != null && dataTableCollection.Count > 0)
            {
                for (int i = 0; i < dataTableCollection.Count; i++)
                {
                    if (dataTableCollection[i] != null)
                    {
                        dataTableCollection[i].Dispose();
                        dataTableCollection[i] = null;
                    }
                }

                dataTableCollection = null;
            }

            if (this.emailImageButton != null)
            {
                this.emailImageButton.Dispose();
                this.emailImageButton = null;
            }

            if (this.filterAnchor != null)
            {
                this.filterAnchor.Dispose();
                this.filterAnchor = null;
            }

            if (this.goBottomAnchor != null)
            {
                this.goBottomAnchor.Dispose();
                this.goBottomAnchor = null;
            }

            if (this.goTopAnchor != null)
            {
                this.goTopAnchor.Dispose();
                this.goTopAnchor = null;
            }

            if (this.gridPlaceHolder != null)
            {
                this.gridPlaceHolder.Dispose();
                this.gridPlaceHolder = null;
            }

            if (this.header != null)
            {
                this.header.Dispose();
                this.header = null;
            }

            if (this.printAnchor != null)
            {
                this.printAnchor.Dispose();
                this.printAnchor = null;
            }

            if (this.reportBody != null)
            {
                this.reportBody.Dispose();
                this.reportBody = null;
            }

            if (this.reportContainer != null)
            {
                this.reportContainer.Dispose();
                this.reportContainer = null;
            }


            if (this.reportHidden != null)
            {
                this.reportHidden.Dispose();
                this.reportHidden = null;
            }


            if (this.reportTitleHidden != null)
            {
                this.reportTitleHidden.Dispose();
                this.reportTitleHidden = null;
            }


            if (this.reportTitleLiteral != null)
            {
                this.reportTitleLiteral.Dispose();
                this.reportTitleLiteral = null;
            }


            if (this.topSectionLiteral != null)
            {
                this.topSectionLiteral.Dispose();
                this.topSectionLiteral = null;
            }

            this.disposed = true;
        }
    }
}