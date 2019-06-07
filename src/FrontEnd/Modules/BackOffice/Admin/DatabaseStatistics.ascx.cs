using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Core.Modules.BackOffice.Data.Admin;
using MixERP.Net.Framework.Controls;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.BackOffice.Admin
{
    public partial class DatabaseStatistics : MixERPUserControl
    {
        public override AccessLevel AccessLevel => AccessLevel.AdminOnly;

        public override void OnControlLoad(object sender, EventArgs e)
        {
            this.VacuumButton.OnClientClick = "return(confirm('" + Questions.ConfirmVacuum + "'));";
            this.FullVacuumButton.OnClientClick = "return(confirm('" + Questions.ConfirmVacuumFull + "'));";
            this.AnalyzeButton.OnClientClick = "return(confirm('" + Questions.ConfirmAnalyze + "'));";

            this.VacuumButton.Text = Titles.VacuumDatabase;
            this.FullVacuumButton.Text = Titles.VacuumFullDatabase;
            this.AnalyzeButton.Text = Titles.AnalyzeDatabse;
        }

        protected void AnalyzeButton_Click(object sender, EventArgs e)
        {
            DatabaseUtility utility = new DatabaseUtility();
            utility.Analyze(AppUsers.GetCurrentUserDB());

            this.DisplaySuccess();
        }

        protected void FullVacuumButton_Click(object sender, EventArgs e)
        {
            DatabaseUtility utility = new DatabaseUtility();
            utility.VacuumFull(AppUsers.GetCurrentUserDB());

            this.DisplaySuccess();
        }

        protected void VacuumButton_Click(object sender, EventArgs e)
        {
            DatabaseUtility utility = new DatabaseUtility();
            utility.Vacuum(AppUsers.GetCurrentUserDB());

            this.DisplaySuccess();
        }

        private void DisplaySuccess()
        {
            this.MessageLiteral.Text = @"<div class='ui positive message'>" + Labels.TaskCompletedSuccessfully + @"</div>";
        }
    }
}